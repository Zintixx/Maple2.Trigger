namespace Maple2.Trigger._02000292_bf {
    public static class _npc9 {
        public class StateWaitStart : TriggerState {
            internal StateWaitStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(interactIds: new []{10000628}, state: 1);
                context.DestroyMonster(spawnIds: new []{1108});
            }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{10000628}, arg2: 0)) {
                    return new StateNPCScript(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateNPCScript : TriggerState {
            internal StateNPCScript(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(interactIds: new []{10000628}, state: 2);
                context.CreateMonster(spawnIds: new []{1108});
                context.SetConversation(type: 1, spawnId: 1108, script: "$02000292_BF__NPC9__0$", arg4: 2);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateNPC이동(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateNPC이동 : TriggerState {
            internal StateNPC이동(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 1, spawnId: 1108, script: "$02000292_BF__NPC9__1$", arg4: 2);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateNPCDestroy(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateNPCDestroy : TriggerState {
            internal StateNPCDestroy(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(spawnIds: new []{1108});
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
