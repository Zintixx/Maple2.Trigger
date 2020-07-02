namespace Maple2.Trigger._02000355_bf {
    public static class _actor11 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {611}, arg2: false);
                context.SetActor(arg1: 211, arg2: true, arg3: "Damg_B");
            }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {11001})) {
                    return new StateMonster소환대기(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMonster소환대기 : TriggerState {
            internal StateMonster소환대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {611}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3500)) {
                    return new StateMonster소환(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMonster소환 : TriggerState {
            internal StateMonster소환(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {2011}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new State더미해제(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State더미해제 : TriggerState {
            internal State더미해제(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetActor(arg1: 211, arg2: false, arg3: "Damg_B");
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {2011})) {
                    return new State소멸(context);
                }

                if (context.MonsterDead(arg1: new[] {2099})) {
                    return new State소멸(context);
                }

                if (context.NpcDetected(arg1: 105, arg2: new[] {2011})) {
                    context.DestroyMonster(arg1: new[] {2011});
                    return new State리젠준비(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateWaitTime : TriggerState {
            internal StateWaitTime(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 30000)) {
                    return new State리젠준비(context);
                }

                if (context.MonsterDead(arg1: new[] {2099})) {
                    return new State소멸(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State리젠준비 : TriggerState {
            internal State리젠준비(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetActor(arg1: 211, arg2: true, arg3: "Regen_A");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State소멸 : TriggerState {
            internal State소멸(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {2011});
            }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}