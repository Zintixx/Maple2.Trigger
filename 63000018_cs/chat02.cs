namespace Maple2.Trigger._63000018_cs {
    public static class _chat02 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{201, 202}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{9900})) {
                    return new StateDelay01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDelay01 : TriggerState {
            internal StateDelay01(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 12000)) {
                    return new StateChat01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateChat01 : TriggerState {
            internal StateChat01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 1, spawnId: 201, script: "$63000018_CS__CHAT02__0$", arg4: 4, arg5: 0);
                context.SetConversation(type: 1, spawnId: 202, script: "$63000018_CS__CHAT02__1$", arg4: 4, arg5: 4);
                context.SetConversation(type: 1, spawnId: 201, script: "$63000018_CS__CHAT02__2$", arg4: 4, arg5: 8);
                context.SetConversation(type: 1, spawnId: 202, script: "$63000018_CS__CHAT02__3$", arg4: 4, arg5: 12);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 16000)) {
                    return new StateDelay02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDelay02 : TriggerState {
            internal StateDelay02(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (!context.UserDetected(boxIds: new []{9900})) {
                    return new StateQuit(context);
                }

                if (context.WaitTick(waitTick: 12000)) {
                    return new StateDelay01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateQuit : TriggerState {
            internal StateQuit(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{9900})) {
                    return new StateDelay01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}
