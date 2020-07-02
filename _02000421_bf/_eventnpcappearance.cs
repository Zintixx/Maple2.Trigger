namespace Maple2.Trigger._02000421_bf {
    public static class _eventnpcappearance {
        public class StateWaitStart : TriggerState {
            internal StateWaitStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                return new StateBossSpawn대기(context);
            }

            public override void OnExit() { }
        }

        private class StateBossSpawn대기 : TriggerState {
            internal StateBossSpawn대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {111, 121, 131}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "EventNpcAppearance") == 1) {
                    return new State우호적NPCAppear(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State우호적NPCAppear : TriggerState {
            internal State우호적NPCAppear(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {111}, arg2: true);
                context.DestroyMonster(arg1: new[] {121}, arg2: true);
                context.DestroyMonster(arg1: new[] {131}, arg2: true);
                context.CreateMonster(arg1: new[] {11, 21, 31}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 10000)) {
                    return new StateWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "EventNpcAppearance") == 2) {
                    return new StateWaitStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}