namespace Maple2.Trigger._02020013_bf {
    public static class _11001_playc {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(key: "PlayC", value: 0);
            }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "PlayC") == 1) {
                    return new StateActorOff(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateActorOff : TriggerState {
            internal StateActorOff(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetActor(triggerId: 11001, visible: true, initialSequence: "ks_quest_musical_B01_off");
            }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{12000058}, arg2: 0)) {
                    return new StateActorOn(context);
                }

                if (context.GetUserValue(key: "PlayC") == 0) {
                    return new StateResetDelay(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateActorOn : TriggerState {
            internal StateActorOn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetActor(triggerId: 11001, visible: true, initialSequence: "ks_quest_musical_B01_red");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 700)) {
                    return new StateResetDelay(context);
                }

                if (context.GetUserValue(key: "PlayC") == 0) {
                    return new StateResetDelay(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateResetDelay : TriggerState {
            internal StateResetDelay(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetActor(triggerId: 11001, visible: true, initialSequence: "ks_quest_musical_B01_off");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 300)) {
                    return new StateActorOff(context);
                }

                if (context.GetUserValue(key: "PlayC") == 0) {
                    return new StateWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}
