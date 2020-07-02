namespace Maple2.Trigger._02000498_bf {
    public static class _main_4 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {3501, 3502, 3503, 3504, 3505, 3506, 3507, 3508, 3509, 3510, 3511, 3512, 3513, 3514, 3515, 3516, 3517, 3518, 3519, 3520, 3521, 3522, 3523, 3524, 3525, 3526, 3527, 3528}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetSkill(arg1: new[] {705}, arg2: false);
                context.SetEffect(arg1: new[] {6401, 640, 630}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {104})) {
                    return new StateBeginWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBeginWait : TriggerState {
            internal StateBeginWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 0, arg2: "16,20,16");
                context.DarkStreamStartRound(round: 16, uiDuration: 3000, damagePenalty: 50);
                context.SetTimer(arg1: "3", arg2: 3);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "3")) {
                    return new State16라운드(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State16라운드 : TriggerState {
            internal State16라운드(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, arg2: "$02000350_BF__MAIN_4__0$", arg3: 4000, arg4: "0");
                context.DarkStreamSpawnMonster(spawnId: new[] {116001}, score: 73000);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {116001})) {
                    context.DarkStreamClearRound(round: 16);
                    context.SetAchievement(arg1: 104, arg2: "trigger", arg3: "16roundpass");
                    return new State17라운드대기(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State17라운드대기 : TriggerState {
            internal State17라운드대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 0, arg2: "17,20,16");
                context.DarkStreamStartRound(round: 17, uiDuration: 3000, damagePenalty: 50);
                context.SetTimer(arg1: "3", arg2: 3);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "3")) {
                    return new State17라운드(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State17라운드 : TriggerState {
            internal State17라운드(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DarkStreamSpawnMonster(spawnId: new[] {117001}, score: 56250);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {117001})) {
                    context.DarkStreamClearRound(round: 17);
                    context.SetAchievement(arg1: 104, arg2: "trigger", arg3: "17roundpass");
                    return new State18라운드대기(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State18라운드대기 : TriggerState {
            internal State18라운드대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 0, arg2: "18,20,16");
                context.SetTimer(arg1: "3", arg2: 3);
                context.DarkStreamStartRound(round: 18, uiDuration: 3000, damagePenalty: 50);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "3")) {
                    return new State18라운드(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State18라운드 : TriggerState {
            internal State18라운드(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DarkStreamSpawnMonster(spawnId: new[] {118001}, score: 90000);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {118001})) {
                    context.DarkStreamClearRound(round: 18);
                    context.SetAchievement(arg1: 104, arg2: "trigger", arg3: "18roundpass");
                    return new State19라운드대기(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State19라운드대기 : TriggerState {
            internal State19라운드대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 0, arg2: "19,20,16");
                context.SetTimer(arg1: "3", arg2: 3);
                context.DarkStreamStartRound(round: 19, uiDuration: 3000, damagePenalty: 50);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "3")) {
                    return new State19라운드(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State19라운드 : TriggerState {
            internal State19라운드(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DarkStreamSpawnMonster(spawnId: new[] {119001, 119002}, score: 80000);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {119001, 119002})) {
                    context.DarkStreamClearRound(round: 19);
                    context.SetAchievement(arg1: 104, arg2: "trigger", arg3: "19roundpass");
                    return new State20라운드대기(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State20라운드대기 : TriggerState {
            internal State20라운드대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 0, arg2: "20,20,16");
                context.SetEffect(arg1: new[] {6401}, arg2: true);
                context.SetTimer(arg1: "3", arg2: 3);
                context.DarkStreamStartRound(round: 20, uiDuration: 3000, damagePenalty: 50);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "3")) {
                    return new State20라운드(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State20라운드 : TriggerState {
            internal State20라운드(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DarkStreamSpawnMonster(spawnId: new[] {120001}, score: 600000);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {120001})) {
                    context.DarkStreamClearRound(round: 20);
                    context.SetAchievement(arg1: 104, arg2: "trigger", arg3: "20roundpass");
                    return new State바닥부심(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State바닥부심 : TriggerState {
            internal State바닥부심(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "3", arg2: 3);
                context.SetEffect(arg1: new[] {600}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "3")) {
                    context.SetEffect(arg1: new[] {640}, arg2: true);
                    context.SetSkill(arg1: new[] {705}, arg2: true);
                    context.SetMesh(arg1: new[] {3501, 3502, 3503, 3504, 3505, 3506, 3507, 3508, 3509, 3510, 3511, 3512, 3513, 3514, 3515, 3516, 3517, 3518, 3519, 3520, 3521, 3522, 3523, 3524, 3525, 3526, 3527, 3528}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                    return new StateEnd(context);
                }

                return null;
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