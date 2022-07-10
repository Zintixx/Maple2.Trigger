namespace Maple2.Trigger._02000315_bf {
    public static class _wounded_102 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(key: "BridgeOpen", value: 0);
                context.SetInteractObject(interactIds: new []{10001037}, state: 1);
            }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{10001037}, arg2: 0)) {
                    return new StateWakeUp(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateWakeUp : TriggerState {
            internal StateWakeUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(interactIds: new []{10001037}, state: 2);
                context.CreateMonster(spawnIds: new []{102}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "BridgeOpen") == 1) {
                    return new StatePatrol01(context);
                }

                if (context.GetUserValue(key: "BridgeOpen") == 2) {
                    return new StatePatrol02(context);
                }

                if (context.GetUserValue(key: "BridgeOpen") == 3) {
                    return new StatePatrol03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePatrol01 : TriggerState {
            internal StatePatrol01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(spawnId: 102, patrolName: "MS2PatrolData_1021");
            }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "BridgeOpen") == 2) {
                    return new StatePatrol02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePatrol02 : TriggerState {
            internal StatePatrol02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(spawnId: 102, patrolName: "MS2PatrolData_1022");
            }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "BridgeOpen") == 3) {
                    return new StatePatrol03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePatrol03 : TriggerState {
            internal StatePatrol03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(spawnId: 102, patrolName: "MS2PatrolData_1023");
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
