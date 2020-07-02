namespace Maple2.Trigger._52010038_qd {
    public static class _npc_1 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {6201}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "GaugeStart") == 1) {
                    return new StateNpc체크(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateNpc체크 : TriggerState {
            internal StateNpc체크(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.MonsterInCombat(arg1: new[] {1801})) {
                    return new State이펙트(context);
                }

                if (!context.MonsterInCombat(arg1: new[] {1801})) {
                    return new StateCreation(context);
                }

                if (context.GetUserValue(key: "GaugeClosed") == 1) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State이펙트 : TriggerState {
            internal State이펙트(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {6201}, arg2: true);
            }

            public override TriggerState Execute() {
                if (!context.MonsterInCombat(arg1: new[] {1801})) {
                    return new StateCreation(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCreation : TriggerState {
            internal StateCreation(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {6201}, arg2: false);
                context.InitNpcRotation(arg1: new[] {1801});
                context.CreateMonster(arg1: new[] {4000}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateNpc체크(context);
                }

                if (context.GetUserValue(key: "GaugeClosed") == 1) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnd : TriggerState {
            internal StateEnd(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}