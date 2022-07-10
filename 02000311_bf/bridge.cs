namespace Maple2.Trigger._02000311_bf {
    public static class _bridge {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{3001, 3002, 3003, 3004, 3005, 3006, 3007, 3008, 3009, 3010}, visible: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(triggerIds: new []{3011, 3012, 3013, 3014, 3015, 3016, 3017, 3018}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override TriggerState? Execute() {
                if (context.MonsterInCombat(spawnIds: new []{99})) {
                    return new State트로피(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State트로피 : TriggerState {
            internal State트로피(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, script: "$02000384_BF__BARRICADE__0$", duration: 3000);
                context.SetAchievement(type: "trigger", code: "meetfirroth");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 30000)) {
                    return new StateBlock(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBlock : TriggerState {
            internal StateBlock(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{3001, 3002, 3003, 3004, 3005, 3006, 3007, 3008, 3009, 3010}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(triggerIds: new []{3011, 3012, 3013, 3014, 3015, 3016, 3017, 3018}, visible: true, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{99})) {
                    return new StateUnblock(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateUnblock : TriggerState {
            internal StateUnblock(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{3001, 3002, 3003, 3004, 3005, 3006, 3007, 3008, 3009, 3010}, visible: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(triggerIds: new []{3011, 3012, 3013, 3014, 3015, 3016, 3017, 3018}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 100)) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnd : TriggerState {
            internal StateEnd(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
