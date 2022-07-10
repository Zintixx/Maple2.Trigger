namespace Maple2.Trigger._63000002_cs {
    public static class _reaction_object_12 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{5001})) {
                    return new State채집가능(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State채집가능 : TriggerState {
            internal State채집가능(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(interactIds: new []{612}, state: 1);
            }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{612}, arg2: 2)) {
                    context.CreateItem(spawnIds: new []{1012});
                    return new State채집완료(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State채집완료 : TriggerState {
            internal State채집완료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "12", seconds: 30, clearAtZero: false);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "12")) {
                    return new StateWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}
