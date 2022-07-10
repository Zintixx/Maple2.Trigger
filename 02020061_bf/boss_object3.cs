namespace Maple2.Trigger._02020061_bf {
    public static class _boss_object3 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{5201}, visible: false);
                context.SetUserValue(triggerId: 99990023, key: "MonsterSpawn", value: 0);
                context.DestroyMonster(spawnIds: new []{713, 723});
                context.SetInteractObject(interactIds: new []{12000096}, state: 2);
            }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "BossObjectStart") == 1) {
                    return new StateLever3_체크(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateLever3_체크 : TriggerState {
            internal StateLever3_체크(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{723}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "BossObjectStart") == 2) {
                    return new StateEnd(context);
                }

                if (context.MonsterDead(spawnIds: new []{713})) {
                    return new StateLever3_발동(context);
                }

                if (context.MonsterDead(spawnIds: new []{921, 922, 923, 924, 925, 926})) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateLever3_발동 : TriggerState {
            internal StateLever3_발동(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{5201}, visible: true);
                context.SetInteractObject(interactIds: new []{12000096}, state: 1);
            }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "BossObjectStart") == 2) {
                    return new StateWait(context);
                }

                if (context.MonsterDead(spawnIds: new []{921, 922, 923, 924, 925, 926})) {
                    return new StateEnd(context);
                }

                if (context.ObjectInteracted(interactIds: new []{12000096}, arg2: 0)) {
                    return new StateLever3_안내(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateLever3_안내 : TriggerState {
            internal StateLever3_안내(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 99990023, key: "MonsterSpawn", value: 1);
            }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "BossObjectStart") == 2) {
                    return new StateEnd(context);
                }

                if (context.MonsterDead(spawnIds: new []{921, 922, 923, 924, 925, 926})) {
                    return new StateEnd(context);
                }

                if (context.WaitTick(waitTick: 10000)) {
                    return new StateLever3_재활성(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateLever3_재활성 : TriggerState {
            internal StateLever3_재활성(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(interactIds: new []{12000096}, state: 1);
            }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "BossObjectStart") == 2) {
                    return new StateEnd(context);
                }

                if (context.MonsterDead(spawnIds: new []{921, 922, 923, 924, 925, 926})) {
                    return new StateEnd(context);
                }

                if (context.ObjectInteracted(interactIds: new []{12000096}, arg2: 0)) {
                    return new StateLever3_재활성_Wait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateLever3_재활성_Wait : TriggerState {
            internal StateLever3_재활성_Wait(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "BossObjectStart") == 2) {
                    return new StateEnd(context);
                }

                if (context.MonsterDead(spawnIds: new []{921, 922, 923, 924, 925, 926})) {
                    return new StateEnd(context);
                }

                if (context.WaitTick(waitTick: 10000)) {
                    return new StateLever3_재활성(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnd : TriggerState {
            internal StateEnd(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{5201}, visible: false);
                context.SetUserValue(triggerId: 99990023, key: "MonsterSpawn", value: 0);
                context.DestroyMonster(spawnIds: new []{713, 723});
                context.SetInteractObject(interactIds: new []{12000096}, state: 2);
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
