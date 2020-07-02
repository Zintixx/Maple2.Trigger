namespace Maple2.Trigger._52000119_qd {
    public static class _main3 {
        public class StateIdle : TriggerState {
            internal StateIdle(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.QuestUserDetected(arg1: new[] {2001}, arg2: new[] {60100070}, arg3: new byte[] {2})) {
                    return new StateMonsterdel(context);
                }

                if (context.QuestUserDetected(arg1: new[] {2002}, arg2: new[] {60100075}, arg3: new byte[] {1})) {
                    return new StateFadeout(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateFadeout : TriggerState {
            internal StateFadeout(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateReady(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateReady : TriggerState {
            internal StateReady(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(arg1: 1);
                context.SetCinematicUI(arg1: 3);
                context.CameraSelectPath(arg1: new[] {4020}, arg2: false);
                context.DestroyMonster(arg1: new[] {901, 902, 903, 904, 905, 906, 907, 908, 909, 910, 911, 912, 913, 914, 915, 916, 917, 918, 919, 920, 921, 922, 923, 924, 925, 926, 927, 928, 929});
                context.CreateMonster(arg1: new[] {106, 201, 202, 301, 302, 303, 304, 305, 306}, arg2: true);
                context.MoveUser(arg1: 52000119, arg2: 6001);
                context.SetSceneSkip(arg1: "fadeout_01", arg2: "nextState");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateFadein(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateFadein : TriggerState {
            internal StateFadein(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.SetPcEmotionLoop(arg1: "Attack_Idle_A", arg2: 6000f);
                context.FaceEmotion(spawnPointId: 0, emotionName: "Object_React_A");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateScene_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateScene_01 : TriggerState {
            internal StateScene_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {4021}, arg2: false);
                context.SetNpcEmotionSequence(arg1: 105, arg2: "Talk_A");
                context.AddCinematicTalk(npcId: 11003169, illustId: "Jordy_normal", msg: "$52000119_QD__MAIN3__0$", duration: 3000, align: "Right");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateScene_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateScene_02 : TriggerState {
            internal StateScene_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {4009}, arg2: false);
                context.SetNpcEmotionSequence(arg1: 104, arg2: "Bore_A");
                context.AddCinematicTalk(npcId: 11003187, msg: "$52000119_QD__MAIN3__1$", duration: 3000);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateScene_03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateScene_03 : TriggerState {
            internal StateScene_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {4013, 4014, 4015}, arg2: false);
                context.SetNpcEmotionSequence(arg1: 104, arg2: "Talk_A");
                context.AddCinematicTalk(npcId: 11003187, msg: "$52000119_QD__MAIN3__2$", duration: 4000);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new StateScene_04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateScene_04 : TriggerState {
            internal StateScene_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionSequence(arg1: 104, arg2: "Bore_A");
                context.AddCinematicTalk(npcId: 11003187, msg: "$52000119_QD__MAIN3__3$", duration: 3000);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateCheer_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCheer_01 : TriggerState {
            internal StateCheer_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSound(arg1: 7001, arg2: true);
                context.CameraSelectPath(arg1: new[] {4023, 4024}, arg2: false);
                context.AddCinematicTalk(npcId: 11003354, msg: "$52000119_QD__MAIN3__4$", duration: 2000);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateCheer_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCheer_02 : TriggerState {
            internal StateCheer_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionSequence(arg1: 306, arg2: "Bore_A");
                context.AddCinematicTalk(npcId: 11003354, msg: "$52000119_QD__MAIN3__5$", duration: 2000);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateCheer_03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCheer_03 : TriggerState {
            internal StateCheer_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {4024, 4025}, arg2: false);
                context.AddCinematicTalk(npcId: 11003354, msg: "$52000119_QD__MAIN3__6$", duration: 2000);
                context.AddCinematicTalk(npcId: 11003354, msg: "$52000119_QD__MAIN3__7$", duration: 1000);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateCheer_04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCheer_04 : TriggerState {
            internal StateCheer_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003354, msg: "$52000119_QD__MAIN3__8$", duration: 2000);
                context.AddBalloonTalk(spawnPointId: 303, msg: "$52000119_QD__MAIN3__9$", duration: 2000, delayTick: 1);
                context.AddCinematicTalk(npcId: 11003354, msg: "$52000119_QD__MAIN3__10$", duration: 1000);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateScene_05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateScene_05 : TriggerState {
            internal StateScene_05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {4004}, arg2: false);
                context.SetNpcEmotionSequence(arg1: 106, arg2: "Stun_A");
                context.AddCinematicTalk(npcId: 11003171, msg: "$52000119_QD__MAIN3__11$", duration: 2000);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateScene_06(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateScene_06 : TriggerState {
            internal StateScene_06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {4019}, arg2: false);
                context.SetEffect(arg1: new[] {5002, 5003, 5004, 5005}, arg2: true);
                context.SetNpcEmotionSequence(arg1: 106, arg2: "Bore_A");
                context.AddCinematicTalk(npcId: 11003171, msg: "$52000119_QD__MAIN3__12$", duration: 4000);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new StateScene_07(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateScene_07 : TriggerState {
            internal StateScene_07(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {4019, 4022}, arg2: false);
                context.MoveNpc(arg1: 106, arg2: "MS2PatrolData_3001");
                context.SetConversation(arg1: 2, arg2: 11003171, arg3: "$52000119_QD__MAIN3__13$", arg4: 3, arg5: 0);
                context.SetSceneSkip();
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new StateFadeout_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateFadeout_01 : TriggerState {
            internal StateFadeout_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSound(arg1: 7001, arg2: false);
                context.SetSound(arg1: 7002, arg2: true);
                context.DestroyMonster(arg1: new[] {106});
                context.CreateMonster(arg1: new[] {999}, arg2: true);
                context.SetCinematicUI(arg1: 1);
                context.SetCinematicUI(arg1: 3);
                context.SetCinematicUI(arg1: 4);
                context.SetPcEmotionLoop(arg1: "Attack_Idle_A", arg2: 100f);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateFadein_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateFadein_01 : TriggerState {
            internal StateFadein_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraReset(interpolationTime: 0.5f);
                context.SetCinematicUI(arg1: 0);
                context.SetCinematicUI(arg1: 2);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new StateMsg(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMsg : TriggerState {
            internal StateMsg(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(arg2: "System_ShowGuideSummary_01");
                context.SetEventUI(arg1: 1, arg2: "$52000119_QD__MAIN3__14$", arg3: 3000, arg4: "0");
                context.AddBalloonTalk(spawnPointId: 999, msg: "$52000119_QD__MAIN3__15$", duration: 2000, delayTick: 0);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {999})) {
                    return new StateFadeout_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateFadeout_02 : TriggerState {
            internal StateFadeout_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSound(arg1: 7002, arg2: false);
                context.AddBalloonTalk(spawnPointId: 999, msg: "$52000119_QD__MAIN3__19$", duration: 2000, delayTick: 0);
                context.AddBalloonTalk(spawnPointId: 306, msg: "$52000119_QD__MAIN3__20$", duration: 2000, delayTick: 1);
                context.DestroyMonster(arg1: new[] {201, 202, 401, 402, 403, 404, 405, 406, 407});
                context.SetAchievement(arg2: "trigger", arg3: "jordysave3");
                context.SetCinematicUI(arg1: 1);
                context.SetCinematicUI(arg1: 3);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnd : TriggerState {
            internal StateEnd(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraReset(interpolationTime: 0.5f);
                context.SetCinematicUI(arg1: 0);
                context.SetCinematicUI(arg1: 2);
            }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }

        private class StateMonsterdel : TriggerState {
            internal StateMonsterdel(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {901, 902, 903, 904, 905, 906, 907, 908, 909, 910, 911, 912, 913, 914, 915, 916, 917, 918, 919, 920, 921, 922, 923, 924, 925, 926, 927, 928, 929});
                context.CreateMonster(arg1: new[] {401, 402, 403, 404, 405, 406, 407}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.QuestUserDetected(arg1: new[] {2002}, arg2: new[] {60100075}, arg3: new byte[] {1})) {
                    return new StateReady(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}