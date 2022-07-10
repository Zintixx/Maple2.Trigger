namespace Maple2.Trigger._66200001_gd {
    public static class _color_7410 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(key: "Color41", value: 10);
                context.SetMesh(triggerIds: new []{841}, visible: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(triggerIds: new []{941, 1041}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "ColorStart") == 1) {
                    return new StateYellowBefore(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateYellowBefore : TriggerState {
            internal StateYellowBefore(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{841}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{941, 1041}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "ColorClear") == 1) {
                    return new StateClear(context);
                }

                if (context.GetUserValue(key: "ColorReset") == 1) {
                    return new StateReset(context);
                }

                if (context.GetUserValue(key: "ColorEnd") == 1) {
                    return new StateRegen(context);
                }

                if (context.GetUserValue(key: "Color41") == 2) {
                    return new StateGreenAfter(context);
                }

                if (context.GetUserValue(key: "Color41") == 3) {
                    // return new StateYellowtoRed(context);
                    return null;
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateRedBefore : TriggerState {
            internal StateRedBefore(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{1041}, visible: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(triggerIds: new []{941, 841}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "ColorClear") == 1) {
                    return new StateClear(context);
                }

                if (context.GetUserValue(key: "ColorReset") == 1) {
                    return new StateReset(context);
                }

                if (context.GetUserValue(key: "ColorEnd") == 1) {
                    return new StateRegen(context);
                }

                if (context.GetUserValue(key: "Color41") == 1) {
                    return new StateYellowAfter(context);
                }

                if (context.GetUserValue(key: "Color41") == 2) {
                    return new StateGreenAfter(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateGreenAfter : TriggerState {
            internal StateGreenAfter(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{941}, visible: true, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "ColorClear") == 1) {
                    return new StateClear(context);
                }

                if (context.GetUserValue(key: "ColorReset") == 1) {
                    return new StateReset(context);
                }

                if (context.GetUserValue(key: "ColorEnd") == 1) {
                    return new StateRegen(context);
                }

                if (context.GetUserValue(key: "Color41") == 1) {
                    return new StateYellowAfter(context);
                }

                if (context.GetUserValue(key: "Color41") == 3) {
                    return new StateRedAfter(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateYellowAfter : TriggerState {
            internal StateYellowAfter(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{841}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{941}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(triggerIds: new []{1041}, visible: false, arg3: 100, arg4: 0, arg5: 0f);
            }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "ColorClear") == 1) {
                    return new StateClear(context);
                }

                if (context.GetUserValue(key: "ColorReset") == 1) {
                    return new StateReset(context);
                }

                if (context.GetUserValue(key: "ColorEnd") == 1) {
                    return new StateRegen(context);
                }

                if (context.GetUserValue(key: "Color41") == 2) {
                    return new StateGreenAfter(context);
                }

                if (context.GetUserValue(key: "Color41") == 3) {
                    return new StateRedAfter(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateRedAfter : TriggerState {
            internal StateRedAfter(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{1041}, visible: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(triggerIds: new []{941}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(triggerIds: new []{841}, visible: false, arg3: 100, arg4: 0, arg5: 0f);
            }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "ColorClear") == 1) {
                    return new StateClear(context);
                }

                if (context.GetUserValue(key: "ColorReset") == 1) {
                    return new StateReset(context);
                }

                if (context.GetUserValue(key: "ColorEnd") == 1) {
                    return new StateRegen(context);
                }

                if (context.GetUserValue(key: "Color41") == 1) {
                    return new StateYellowAfter(context);
                }

                if (context.GetUserValue(key: "Color41") == 2) {
                    return new StateGreenAfter(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateClear : TriggerState {
            internal StateClear(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{941}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{841}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{1041}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
            }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "ColorEnd") == 1) {
                    return new StateRegen(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateRegen : TriggerState {
            internal StateRegen(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(key: "ColorStart", value: 0);
                context.SetUserValue(key: "ColorEnd", value: 0);
                context.SetUserValue(key: "ColorReset", value: 0);
                context.SetUserValue(key: "ColorClear", value: 0);
                context.SetMesh(triggerIds: new []{841}, visible: true, arg3: 400, arg4: 0, arg5: 0f);
                context.SetMesh(triggerIds: new []{941, 1041}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateReset : TriggerState {
            internal StateReset(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(key: "ColorStart", value: 0);
                context.SetUserValue(key: "ColorReset", value: 0);
                context.SetUserValue(key: "ColorClear", value: 0);
            }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "ColorEnd") == 1) {
                    return new StateWait(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SetUserValue(key: "ColorEnd", value: 0);
            }
        }
    }
}
