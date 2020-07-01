namespace Maple2.Trigger._52010038_qd {
    public static class _gauge {
        public class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "GaugeOpen") == 1) {
                    return new State게이지시작(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State게이지시작 : TriggerState {
            internal State게이지시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new[] {700}, arg2: true);
                context.SetUserValue(triggerId: 999002, key: "GaugeStart", value: 1);
                context.SetUserValue(triggerId: 991001, key: "GaugeStart", value: 1);
                context.SetUserValue(triggerId: 991002, key: "GaugeStart", value: 1);
                context.SetUserValue(triggerId: 991003, key: "GaugeStart", value: 1);
                context.SetUserValue(triggerId: 991004, key: "GaugeStart", value: 1);
                context.ShadowExpeditionOpenBossGauge(title: "$52010038_QD__gauge__2$", maxGaugePoint: 1000);
            }

            public override TriggerState Execute() {
                if (context.GetShadowExpeditionPoints() >= 1000) {
                    return new State성공(context);
                }

                if (context.GetUserValue(key: "CoreIsDead") == 1) {
                    return new State실패(context);
                }

                if (context.GetUserValue(key: "EngineIsDead") == 1) {
                    return new State실패(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ShadowExpeditionCloseBossGauge();
                context.SetUserValue(triggerId: 991001, key: "GaugeClosed", value: 1);
                context.SetUserValue(triggerId: 991002, key: "GaugeClosed", value: 1);
                context.SetUserValue(triggerId: 991003, key: "GaugeClosed", value: 1);
                context.SetUserValue(triggerId: 991004, key: "GaugeClosed", value: 1);
                context.SetUserValue(triggerId: 999002, key: "GaugeClosed", value: 1);
            }
        }

        private class State성공 : TriggerState {
            internal State성공(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SideNpcTalk(npcId: 11003536, illust: "Neirin_normal", duration: 6000, script: "$52010038_QD__gauge__3$", voice: @"ko/Npc/00002107");
                context.SetAchievement(arg1: 199, arg2: "trigger", arg3: "skyfortress_takeoff");
                context.SetEventUI(arg1: 7, arg2: "$52010038_QD__GAUGE__0$", arg3: 2500);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    return new State정리(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State실패 : TriggerState {
            internal State실패(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 5, arg2: "$52010038_QD__GAUGE__1$", arg3: 2500);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.MoveUser(arg1: 02000092, arg2: 20);
                    return new State정리(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State정리 : TriggerState {
            internal State정리(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {-1});
                context.SetUserValue(triggerId: 992001, key: "WaveEnd", value: 1);
                context.SetUserValue(triggerId: 992002, key: "WaveEnd", value: 1);
                context.SetUserValue(triggerId: 993001, key: "WoundEnd", value: 1);
                context.SetUserValue(triggerId: 999004, key: "AllertEnd", value: 1);
                context.MoveUser(arg1: 52010039, arg2: 1);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State종료(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State종료 : TriggerState {
            internal State종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}