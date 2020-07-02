namespace Maple2.Trigger._02000328_bf {
    public static class _level_01_03 {
        public class StateStart : TriggerState {
            internal StateStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new StateWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCube(ids: new[] {5103}, isVisible: false);
                context.SetMesh(arg1: new[] {31301, 31302, 31303, 31304, 31305, 31306, 31307, 31308, 31309, 31310, 31311, 31312, 31313, 31314, 31315, 31316}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new[] {41301, 41302, 41303}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {10002})) {
                    context.SetMesh(arg1: new[] {31301, 31302, 31303, 31304, 31305, 31306, 31307, 31308, 31309, 31310, 31311, 31312, 31313, 31314, 31315, 31316}, arg2: true, arg3: 0, arg4: 200, arg5: 2f);
                    context.SetMesh(arg1: new[] {41301, 41302, 41303}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
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