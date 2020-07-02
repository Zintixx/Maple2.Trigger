using System.Numerics;

namespace Maple2.Trigger._83000003_colosseum {
    public static class _round2 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSound(arg1: 11000, arg2: false);
                context.SetSound(arg1: 11001, arg2: false);
                context.SetSound(arg1: 12000, arg2: false);
                context.SetSound(arg1: 12001, arg2: false);
                context.SetSound(arg1: 13000, arg2: false);
                context.SetSound(arg1: 13001, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "StartRound2") == 1) {
                    return new StateStartDelay(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStartDelay : TriggerState {
            internal StateStartDelay(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State라운드조건체크(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State라운드조건체크 : TriggerState {
            internal State라운드조건체크(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.GetDungeonRoundsRequired() == 2) {
                    context.SideNpcTalk(type: "talk", npcId: 11004288, illust: "nagi_normal", script: "$83000002_COLOSSEUM__ROUND2__0$", duration: 5000);
                    return new State라운드대기(context);
                }

                context.SideNpcTalk(type: "talk", npcId: 11004288, illust: "nagi_switchon", script: "$83000002_COLOSSEUM__ROUND2__1$", duration: 3000);
                    context.DebugString(message: "던전 요구 아이템 점수를 달성 못해 실패 처리 됩니다.");
                    return new StateFailRound(context);
            }

            public override void OnExit() { }
        }

        private class State라운드대기 : TriggerState {
            internal State라운드대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSound(arg1: 11000, arg2: true);
                context.SetSound(arg1: 11001, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.SideNpcTalk(type: "cutin", illust: "Startz_normal", duration: 3000);
                    context.ShowRoundUI(round: 2, duration: 3000);
                    return new StateMonster스폰대기(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMonster스폰대기 : TriggerState {
            internal StateMonster스폰대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateMonster스폰(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMonster스폰 : TriggerState {
            internal StateMonster스폰(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {102}, arg2: false);
                context.AddBuff(arg1: new[] {102}, arg2: 69000501, arg3: 1, arg4: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateCount(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCount : TriggerState {
            internal StateCount(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowCountUI(text: "$83000002_COLOSSEUM__ROUND2__2$", count: 3, soundType: 2);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3500)) {
                    return new StateBattleStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBattleStart : TriggerState {
            internal StateBattleStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.LockMyPc(isLock: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State스폰대사(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State스폰대사 : TriggerState {
            internal State스폰대사(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBalloonTalk(spawnPointId: 102, msg: "$83000002_COLOSSEUM__ROUND2__3$", duration: 3000);
                context.SetTimer(arg1: "LimitTimer", arg2: 60, arg3: true);
                context.SetNpcDuelHpBar(isOpen: true, spawnPointId: 102, durationTick: 60000, npcHpStep: 10);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {102})) {
                    context.AddBalloonTalk(spawnPointId: 102, msg: "$83000002_COLOSSEUM__ROUND2__4$", duration: 3000);
                    context.SetNpcDuelHpBar(isOpen: false, spawnPointId: 102);
                    return new StateClearRoundDelay(context);
                }

                if (context.TimeExpired(arg1: "LimitTimer")) {
                    context.SideNpcTalk(type: "talk", npcId: 11004288, illust: "nagi_switchon", script: "$83000002_COLOSSEUM__ROUND2__5$", duration: 3000);
                    context.DestroyMonster(arg1: new[] {102});
                    context.SetNpcDuelHpBar(isOpen: false, spawnPointId: 102);
                    return new StateFailRoundDelay(context);
                }

                if (context.UserDetected(arg1: new[] {902})) {
                    context.SideNpcTalk(type: "talk", npcId: 11004288, illust: "nagi_switchon", script: "$83000002_COLOSSEUM__ROUND2__6$", duration: 3000);
                    context.DestroyMonster(arg1: new[] {102});
                    context.SetNpcDuelHpBar(isOpen: false, spawnPointId: 102);
                    return new StateFailRoundDelay(context);
                }

                if (!context.UserDetected(arg1: new[] {904})) {
                    context.SideNpcTalk(type: "talk", npcId: 11004288, illust: "nagi_switchon", script: "$83000002_COLOSSEUM__ROUND2__7$", duration: 3000);
                    context.DestroyMonster(arg1: new[] {102});
                    context.SetNpcDuelHpBar(isOpen: false, spawnPointId: 102);
                    return new StateFailRoundDelay(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateClearRoundDelay : TriggerState {
            internal StateClearRoundDelay(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.LockMyPc(isLock: true);
                context.SetSound(arg1: 12000, arg2: true);
                context.SetSound(arg1: 12001, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.AddBuff(arg1: new[] {904}, arg2: 69000503, arg3: 1, arg4: false, arg5: false);
                    context.SetEventUI(arg1: 3, arg2: "$83000002_COLOSSEUM__ROUND2__8$", arg3: 3000);
                    return new StateClearRound(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateFailRoundDelay : TriggerState {
            internal StateFailRoundDelay(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSound(arg1: 13000, arg2: true);
                context.SetSound(arg1: 13001, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.SetEventUI(arg1: 5, arg2: "$83000002_COLOSSEUM__ROUND2__9$", arg3: 3000);
                    return new StateFailRound(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateClearRound : TriggerState {
            internal StateClearRound(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.MoveUserToPos(pos: new Vector3(300f, -225f, 1500f), rot: new Vector3(0f, 0f, 270f));
                    context.SideNpcTalk(type: "talk", npcId: 11004288, illust: "nagi_normal", script: "$83000002_COLOSSEUM__ROUND2__10$", duration: 3000);
                    context.SetUserValue(triggerId: 900001, key: "StartRound2", value: 2);
                    return new State이동대기(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State이동대기 : TriggerState {
            internal State이동대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.MoveUserPath(arg1: "MS2PatrolData_01");
                    return new StateWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateFailRound : TriggerState {
            internal StateFailRound(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.SetUserValue(triggerId: 900001, key: "StartRound2", value: 3);
                    return new StateWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}