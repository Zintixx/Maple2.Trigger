namespace Maple2.Trigger._02000431_bf {
    public static class _buff_1 {
        public class StateBattleStart : TriggerState {
            internal StateBattleStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.MonsterInCombat(arg1: new[] {2199})) {
                    return new StateBuff(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBuff : TriggerState {
            internal StateBuff(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBuff(arg1: new[] {2199}, arg2: 40501006, arg3: 1, arg4: true, arg5: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) { }

                return null;
            }

            public override void OnExit() { }
        }
    }
}