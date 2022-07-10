﻿using System.Numerics;
using Maple2.Trigger.Enum;

namespace Maple2.Trigger {
    public interface ITriggerContext {
        #region Actions
        public void AddBalloonTalk(int spawnId = 0, string msg = "", int duration = 0, int delayTick = 0);
        public void AddBuff(int[] boxIds, int skillId = 0, short level = 0, bool arg4 = true, bool arg5 = true, string feature = "");
        public void AddCinematicTalk(int npcId = 0, string illustId = "", string script = "", int duration = 0, Align align = default, int delayTick = 0);
        public void AddEffectNif(int spawnId = 0, string nifPath = "", bool isOutline = false, float scale = 0f, int rotateZ = 0);
        public void AddUserValue(string key = "", int value = 0);
        public void ArcadeBoomBoomOceanSetSkillScore(int skillId = 0, int score = 0);
        public void ArcadeBoomBoomOceanStartGame(byte lifeCount = 0);
        public void ArcadeBoomBoomOceanEndGame();
        public void ArcadeBoomBoomOceanStartRound(byte round = 0, int roundDuration = 0, int timeScoreRate = 0);
        public void ArcadeBoomBoomOceanClearRound(byte round = 0);
        public void ArcadeSpringFarmSetInteractScore(int interactId = 0, int score = 0);
        public void ArcadeSpringFarmSpawnMonster(int[] spawnId, int score = 0);
        public void ArcadeSpringFarmStartGame(byte lifeCount = 0);
        public void ArcadeSpringFarmEndGame();
        public void ArcadeSpringFarmStartRound(byte round = 0, int uiDuration = 0, string timeScoreType = "", int timeScoreRate = 0, int roundDuration = 0);
        public void ArcadeSpringFarmClearRound(byte round = 0);
        public void ArcadeThreeTwoOneStartGame(byte lifeCount = 0, int initScore = 0);
        public void ArcadeThreeTwoOneEndGame();
        public void ArcadeThreeTwoOneStartRound(byte round = 0, int uiDuration = 0);
        public void ArcadeThreeTwoOneResultRound(byte resultDirection = 0);
        public void ArcadeThreeTwoOneResultRound2(byte round = 0);
        public void ArcadeThreeTwoOneClearRound(byte round = 0);
        public void ChangeBackground(string dds = "");
        public void ChangeMonster(int removeSpawnId = 0, int addSpawnId = 0);
        public void CameraReset(float interpolationTime = 0f);
        public void CameraSelect(int triggerId = 0, bool enable = true);
        public void CameraSelectPath(int[] pathIds, bool returnView = true);
        public void CloseCinematic();
        public void CreateFieldGame(FieldGame type = default, bool reset = false);
        public void CreateItem(int[] spawnIds, int triggerId = 0, int itemId = 0, int arg5 = 0);
        public void CreateMonster(int[] spawnIds, bool arg2 = true, int arg3 = 0);
        public void CreateWidget(WidgetType type = default);
        public void DarkStreamSpawnMonster(int[] spawnIds, int score = 0);
        public void DarkStreamStartGame(byte round = 0);
        public void DarkStreamStartRound(byte round = 0, int uiDuration = 0, int damagePenalty = 0);
        public void DarkStreamClearRound(byte round = 0);
        public void DebugString(string message = "", string feature = "");
        public void DestroyMonster(int[] spawnIds, bool arg2 = true);
        public void DungeonClear(string uiType = "None");
        public void DungeonClearRound(byte round = 0);
        public void DungeonCloseTimer();
        public void DungeonDisableRanking();
        public void DungeonEnableGiveUp(bool enable);
        public void DungeonFail();
        public void DungeonMissionComplete(int missionId, string feature = "");
        public void DungeonMoveLapTimeToNow(byte id);
        public void DungeonResetTime(int seconds);
        public void DungeonSetEndTime();
        public void DungeonSetLapTime(byte id, int lapTime);
        public void DungeonStopTimer();
        public void SetDungeonVariable(int varId, bool value);
        public void EnableLocalCamera(bool isEnable);
        public void EnableSpawnPointPc(int spawnId, bool isEnable);
        public void EndMiniGame(int winnerBoxId = 0, MiniGame type = default, bool isOnlyWinner = false);
        public void EndMiniGameRound(int winnerBoxId = 0, float expRate = 0f, bool isOnlyWinner = false, bool isGainLoserBonus = false, bool meso = false, MiniGame type = default);
        public void FaceEmotion(int spawnId = 0, string emotionName = "");
        public void FieldGameConstant(string key = "", string value = "", string feature = "", Locale locale = default);
        public void FieldGameMessage(byte custom = 0, string type = "", byte arg1 = 0, string script = "", int duration = 0);
        public void FieldWarEnd(bool isClear);
        public void GiveGuildExp(int boxId, byte type);
        public void GiveRewardContent(int rewardId);
        public void GuideEvent(int eventId);
        public void GuildVsGameEndGame();
        public void GuildVsGameGiveContribution(int teamId, bool isWin, string description = "");
        public void GuildVsGameGiveReward(GuildReward type, int teamId, bool isWin, string description = "");
        public void GuildVsGameLogResult(string description = "");
        public void GuildVsGameLogWonByDefault(int teamId, string description = "");
        public void GuildVsGameResult(string description = "");
        public void GuildVsGameScoreByUser(int boxId, bool score, string description = "");
        public void HideGuideSummary(int entityId, int textId = 0);
        public void InitNpcRotation(int[] spawnIds);
        public void KickMusicAudience(int boxId, int portalId);
        public void LimitSpawnNpcCount(int limitCount);
        public void LockMyPc(bool isLock);
        public void MiniGameCameraDirection(int boxId, int cameraId);
        public void MiniGameGiveExp(int boxId, float expRate, bool isOutSide);
        public void MiniGameGiveReward(int winnerBoxId, string contentType, MiniGame type = default);
        public void MoveNpc(int spawnId, string patrolName);
        public void MoveNpcToPos(int spawnId, Vector3 position, Vector3 rotation);
        public void MoveRandomUser(int mapId, int portalId, int triggerId, int count);
        public void MoveToPortal(int portalId, int boxId = 0, int userTagId = 0);
        public void MoveUser(int mapId, int portalId = 0, int boxId = 0);
        public void MoveUserPath(string patrolName);
        public void MoveUserToBox(int boxId, int portalId);
        public void MoveUserToPos(Vector3 position, Vector3 rotation = default);
        public void Notice(bool arg1, string script, bool arg3);
        public void NpcRemoveAdditionalEffect(int spawnId, int additionalEffectId);
        public void NpcToPatrolInBox(int boxId, int npcId, string spawnId, string patrolName);
        public void PatrolConditionUser(string patrolName, byte patrolIndex, int additionalEffectId);
        public void PlaySceneMovie(string fileName, int movieId = 0, string skipType = "");
        public void PlaySystemSoundByUserTag(int userTagId, string sound);
        public void PlaySystemSoundInBox(string sound, int[]? boxIds = null);
        public void RandomAdditionalEffect(string target, int boxId, int spawnId, byte targetCount, int tick, int waitTick, string targetEffect, int additionalEffectId);
        public void RemoveBalloonTalk(int spawnId);
        public void RemoveBuff(int boxId, int skillId, bool arg3 = false);
        public void RemoveCinematicTalk();
        public void RemoveEffectNif(int spawnId);
        public void ResetTimer(string timerId);
        public void RoomExpire();
        public void ScoreBoardCreate(string type = "", int maxScore = 0);
        public void ScoreBoardRemove();
        public void ScoreBoardSetScore(bool score = false);
        public void SetAchievement(string type, string code, int triggerId = 0);
        public void SetActor(int triggerId, bool visible, string initialSequence = "", bool arg4 = false, bool arg5 = false);
        public void SetAgent(int[] triggerIds, bool visible);
        public void SetAiExtraData(string key, int value, bool isModify = false, int boxId = 0);
        public void SetAmbientLight(Vector3 color);
        public void SetCinematicIntro(string text);
        public void SetConversation(byte type, int spawnId = 0, string script = "", int arg4 = 0, byte arg5 = 0, Align align = default);
        public void SetCube(int[] triggerIds, bool visible, byte randomCount = 0);
        public void SetDirectionalLight(Vector3 diffuseColor, Vector3 specularColor);
        public void SetEffect(int[] triggerIds, bool visible = false, int arg3 = 0, byte arg4 = 0);
        public void SetEventUI(byte arg1, string script = "", int duration = 0, int boxId = 0, int notBoxId = 0);
        public void SetGravity(float gravity);
        public void SetInteractObject(int[] interactIds, byte state, bool arg4 = false, bool arg3 = false);
        public void SetLadder(int triggerId, bool visible, bool animationEffect, int animationDelay = 0);
        public void SetLocalCamera(int cameraId, bool enable);
        public void SetMesh(int[] triggerIds, bool visible = false, int arg3 = 0, int arg4 = 0, float arg5 = 0f);
        public void SetMeshAnimation(int[] triggerIds, bool visible = false, byte arg3 = 0, byte arg4 = 0);
        public void SetMiniGameAreaForHack(int boxId = 0);
        public void SetBreakable(int[] triggerIds, bool enabled);
        public void SetNpcDuelHpBar(bool isOpen, int spawnId, int durationTick = 0, byte npcHpStep = 0);
        public void SetNpcEmotionLoop(int spawnId, string sequenceName, float duration = 0f);
        public void SetNpcEmotionSequence(int spawnId, string sequenceName, int durationTick = 0);
        public void SetNpcRotation(int spawnId, float rotation);
        public void SetOnetimeEffect(int id, bool enable, string path);
        public void SetPcEmotionLoop(string sequenceName, float duration, bool arg3 = false);
        public void SetPcEmotionSequence(string[] sequenceNames);
        public void SetPcRotation(Vector3 rotation);
        public void SetPhotoStudio(bool isEnable);
        public void SetPortal(int portalId, bool visible, bool enabled = false, bool minimapVisible = false, bool arg5 = false);
        public void SetCinematicUI(byte type, string script = "", bool arg3 = false);
        public void SetPvpZone(int boxId, byte arg2, int duration, int additionalEffectId, byte arg5, int[]? boxIds = default);
        public void SetQuestAccept(int questId);
        public void SetQuestComplete(int questId);
        public void SetRandomMesh(int[] triggerIds, bool visible = false, int meshCount = 0, int arg4 = 0, int delay = 0);
        public void SetRope(int triggerId, bool visible, bool animationEffect, int animationDelay);
        public void SetSceneSkip(TriggerState? state = default, string arg2 = "");
        public void SetSkill(int[] triggerIds, bool arg2 = false);
        public void SetSkip(TriggerState? state = default);
        public void SetSound(int triggerId, bool arg2);
        public void SetState(byte arg1, string[] arg2, bool arg3);
        public void SetTimer(string timerId, int seconds, bool clearAtZero = false, bool display = false, int arg5 = 0, string arg6 = "");
        public void SetTimeScale(bool enable, float startScale, float endScale, float duration, byte interpolator);
        public void SetUserValue(string key, int value, int triggerId = 0);
        public void SetUserValueFromDungeonRewardCount(string key, int dungeonRewardId);
        public void SetUserValueFromGuildVsGameScore(int teamId, string key);
        public void SetUserValueFromUserCount(int boxId, string key, int userTagId);
        public void SetVisibleBreakableObject(int[] triggerIds, bool arg2 = false);
        public void SetVisibleUI(string[] uiNames, bool visible = false);
        public void ShadowExpeditionOpenBossGauge(int maxGaugePoint, string title = "");
        public void ShadowExpeditionCloseBossGauge();
        public void ShowCaption(CaptionType type, string title, string script = "", Align align = default, float offsetRateX = 0f, float offsetRateY = 0f, int duration = 0, float scale = 0f);
        public void ShowCountUI(string text, byte stage = 0, byte count = 0, byte soundType = 1);
        public void ShowEventResult(EventResultType type, string text, int duration, int userTagId = 0, int boxId = 0, bool isOutSide = false);
        public void ShowGuideSummary(int entityId, int textId = 0, int duration = 0);
        public void ShowRoundUI(byte round, int duration);
        public void SideNpcTalk(int npcId = 0, string illust = "", int duration = 0, string script = "", string voice = "", SideNpcTalkType type = default, string usm = "");
        public void SightRange(bool enable, byte range, int rangeZ = 0, byte border = 0);
        public void SpawnItemRange(int[] rangeId, int randomPickCount);
        public void SpawnNpcRange(int[] rangeId, bool isAutoTargeting = false, byte randomPickCount = 0, int score = 0);
        public void StartCombineSpawn(int[] groupId, bool isStart = false);
        public void StartMiniGame(int boxId, byte round, MiniGame type = default, bool isShowResultUI = true);
        public void StartMiniGameRound(int boxId, byte round);
        public void StartTutorial();
        public void TalkNpc(int spawnId);
        public void UnSetMiniGameAreaForHack();
        public void UserTagSymbol(string symbol1, string symbol2);
        public void UserValueToNumberMesh(string key, int startMeshId, byte digitCount);
        public void UseState(byte arg1, bool arg2);
        public void VisibleMyPc(bool visible);
        public void Weather(WeatherType type = default);
        public void WeddingBroken();
        public void WeddingMoveUser(WeddingEntryType type, int mapId, int[] portalIds, int boxId = 0);
        public void WeddingMutualAgree(WeddingAgreeType type);
        public void WeddingMutualCancel(WeddingAgreeType type);
        public void WeddingSetUserEmotion(WeddingEntryType type, byte id);
        public void WeddingSetUserLookAt(WeddingEntryType type, WeddingEntryType lookAtType, bool immediate = false);
        public void WeddingSetUserRotation(WeddingEntryType type, Vector3 rotation = default, bool immediate = false);
        public void WeddingUserToPatrol(string patrolName, WeddingEntryType type, byte patrolIndex);
        public void WeddingVowComplete();
        public void WidgetAction(WidgetType type, string name, int widgetArgType = 0, string args = "");
        public void WriteLog(string logName, string @event, int triggerId = 0, int arg4 = 0, string arg5 = "");
        #endregion

        #region Conditions
        public bool BonusGameRewardDetected(byte boxId);
        public bool CheckAnyUserAdditionalEffect(int boxId, int additionalEffectId, short level);
        public bool CheckDungeonLobbyUserCount();
        public bool CheckNpcAdditionalEffect(int spawnId, int additionalEffectId, short level);
        public bool CheckSameUserTag(int boxId);
        public bool DayOfWeek(byte[] dayOfWeeks, string description = "");
        public bool DetectLiftableObject(int[] boxIds, int itemId);
        public bool DungeonTimeOut();
        public bool GuildVsGameWinnerTeam(int teamId);
        public bool IsDungeonRoom();
        public bool IsPlayingMapleSurvival();
        public bool MonsterDead(int[] spawnIds, bool arg2 = true);
        public bool MonsterInCombat(int[] spawnIds);
        public bool NpcDetected(int boxId, int[] spawnIds);
        public bool NpcIsDeadByStringId(string stringId);
        public bool ObjectInteracted(int[] interactIds, byte arg2 = 0);
        public bool PvpZoneEnded(int boxId = 0);
        public bool QuestUserDetected(int[] boxIds, int[] questIds, byte[] questStates, byte jobCode = 0);
        public bool RandomCondition(float rate = 0f, string description = "");
        public bool TimeExpired(string timerId);
        public bool UserDetected(int[] boxIds, byte jobCode = 0);
        public bool WaitAndResetTick(int waitTick = 0);
        public bool WaitTick(int waitTick = 0);
        public bool WeddingEntryInField(WeddingEntryType type);
        public bool WeddingHallState(string hallState);
        public bool? WeddingMutualAgreeResult(WeddingAgreeType type);
        public bool WidgetCondition(WidgetType type, string condition, string value = "");
        #endregion

        #region Getters
        public int GetDungeonFirstUserMissionScore();
        public int GetDungeonId();
        public int GetDungeonLevel();
        public int GetDungeonMaxUserCount();
        public int GetDungeonPlayTime();
        public int GetDungeonRoundsRequired();
        public string GetDungeonState();
        public bool GetDungeonVariable(int id);
        public float GetNpcDamageRate(int spawnId);
        public int GetNpcExtraData(int spawnId, string extraDataKey);
        public float GetNpcHpRate(int spawnId);
        public int GetScoreBoardScore();
        public int GetShadowExpeditionPoints();
        public int GetUserCount(int boxId = 0, int userTagId = 0);
        public int GetUserValue(string key);
        #endregion
    }
}
