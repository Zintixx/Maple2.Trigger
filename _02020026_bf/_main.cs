namespace Maple2.Trigger._02020026_bf {
    public static class _main {
        public class StateBattleStart : TriggerState {
            internal StateBattleStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {201});
            }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }

        private class StateStart : TriggerState {
            internal StateStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 24110001, illustId: "Neirin_normal", msg: "$02020026_BF__main__0$", duration: 5000, align: "left");
                context.AddCinematicTalk(npcId: 24110001, illustId: "Neirin_normal", msg: "$02020026_BF__main__1$", duration: 5000, align: "left");
                context.AddCinematicTalk(npcId: 24110001, illustId: "Neirin_normal", msg: "$02020026_BF__main__2$", duration: 5000, align: "left");
            }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}