namespace Maple2.Trigger._02000328_bf {
    public static class _level_01_08 {
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
                context.SetCube(ids: new[] {5108}, isVisible: false);
                context.SetMesh(arg1: new[] {31801, 31802, 31803, 31804, 31805, 31806, 31807, 31808, 31809, 31810, 31811, 31812, 31813, 31814, 31815, 31816, 31817, 31818, 31819, 31820, 31821, 31822}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new[] {41801}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {10006})) {
                    context.SetMesh(arg1: new[] {31801, 31802, 31803, 31804, 31805, 31806, 31807, 31808, 31809, 31810, 31811, 31812, 31813, 31814, 31815, 31816, 31817, 31818, 31819, 31820, 31821, 31822}, arg2: true, arg3: 0, arg4: 200, arg5: 2f);
                    context.SetMesh(arg1: new[] {41801}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
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