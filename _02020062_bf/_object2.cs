namespace Maple2.Trigger._02020062_bf {
    public static class _object2 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {5101}, arg2: false);
                context.SetUserValue(triggerId: 99990014, key: "EliteSpawn", value: 0);
                context.SetInteractObject(arg1: new[] {12000108}, arg2: 2);
            }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "ObjectStart") == 1) {
                    return new State레버2_Guide메시지(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State레버2_Guide메시지 : TriggerState {
            internal State레버2_Guide메시지(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {722}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "ObjectStart") == 2) {
                    return new StateWait(context);
                }

                if (context.UserDetected(arg1: new[] {9012})) {
                    context.SetEventUI(arg1: 1, arg2: "$02020062_BF__OBJECT2__0$", arg3: 5000, arg4: "9012");
                    return new State레버2_체크(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State레버2_체크 : TriggerState {
            internal State레버2_체크(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "ObjectStart") == 2) {
                    return new StateWait(context);
                }

                if (context.MonsterDead(arg1: new[] {712})) {
                    return new State레버2_발동(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State레버2_발동 : TriggerState {
            internal State레버2_발동(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {5101}, arg2: true);
                context.SetInteractObject(arg1: new[] {12000108}, arg2: 1);
                context.SetEventUI(arg1: 1, arg2: "$02020062_BF__OBJECT2__1$", arg3: 5000, arg4: "9012");
            }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "ObjectStart") == 2) {
                    return new StateWait(context);
                }

                if (context.MonsterDead(arg1: new[] {701})) {
                    return new StateEnd(context);
                }

                if (context.ObjectInteracted(arg1: new[] {12000108}, arg2: 0)) {
                    return new State레버2_MonsterAppear(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State레버2_MonsterAppear : TriggerState {
            internal State레버2_MonsterAppear(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 99990014, key: "EliteSpawn", value: 1);
            }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "ObjectStart") == 2) {
                    return new StateWait(context);
                }

                if (context.MonsterDead(arg1: new[] {701})) {
                    return new StateEnd(context);
                }

                if (context.WaitTick(waitTick: 20000)) {
                    return new State레버2_재활성(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State레버2_재활성 : TriggerState {
            internal State레버2_재활성(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {12000108}, arg2: 1);
            }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "ObjectStart") == 2 && context.MonsterDead(arg1: new[] {701})) {
                    return new StateEnd(context);
                }

                if (context.ObjectInteracted(arg1: new[] {12000108}, arg2: 0)) {
                    return new State레버2_재활성_대기(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State레버2_재활성_대기 : TriggerState {
            internal State레버2_재활성_대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "ObjectStart") == 2 && context.MonsterDead(arg1: new[] {701})) {
                    return new StateEnd(context);
                }

                if (context.WaitTick(waitTick: 20000)) {
                    return new State레버2_재활성(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnd : TriggerState {
            internal StateEnd(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {5101}, arg2: false);
                context.SetUserValue(triggerId: 99990014, key: "EliteSpawn", value: 2);
                context.DestroyMonster(arg1: new[] {722}, arg2: false);
                context.SetInteractObject(arg1: new[] {12000108}, arg2: 2);
            }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}