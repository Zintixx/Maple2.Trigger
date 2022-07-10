namespace Maple2.Trigger._02100004_bf {
    public static class _barricade {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "BattleStart") == 1) {
                    return new StateCount(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCount : TriggerState {
            internal StateCount(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, script: "$02000384_BF__BARRICADE__0$", duration: 3000);
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
                context.SetMesh(triggerIds: new []{3000, 3001}, visible: true, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "BattleEnd") == 1) {
                    return new StateUnblock(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateUnblock : TriggerState {
            internal StateUnblock(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{3000, 3001}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
