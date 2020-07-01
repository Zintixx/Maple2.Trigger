namespace Maple2.Trigger._02020101_bf {
    public static class _deathflower {
        public class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "flower") == 1) {
                    return new State랜덤대상선정(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State랜덤대상선정 : TriggerState {
            internal State랜덤대상선정(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RandomAdditionalEffect(target: "pc", triggerBoxId: 1003, spawnPointId: 0, targetCount: 1, tick: 3, waitTick: 2, targetEffect: @"Additional/Etc/Eff_Target_Select_Keep.xml", additionalEffectId: 62100021);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {101})) {
                    context.SetUserValue(triggerId: 900007, key: "flower", value: 0);
                    return new State종료(context);
                }

                if (context.WaitTick(waitTick: 2000)) {
                    context.SetUserValue(triggerId: 900007, key: "flower", value: 0);
                    return new State변수초기화(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State변수초기화 : TriggerState {
            internal State변수초기화(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "flower") == 0) {
                    return new State대기(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State종료 : TriggerState {
            internal State종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveBuff(arg1: 1004, arg2: 62100021, arg3: true);
                context.RemoveBuff(arg1: 1004, arg2: 62100022, arg3: true);
                context.RemoveBuff(arg1: 1004, arg2: 62100023, arg3: true);
            }

            public override TriggerState Execute() {
                return new State대기(context);
            }

            public override void OnExit() { }
        }
    }
}