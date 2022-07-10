namespace Maple2.Trigger._65000003_bd {
    public static class _wait {
        public class StateStart : TriggerState {
            internal StateStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "60", seconds: 60, clearAtZero: true, display: false);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{104})) {
                    return new State어나운스01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State어나운스01 : TriggerState {
            internal State어나운스01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityId: 26500301, textId: 26500301, duration: 4500);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new State어나운스01(context);
                }

                if (context.GetUserCount(boxId: 104) == 2) {
                    return new StateEnd(context);
                }

                if (context.TimeExpired(timerId: "60")) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() {
                context.HideGuideSummary(entityId: 26500301);
            }
        }

        private class StateEnd : TriggerState {
            internal StateEnd(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
