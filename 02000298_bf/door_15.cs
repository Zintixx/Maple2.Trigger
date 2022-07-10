namespace Maple2.Trigger._02000298_bf {
    public static class _door_15 {
        public class StateStart : TriggerState {
            internal StateStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetActor(triggerId: 215, visible: true, initialSequence: "Closed");
                context.SetMesh(triggerIds: new []{3151, 3152}, visible: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetAgent(triggerIds: new []{9151, 9152, 9153}, visible: true);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{115})) {
                    return new State문열림(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State문열림 : TriggerState {
            internal State문열림(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetActor(triggerId: 215, visible: true, initialSequence: "Opened");
                context.SetMesh(triggerIds: new []{3151}, visible: false, arg3: 0, arg4: 0, arg5: 5f);
                context.SetMesh(triggerIds: new []{3152}, visible: false, arg3: 0, arg4: 0, arg5: 5f);
                context.SetAgent(triggerIds: new []{9151, 9152, 9153}, visible: false);
                context.CreateMonster(spawnIds: new []{1016}, arg2: true);
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
