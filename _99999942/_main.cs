namespace Maple2.Trigger._99999942 {
    public static class _main {
        public class StateNone : TriggerState {
            internal StateNone(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateFieldGame(type: "WaterGunBattle", reset: true);
                context.FieldGameConstant(key: "WaitUserTick", value: "15000");
                context.FieldGameConstant(key: "WaitPlayTick", value: "5000");
                context.FieldGameConstant(key: "ResizeWaitTick", value: "15000,15000,15000,15000");
                context.FieldGameConstant(key: "ResizeWarningTick", value: "5000,5000,5000,5000");
                context.FieldGameConstant(key: "SkillSetId", value: "99930047");
                context.FieldGameConstant(key: "MinPlayer", value: "2");
                context.SetPortal(arg1: 1, arg2: false, arg3: false, arg4: false);
                context.SetPortal(arg1: 2, arg2: false, arg3: false, arg4: false);
            }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "WaitUser") == 1) {
                    return new State유저대기중(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State유저대기중 : TriggerState {
            internal State유저대기중(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 15, arg3: false, arg4: true);
            }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "MoveUser") == 1) {
                    return new State유저이동(context);
                }

                if (context.GetUserValue(key: "End") == 1) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State유저이동 : TriggerState {
            internal State유저이동(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 5, arg3: false, arg4: true);
                context.MoveUser(arg1: 99999942, arg2: 2);
            }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "Play") == 1) {
                    return new State게임시작(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State게임시작 : TriggerState {
            internal State게임시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "PlayRound1") == 1) {
                    return new State라운드1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State라운드1 : TriggerState {
            internal State라운드1(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "PlayRound2") == 1) {
                    return new State라운드2(context);
                }

                if (context.GetUserValue(key: "End") == 1) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State라운드2 : TriggerState {
            internal State라운드2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28}, arg2: false, arg3: 2, arg4: 2);
            }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "PlayRound3") == 1) {
                    return new State라운드3(context);
                }

                if (context.GetUserValue(key: "End") == 1) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State라운드3 : TriggerState {
            internal State라운드3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {29, 30, 31, 32, 33, 34, 35, 36, 37, 38, 39, 40, 41, 42, 43, 44, 45, 46, 47, 48}, arg2: false, arg3: 2, arg4: 2);
            }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "PlayRound4") == 1) {
                    return new State라운드4(context);
                }

                if (context.GetUserValue(key: "End") == 1) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State라운드4 : TriggerState {
            internal State라운드4(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {49, 50, 51, 52, 53, 54, 55, 56, 57, 58, 59, 60}, arg2: false, arg3: 2, arg4: 2);
            }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "End") == 1) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnd : TriggerState {
            internal StateEnd(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36, 37, 38, 39, 40, 41, 42, 43, 44, 45, 46, 47, 48, 49, 50, 51, 52, 53, 54, 55, 56, 57, 58, 59, 60, 61, 62, 63, 64}, arg2: true, arg3: 0, arg4: 0);
                context.MoveUser(arg1: 99999942, arg2: 1);
            }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}