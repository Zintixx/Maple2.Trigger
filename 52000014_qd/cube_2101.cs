namespace Maple2.Trigger._52000014_qd {
    public static class _cube_2101 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{2101, 2102}, visible: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetEffect(triggerIds: new []{12101}, visible: false);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{92101})) {
                    return new State무너짐01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State무너짐01 : TriggerState {
            internal State무너짐01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "1", seconds: 5);
                context.SetEffect(triggerIds: new []{12101}, visible: true);
                context.SetMesh(triggerIds: new []{2101}, visible: false, arg3: 0, arg4: 0, arg5: 1f);
                context.SetMesh(triggerIds: new []{2102}, visible: false, arg3: 500, arg4: 0, arg5: 1f);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "1")) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnd : TriggerState {
            internal StateEnd(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{12101}, visible: false);
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
