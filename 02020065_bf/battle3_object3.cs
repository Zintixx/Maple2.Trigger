namespace Maple2.Trigger._02020065_bf {
    public static class _battle3_object3 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(spawnIds: new []{813}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "Battle3_TurretSpawn_3") == 1) {
                    return new StateTurretEnabled(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateTurretEnabled : TriggerState {
            internal StateTurretEnabled(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{813}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "Battle3_TurretSpawn_3") == 0) {
                    return new StateWait(context);
                }

                if (context.MonsterDead(spawnIds: new []{813})) {
                    return new StateTurretDisabled(context);
                }

                if (context.MonsterDead(spawnIds: new []{801})) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateTurretDisabled : TriggerState {
            internal StateTurretDisabled(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "Battle3_TurretSpawn_3") == 0) {
                    return new StateWait(context);
                }

                if (context.MonsterDead(spawnIds: new []{801})) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnd : TriggerState {
            internal StateEnd(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(spawnIds: new []{813}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "Battle3_TurretSpawn_3") == 1) {
                    return new StateWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}
