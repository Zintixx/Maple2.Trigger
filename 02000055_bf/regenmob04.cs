namespace Maple2.Trigger._02000055_bf {
    public static class _regenmob04 {
        public class StateWaitStart : TriggerState {
            internal StateWaitStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.NpcDetected(boxId: 12, spawnIds: new []{91})) {
                    return new State소환몹Spawn(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State소환몹Spawn : TriggerState {
            internal State소환몹Spawn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{101, 102});
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{101, 102})) {
                    return new StateWaitTime(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateWaitTime : TriggerState {
            internal StateWaitTime(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "1", seconds: 20);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "1")) {
                    return new StateWaitStart(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(timerId: "1");
            }
        }
    }
}
