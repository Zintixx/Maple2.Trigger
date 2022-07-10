using System.Numerics;
using Maple2.Trigger.Enum;

namespace Maple2.Trigger._83000003_colosseum {
    public static class _round12 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSound(triggerId: 11000, arg2: false);
                context.SetSound(triggerId: 11001, arg2: false);
                context.SetSound(triggerId: 12000, arg2: false);
                context.SetSound(triggerId: 12001, arg2: false);
                context.SetSound(triggerId: 13000, arg2: false);
                context.SetSound(triggerId: 13001, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "StartRound12") == 1) {
                    return new StateStartDelay(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStartDelay : TriggerState {
            internal StateStartDelay(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State라운드ConditionCheck(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State라운드ConditionCheck : TriggerState {
            internal State라운드ConditionCheck(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetDungeonRoundsRequired() == 12) {
                    context.SideNpcTalk(type: SideNpcTalkType.Talk, npcId: 11004288, illust: "nagi_normal", script: "$83000003_COLOSSEUM__ROUND12__0$", duration: 5000);
                    return new State라운드Wait(context);
                }

                context.SideNpcTalk(type: SideNpcTalkType.Talk, npcId: 11004288, illust: "nagi_switchon", script: "$83000003_COLOSSEUM__ROUND12__1$", duration: 3000);
                    context.DebugString(message: "던전 요구 아이템 점수를 달성 못해 실패 처리 됩니다.");
                    return new StateFailRound(context);
            }

            public override void OnExit() { }
        }

        private class State라운드Wait : TriggerState {
            internal State라운드Wait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSound(triggerId: 11000, arg2: true);
                context.SetSound(triggerId: 11001, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.SideNpcTalk(type: SideNpcTalkType.CutIn, illust: "Madria_normal", duration: 3000);
                    context.ShowRoundUI(round: 12, duration: 3000);
                    return new StateMonsterSpawnWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMonsterSpawnWait : TriggerState {
            internal StateMonsterSpawnWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateMonsterSpawn(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMonsterSpawn : TriggerState {
            internal StateMonsterSpawn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{112}, arg2: false);
                context.AddBuff(boxIds: new []{112}, skillId: 69000501, level: 1, arg4: true);
            }

            public override TriggerState? Execute() {
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
                context.ShowCountUI(text: "$83000003_COLOSSEUM__ROUND12__2$", count: 3, soundType: 2);
            }

            public override TriggerState? Execute() {
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

            public override TriggerState? Execute() {
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
                context.AddBalloonTalk(spawnId: 112, msg: "$83000003_COLOSSEUM__ROUND12__3$", duration: 3000);
                context.SetTimer(timerId: "LimitTimer", seconds: 180, clearAtZero: true);
                context.SetNpcDuelHpBar(isOpen: true, spawnId: 112, durationTick: 180000, npcHpStep: 10);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{112})) {
                    context.AddBalloonTalk(spawnId: 112, msg: "$83000003_COLOSSEUM__ROUND12__4$", duration: 3000);
                    context.SetNpcDuelHpBar(isOpen: false, spawnId: 112);
                    context.DestroyMonster(spawnIds: new []{10000, 10001});
                    return new StateClearRoundDelay(context);
                }

                if (context.TimeExpired(timerId: "LimitTimer")) {
                    context.SideNpcTalk(type: SideNpcTalkType.Talk, npcId: 11004288, illust: "nagi_switchon", script: "$83000003_COLOSSEUM__ROUND12__5$", duration: 3000);
                    context.DestroyMonster(spawnIds: new []{112});
                    context.SetNpcDuelHpBar(isOpen: false, spawnId: 112);
                    context.DestroyMonster(spawnIds: new []{10000, 10001});
                    return new StateFailRoundDelay(context);
                }

                if (context.UserDetected(boxIds: new []{902})) {
                    context.SideNpcTalk(type: SideNpcTalkType.Talk, npcId: 11004288, illust: "nagi_switchon", script: "$83000003_COLOSSEUM__ROUND12__6$", duration: 3000);
                    context.DestroyMonster(spawnIds: new []{112});
                    context.SetNpcDuelHpBar(isOpen: false, spawnId: 112);
                    context.DestroyMonster(spawnIds: new []{10000, 10001});
                    return new StateFailRoundDelay(context);
                }

                if (!context.UserDetected(boxIds: new []{904})) {
                    context.SideNpcTalk(type: SideNpcTalkType.Talk, npcId: 11004288, illust: "nagi_switchon", script: "$83000003_COLOSSEUM__ROUND12__7$", duration: 3000);
                    context.DestroyMonster(spawnIds: new []{112});
                    context.SetNpcDuelHpBar(isOpen: false, spawnId: 112);
                    context.DestroyMonster(spawnIds: new []{10000, 10001});
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
                context.SetSound(triggerId: 12000, arg2: true);
                context.SetSound(triggerId: 12001, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.AddBuff(boxIds: new []{904}, skillId: 69000503, level: 1, arg4: false, arg5: false);
                    context.SetEventUI(arg1: 3, script: "$83000003_COLOSSEUM__ROUND12__8$", duration: 3000);
                    return new StateClearRound(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateFailRoundDelay : TriggerState {
            internal StateFailRoundDelay(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSound(triggerId: 13000, arg2: true);
                context.SetSound(triggerId: 13001, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.SetEventUI(arg1: 5, script: "$83000003_COLOSSEUM__ROUND12__9$", duration: 3000);
                    return new StateFailRound(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateClearRound : TriggerState {
            internal StateClearRound(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.MoveUserToPos(position: new Vector3(300f, -225f, 1500f), rotation: new Vector3(0f, 0f, 270f));
                    context.SideNpcTalk(type: SideNpcTalkType.Talk, npcId: 11004288, illust: "nagi_normal", script: "$83000003_COLOSSEUM__ROUND12__10$", duration: 3000);
                    context.SetUserValue(triggerId: 900001, key: "StartRound12", value: 2);
                    return new State이동Wait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State이동Wait : TriggerState {
            internal State이동Wait(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.MoveUserPath(patrolName: "MS2PatrolData_01");
                    return new StateWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateFailRound : TriggerState {
            internal StateFailRound(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.SetUserValue(triggerId: 900001, key: "StartRound12", value: 3);
                    return new StateWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}
