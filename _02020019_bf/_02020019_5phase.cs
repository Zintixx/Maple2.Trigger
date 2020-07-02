namespace Maple2.Trigger._02020019_bf {
    public static class _02020019_5phase {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "5Phase") == 1) {
                    return new State크림슨발록스폰체크(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State크림슨발록스폰체크 : TriggerState {
            internal State크림슨발록스폰체크(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBuff(feature: "FameChallengeBuff_01", arg1: new[] {241}, arg2: 49218001, arg3: 1, arg4: true);
                context.AddBuff(feature: "FameChallengeBuff_01", arg1: new[] {242}, arg2: 49218001, arg3: 1, arg4: true);
                context.AddBuff(feature: "FameChallengeBuff_01", arg1: new[] {243}, arg2: 49218001, arg3: 1, arg4: true);
                context.AddBuff(feature: "FameChallengeBuff_01", arg1: new[] {244}, arg2: 49218001, arg3: 1, arg4: true);
                context.AddBuff(feature: "FameChallengeBuff_01", arg1: new[] {245}, arg2: 49218001, arg3: 1, arg4: true);
                context.AddBuff(feature: "FameChallengeBuff_01", arg1: new[] {246}, arg2: 49218001, arg3: 1, arg4: true);
                context.AddBuff(feature: "FameChallengeBuff_01", arg1: new[] {247}, arg2: 49218001, arg3: 1, arg4: true);
                context.AddBuff(feature: "FameChallengeBuff_02", arg1: new[] {241}, arg2: 49218002, arg3: 1, arg4: true);
                context.AddBuff(feature: "FameChallengeBuff_02", arg1: new[] {242}, arg2: 49218002, arg3: 1, arg4: true);
                context.AddBuff(feature: "FameChallengeBuff_02", arg1: new[] {243}, arg2: 49218002, arg3: 1, arg4: true);
                context.AddBuff(feature: "FameChallengeBuff_02", arg1: new[] {244}, arg2: 49218002, arg3: 1, arg4: true);
                context.AddBuff(feature: "FameChallengeBuff_02", arg1: new[] {245}, arg2: 49218002, arg3: 1, arg4: true);
                context.AddBuff(feature: "FameChallengeBuff_02", arg1: new[] {246}, arg2: 49218002, arg3: 1, arg4: true);
                context.AddBuff(feature: "FameChallengeBuff_02", arg1: new[] {247}, arg2: 49218002, arg3: 1, arg4: true);
            }

            public override TriggerState Execute() {
                if (context.MonsterInCombat(arg1: new[] {242})) {
                    return new State크림슨스피어죽음(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State크림슨스피어죽음 : TriggerState {
            internal State크림슨스피어죽음(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {241})) {
                    return new State발록에게신호쏴주기(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State발록에게신호쏴주기 : TriggerState {
            internal State발록에게신호쏴주기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAiExtraData(key: "SpearDead", value: 1);
            }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}