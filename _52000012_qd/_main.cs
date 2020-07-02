namespace Maple2.Trigger._52000012_qd {
    public static class _main {
        public class State초기상태 : TriggerState {
            internal State초기상태(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAgent(arg1: new[] {6000, 6001, 6002, 6003, 6004, 6005, 6006, 6007, 6008, 6009, 6010, 6011, 6012, 6013}, arg2: true);
            }

            public override TriggerState Execute() {
                return new StateWait(context);
            }

            public override void OnExit() { }
        }

        private class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(arg1: 2, arg2: false, arg3: false, arg4: false);
                context.SetActor(arg1: 5001, arg2: false, arg3: "DownIdle_B");
                context.SetEffect(arg1: new[] {5002}, arg2: false);
                context.SetActor(arg1: 10001, arg2: true, arg3: "Closed");
                context.SetActor(arg1: 10002, arg2: true, arg3: "Closed");
                context.CreateMonster(arg1: new[] {101, 102, 103, 5000}, arg2: false);
                context.SetAgent(arg1: new[] {7000, 7001, 7002, 7003, 7004, 8000, 8001, 8002, 8003, 8004, 8006, 8007, 8008, 8009, 8010}, arg2: true);
                context.SetMesh(arg1: new[] {10011, 10012}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.QuestUserDetected(arg1: new[] {9000}, arg2: new[] {10002610}, arg3: new byte[] {1})) {
                    return new State레논연출1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State레논연출1 : TriggerState {
            internal State레논연출1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "9", arg2: 2);
                context.CreateMonster(arg1: new[] {1000}, arg2: false);
                context.SetAgent(arg1: new[] {7000, 7001, 7002, 7003, 7004}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "9")) {
                    return new State레논연출2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State레논연출2 : TriggerState {
            internal State레논연출2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "10", arg2: 4);
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.SetConversation(arg1: 2, arg2: 11000064, arg3: "$52000012_QD__MAIN__0$", arg4: 3);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "10")) {
                    return new State전투1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State전투1 : TriggerState {
            internal State전투1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {101, 102, 103})) {
                    return new State벨라StartCinematic(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State벨라StartCinematic : TriggerState {
            internal State벨라StartCinematic(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.SetTimer(arg1: "8", arg2: 3);
                context.CameraSelectPath(arg1: new[] {901, 902}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "8")) {
                    return new State벨라연출중(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State벨라연출중 : TriggerState {
            internal State벨라연출중(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "11", arg2: 7);
                context.SetConversation(arg1: 2, arg2: 11000844, arg3: "$52000012_QD__MAIN__1$", arg4: 2);
                context.SetConversation(arg1: 2, arg2: 11000064, arg3: "$52000012_QD__MAIN__2$", arg4: 2);
                context.SetConversation(arg1: 2, arg2: 11000064, arg3: "$52000012_QD__MAIN__3$", arg4: 2);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "11")) {
                    return new State벨라StopCinematic(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State벨라StopCinematic : TriggerState {
            internal State벨라StopCinematic(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "14", arg2: 1);
                context.CameraSelectPath(arg1: new[] {906}, arg2: true);
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "14")) {
                    return new State문열림1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State문열림1 : TriggerState {
            internal State문열림1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "19", arg2: 1);
                context.SetAgent(arg1: new[] {8000, 8001, 8002, 8003, 8004}, arg2: false);
                context.CreateMonster(arg1: new[] {201, 202, 203}, arg2: false);
                context.SetActor(arg1: 10001, arg2: true, arg3: "Opened");
                context.SetMesh(arg1: new[] {10011}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "19")) {
                    return new State전투2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State전투2 : TriggerState {
            internal State전투2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 1000, arg2: "MS2PatrolData_1001");
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {201, 202, 203})) {
                    return new State문열림2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State문열림2 : TriggerState {
            internal State문열림2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "12", arg2: 2);
                context.SetAgent(arg1: new[] {8006, 8007, 8008, 8009, 8010}, arg2: false);
                context.SetActor(arg1: 10002, arg2: true, arg3: "Opened");
                context.SetMesh(arg1: new[] {10012}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "12")) {
                    return new State악령StartCinematic(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State악령StartCinematic : TriggerState {
            internal State악령StartCinematic(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.SetTimer(arg1: "13", arg2: 6);
                context.CameraSelectPath(arg1: new[] {904, 905}, arg2: false);
                context.CreateMonster(arg1: new[] {301}, arg2: false);
                context.MoveNpc(arg1: 301, arg2: "MS2PatrolData_301");
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "13")) {
                    return new State화면끄기(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State화면끄기 : TriggerState {
            internal State화면끄기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "22", arg2: 1);
                context.SetProductionUI(arg1: 4);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "22")) {
                    return new State영혼연출(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State영혼연출 : TriggerState {
            internal State영혼연출(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "23", arg2: 2);
                context.DestroyMonster(arg1: new[] {301, 5000, 301, 5000});
                context.SetActor(arg1: 5001, arg2: true, arg3: "DownIdle_B");
                context.SetEffect(arg1: new[] {5002}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "23")) {
                    return new State화면켜기(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State화면켜기 : TriggerState {
            internal State화면켜기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 4);
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.SetTimer(arg1: "14", arg2: 3);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "14")) {
                    return new State영혼연출중(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State영혼연출중 : TriggerState {
            internal State영혼연출중(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "15", arg2: 4);
                context.SetConversation(arg1: 2, arg2: 11000064, arg3: "$52000012_QD__MAIN__4$", arg4: 3);
                context.CameraSelectPath(arg1: new[] {905, 903}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "15")) {
                    return new State영혼StopCinematic(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State영혼StopCinematic : TriggerState {
            internal State영혼StopCinematic(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 1000, arg2: "MS2PatrolData_1002");
                context.CameraSelect(arg1: 903, arg2: false);
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
            }

            public override TriggerState Execute() {
                return new State전투3(context);
            }

            public override void OnExit() { }
        }

        private class State전투3 : TriggerState {
            internal State전투3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetActor(arg1: 5001, arg2: false, arg3: "DownIdle_B");
                context.SetEffect(arg1: new[] {5002}, arg2: false);
                context.CreateMonster(arg1: new[] {302}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {302})) {
                    return new State레논교체(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State레논교체 : TriggerState {
            internal State레논교체(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {1000});
                context.CreateMonster(arg1: new[] {2000}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.QuestUserDetected(arg1: new[] {9001}, arg2: new[] {10002611}, arg3: new byte[] {2})) {
                    return new StatePortalCreation(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePortalCreation : TriggerState {
            internal StatePortalCreation(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(arg1: 2, arg2: true, arg3: true, arg4: true);
            }

            public override TriggerState Execute() {
                if (!context.UserDetected(arg1: new[] {9001})) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnd : TriggerState {
            internal StateEnd(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {1000, 2000, 101, 102, 103, 201, 202, 203, 301, 302});
            }

            public override TriggerState Execute() {
                return new StateWait(context);
            }

            public override void OnExit() { }
        }
    }
}