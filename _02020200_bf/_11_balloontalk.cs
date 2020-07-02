namespace Maple2.Trigger._02020200_bf {
    public static class _11_balloontalk {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {905})) {
                    return new State대사1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State대사1 : TriggerState {
            internal State대사1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SideNpcTalk(type: "talk", npcId: 11001813, illust: "Turka_normal", duration: 5000, script: "$02020200_BF__11_BALLOONTALK__0$");
                context.AddBalloonTalk(spawnPointId: 0, msg: "$02020200_BF__11_BALLOONTALK__1$", duration: 5000, delayTick: 1000);
            }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {921}) && !context.MonsterDead(arg1: new[] {205})) {
                    return new State대사2(context);
                }

                if (context.UserDetected(arg1: new[] {922}) && !context.MonsterDead(arg1: new[] {205})) {
                    return new State대사2(context);
                }

                if (context.UserDetected(arg1: new[] {923}) && !context.MonsterDead(arg1: new[] {205})) {
                    return new State대사2(context);
                }

                if (context.MonsterDead(arg1: new[] {205})) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State대사2 : TriggerState {
            internal State대사2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBalloonTalk(spawnPointId: 0, msg: "$02020200_BF__11_BALLOONTALK__2$", duration: 5000, delayTick: 0);
            }

            public override TriggerState Execute() {
                if (context.CheckNpcAdditionalEffect(spawnPointId: 205, additionalEffectId: 42030261, level: 1)) {
                    return new State대사3(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State대사3 : TriggerState {
            internal State대사3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SideNpcTalk(type: "talk", npcId: 11001813, illust: "Turka_normal", duration: 5000, script: "$02020200_BF__11_BALLOONTALK__3$");
                context.AddBalloonTalk(spawnPointId: 0, msg: "$02020200_BF__11_BALLOONTALK__4$", duration: 5000, delayTick: 0);
            }

            public override TriggerState Execute() {
                return new StateEnd(context);
            }

            public override void OnExit() { }
        }

        private class StateEnd : TriggerState {
            internal StateEnd(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}