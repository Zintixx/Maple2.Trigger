using Maple2.Trigger._dungeon_common;

namespace Maple2.Trigger._02000298_bf {
    public static class _main {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {11000004}, arg2: 2);
                context.SetEffect(arg1: new[] {601}, arg2: false);
                context.SetMesh(arg1: new[] {3001, 3002, 3003, 3004, 3005}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new[] {3221, 3222, 3223}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.CreateMonster(arg1: new[] {2099}, arg2: false);
                context.SetNpcEmotionLoop(arg1: 2099, arg2: "Idle_A", arg3: 9999999f);
            }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {199})) {
                    return new _checkusercount.StateCheckUserCount(context, new StateDungeonStart(context));
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDungeonStart : TriggerState {
            internal StateDungeonStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(arg1: 1);
                context.SetCinematicUI(arg1: 3);
                context.SetSkip(arg1: "암호발급");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateCamera이동(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCamera이동 : TriggerState {
            internal StateCamera이동(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkip();
                context.CameraSelect(arg1: 300, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new StateCamera이동후UI노출(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCamera이동후UI노출 : TriggerState {
            internal StateCamera이동후UI노출(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(arg1: 0);
                context.SetCinematicUI(arg1: 2);
                context.AddBuff(arg1: new[] {199}, arg2: 70000107, arg3: 1, arg4: false, arg5: false);
                context.ShowGuideSummary(entityId: 20002991, textId: 20002991, duration: 5000);
                context.PlaySystemSoundInBox(arg2: "System_ShowGuideSummary_01");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateNPC이동(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateNPC이동 : TriggerState {
            internal StateNPC이동(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 2099, arg2: "MS2PatrolData_2099_A");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new StateDungeon안내01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDungeon안내01 : TriggerState {
            internal StateDungeon안내01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {3221, 3222, 3223}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetInteractObject(arg1: new[] {10000372}, arg2: 1);
                context.ShowGuideSummary(entityId: 20002980, textId: 20002980, duration: 5000);
                context.PlaySystemSoundInBox(arg2: "System_ShowGuideSummary_01");
                context.CameraSelect(arg1: 301, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new StateDungeon안내Camera이동(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDungeon안내Camera이동 : TriggerState {
            internal StateDungeon안내Camera이동(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 302, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateDungeon안내02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDungeon안내02 : TriggerState {
            internal StateDungeon안내02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityId: 20002981, textId: 20002981, duration: 4000);
                context.PlaySystemSoundInBox(arg2: "System_ShowGuideSummary_01");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.SetInteractObject(arg1: new[] {10000372}, arg2: 0);
                    return new State암호발급(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State암호발급 : TriggerState {
            internal State암호발급(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveBuff(arg1: 199, arg2: 70000107);
                context.DestroyMonster(arg1: new[] {2099});
                context.CameraSelect(arg1: 302, arg2: false);
                context.SetCinematicUI(arg1: 0);
                context.SetCinematicUI(arg1: 2);
                context.SetEffect(arg1: new[] {601}, arg2: true);
                context.SetMesh(arg1: new[] {3001, 3002, 3003, 3004, 3005}, arg2: false, arg3: 0, arg4: 0, arg5: 5f);
                context.SetMesh(arg1: new[] {3221, 3222, 3223}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override TriggerState Execute() {
                if (context.RandomCondition(arg1: 5f)) {
                    return new State1279소환(context);
                }

                if (context.RandomCondition(arg1: 5f)) {
                    return new State1238소환(context);
                }

                if (context.RandomCondition(arg1: 5f)) {
                    return new State1358소환(context);
                }

                if (context.RandomCondition(arg1: 5f)) {
                    return new State1489소환(context);
                }

                if (context.RandomCondition(arg1: 5f)) {
                    return new State1567소환(context);
                }

                if (context.RandomCondition(arg1: 5f)) {
                    return new State1679소환(context);
                }

                if (context.RandomCondition(arg1: 5f)) {
                    return new State2389소환(context);
                }

                if (context.RandomCondition(arg1: 5f)) {
                    return new State2347소환(context);
                }

                if (context.RandomCondition(arg1: 5f)) {
                    return new State2478소환(context);
                }

                if (context.RandomCondition(arg1: 5f)) {
                    return new State2456소환(context);
                }

                if (context.RandomCondition(arg1: 5f)) {
                    return new State2569소환(context);
                }

                if (context.RandomCondition(arg1: 5f)) {
                    return new State2678소환(context);
                }

                if (context.RandomCondition(arg1: 5f)) {
                    return new State3458소환(context);
                }

                if (context.RandomCondition(arg1: 5f)) {
                    return new State3589소환(context);
                }

                if (context.RandomCondition(arg1: 5f)) {
                    return new State3679소환(context);
                }

                if (context.RandomCondition(arg1: 5f)) {
                    return new State3789소환(context);
                }

                if (context.RandomCondition(arg1: 5f)) {
                    return new State4567소환(context);
                }

                if (context.RandomCondition(arg1: 5f)) {
                    return new State4578소환(context);
                }

                if (context.RandomCondition(arg1: 5f)) {
                    return new State4689소환(context);
                }

                if (context.RandomCondition(arg1: 5f)) {
                    return new State4789소환(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State1279소환 : TriggerState {
            internal State1279소환(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                context.CreateMonster(arg1: new[] {1279}, arg2: false);
                    return new StateEnd(context);
            }

            public override void OnExit() { }
        }

        private class State1238소환 : TriggerState {
            internal State1238소환(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                context.CreateMonster(arg1: new[] {1238}, arg2: false);
                    return new StateEnd(context);
            }

            public override void OnExit() { }
        }

        private class State1358소환 : TriggerState {
            internal State1358소환(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                context.CreateMonster(arg1: new[] {1358}, arg2: false);
                    return new StateEnd(context);
            }

            public override void OnExit() { }
        }

        private class State1489소환 : TriggerState {
            internal State1489소환(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                context.CreateMonster(arg1: new[] {1489}, arg2: false);
                    return new StateEnd(context);
            }

            public override void OnExit() { }
        }

        private class State1567소환 : TriggerState {
            internal State1567소환(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                context.CreateMonster(arg1: new[] {1567}, arg2: false);
                    return new StateEnd(context);
            }

            public override void OnExit() { }
        }

        private class State1679소환 : TriggerState {
            internal State1679소환(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                context.CreateMonster(arg1: new[] {1679}, arg2: false);
                    return new StateEnd(context);
            }

            public override void OnExit() { }
        }

        private class State2389소환 : TriggerState {
            internal State2389소환(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                context.CreateMonster(arg1: new[] {2389}, arg2: false);
                    return new StateEnd(context);
            }

            public override void OnExit() { }
        }

        private class State2347소환 : TriggerState {
            internal State2347소환(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                context.CreateMonster(arg1: new[] {2347}, arg2: false);
                    return new StateEnd(context);
            }

            public override void OnExit() { }
        }

        private class State2478소환 : TriggerState {
            internal State2478소환(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                context.CreateMonster(arg1: new[] {2478}, arg2: false);
                    return new StateEnd(context);
            }

            public override void OnExit() { }
        }

        private class State2456소환 : TriggerState {
            internal State2456소환(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                context.CreateMonster(arg1: new[] {2456}, arg2: false);
                    return new StateEnd(context);
            }

            public override void OnExit() { }
        }

        private class State2569소환 : TriggerState {
            internal State2569소환(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                context.CreateMonster(arg1: new[] {2569}, arg2: false);
                    return new StateEnd(context);
            }

            public override void OnExit() { }
        }

        private class State2678소환 : TriggerState {
            internal State2678소환(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                context.CreateMonster(arg1: new[] {2678}, arg2: false);
                    return new StateEnd(context);
            }

            public override void OnExit() { }
        }

        private class State3458소환 : TriggerState {
            internal State3458소환(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                context.CreateMonster(arg1: new[] {3458}, arg2: false);
                    return new StateEnd(context);
            }

            public override void OnExit() { }
        }

        private class State3589소환 : TriggerState {
            internal State3589소환(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                context.CreateMonster(arg1: new[] {3589}, arg2: false);
                    return new StateEnd(context);
            }

            public override void OnExit() { }
        }

        private class State3679소환 : TriggerState {
            internal State3679소환(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                context.CreateMonster(arg1: new[] {3679}, arg2: false);
                    return new StateEnd(context);
            }

            public override void OnExit() { }
        }

        private class State3789소환 : TriggerState {
            internal State3789소환(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                context.CreateMonster(arg1: new[] {3789}, arg2: false);
                    return new StateEnd(context);
            }

            public override void OnExit() { }
        }

        private class State4567소환 : TriggerState {
            internal State4567소환(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                context.CreateMonster(arg1: new[] {4567}, arg2: false);
                    return new StateEnd(context);
            }

            public override void OnExit() { }
        }

        private class State4578소환 : TriggerState {
            internal State4578소환(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                context.CreateMonster(arg1: new[] {4578}, arg2: false);
                    return new StateEnd(context);
            }

            public override void OnExit() { }
        }

        private class State4689소환 : TriggerState {
            internal State4689소환(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                context.CreateMonster(arg1: new[] {4689}, arg2: false);
                    return new StateEnd(context);
            }

            public override void OnExit() { }
        }

        private class State4789소환 : TriggerState {
            internal State4789소환(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                context.CreateMonster(arg1: new[] {4789}, arg2: false);
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