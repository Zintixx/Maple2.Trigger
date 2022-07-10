namespace Maple2.Trigger._02000498_bf {
    public static class _timeattack_r8_08 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.NpcDetected(boxId: 140, spawnIds: new []{108099})) {
                    return new State몹Spawn(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State몹Spawn : TriggerState {
            internal State몹Spawn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DarkStreamSpawnMonster(spawnIds: new []{108008}, score: 8000);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{108099})) {
                    context.DestroyMonster(spawnIds: new []{108008});
                    return new StateEnd(context);
                }

                if (context.MonsterDead(spawnIds: new []{108008})) {
                    return new State몹Spawn(context);
                }

                return null;
            }

            public override void OnExit() { }
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
