namespace Maple2.Trigger._02020027_bf {
    public static class _battle_1 {
        public class StateBattleStart : TriggerState {
            internal StateBattleStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                return new StateBattleStart_2(context);
            }

            public override void OnExit() { }
        }

        private class StateBattleStart_2 : TriggerState {
            internal StateBattleStart_2(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "summon_1_1") == 1) {
                    return new StateMonster소환(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMonster소환 : TriggerState {
            internal StateMonster소환(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{301, 302, 303, 304, 305, 306});
                context.SetEventUI(arg1: 1, script: "$02020027_BF__battle_1__0$", duration: 4000);
                context.SetConversation(type: 1, spawnId: 301, script: "$02020027_BF__battle_1__1$", arg4: 3, arg5: 0);
                context.SetConversation(type: 1, spawnId: 303, script: "$02020027_BF__battle_1__2$", arg4: 3, arg5: 0);
                context.SetConversation(type: 1, spawnId: 305, script: "$02020027_BF__battle_1__3$", arg4: 3, arg5: 0);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{301, 302, 303, 304, 305, 306})) {
                    return new StateBuff(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBuff : TriggerState {
            internal StateBuff(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBuff(boxIds: new []{201}, skillId: 62000002, level: 1, arg4: true);
                context.AddBuff(boxIds: new []{201}, skillId: 51200002, level: 1, arg4: true);
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
