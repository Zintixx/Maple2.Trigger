namespace Maple2.Trigger._63000079_cs {
    public static class _trigger_04 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {304}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
            }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {104})) {
                    return new StateSetup04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSetup04 : TriggerState {
            internal StateSetup04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {304}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
            }

            public override TriggerState Execute() {
                if (!context.UserDetected(arg1: new[] {104})) {
                    return new StateSetup04끝(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSetup04끝 : TriggerState {
            internal StateSetup04끝(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "404", arg2: 2, arg3: false);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "404")) {
                    return new StateWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}