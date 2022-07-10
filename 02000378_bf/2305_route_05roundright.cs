namespace Maple2.Trigger._02000378_bf {
    public static class _2305_route_05roundright {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(portalId: 12, visible: false, enabled: false, minimapVisible: false);
                context.SetMesh(triggerIds: new []{4012}, visible: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetAgent(triggerIds: new []{28051, 28052}, visible: true);
                context.SetMesh(triggerIds: new []{230500, 230501, 230502, 230503, 230504, 230505, 230506, 230507, 230508, 230509, 230510, 230511, 230512, 230513, 230514, 230515, 230516, 230517, 230518, 230519, 230520, 230521, 230522, 230523, 230524, 230525, 430500, 430501, 430502, 430503, 430504, 430505, 430506, 430507, 430508, 430509, 430510, 430511, 430512, 430513, 430514, 430515, 430516, 430517, 430518, 430519, 430520, 430521, 430522, 430523, 430524, 430525}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetUserValue(key: "RouteSelected", value: 0);
                context.SetUserValue(key: "MakeTrue", value: 0);
                context.SetUserValue(key: "MakeFalse", value: 0);
            }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "RouteSelected") == 1) {
                    return new StateStartDazzlingRandom01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStartDazzlingRandom01 : TriggerState {
            internal StateStartDazzlingRandom01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetRandomMesh(triggerIds: new []{230500, 230501, 230502, 230503, 230504, 230505, 230506, 230507, 230508, 230509, 230510, 230511, 230512, 230513, 230514, 230515, 230516, 230517, 230518, 230519, 230520, 230521, 230522, 230523, 230524, 230525}, visible: true, meshCount: 7, arg4: 100, delay: 500);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    return new StateStartDazzlingRandom02(context);
                }

                if (context.GetUserValue(key: "MakeTrue") == 1) {
                    return new StateMakeTrue(context);
                }

                if (context.GetUserValue(key: "MakeFalse") == 1) {
                    return new StateMakeFalse(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SetRandomMesh(triggerIds: new []{230500, 230501, 230502, 230503, 230504, 230505, 230506, 230507, 230508, 230509, 230510, 230511, 230512, 230513, 230514, 230515, 230516, 230517, 230518, 230519, 230520, 230521, 230522, 230523, 230524, 230525}, visible: false, meshCount: 26, arg4: 0, delay: 0);
            }
        }

        private class StateStartDazzlingRandom02 : TriggerState {
            internal StateStartDazzlingRandom02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetRandomMesh(triggerIds: new []{230500, 230501, 230502, 230503, 230504, 230505, 230506, 230507, 230508, 230509, 230510, 230511, 230512, 230513, 230514, 230515, 230516, 230517, 230518, 230519, 230520, 230521, 230522, 230523, 230524, 230525}, visible: true, meshCount: 7, arg4: 100, delay: 500);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    return new StateStartDazzlingRandom01(context);
                }

                if (context.GetUserValue(key: "MakeTrue") == 1) {
                    return new StateMakeTrue(context);
                }

                if (context.GetUserValue(key: "MakeFalse") == 1) {
                    return new StateMakeFalse(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SetRandomMesh(triggerIds: new []{230500, 230501, 230502, 230503, 230504, 230505, 230506, 230507, 230508, 230509, 230510, 230511, 230512, 230513, 230514, 230515, 230516, 230517, 230518, 230519, 230520, 230521, 230522, 230523, 230524, 230525}, visible: false, meshCount: 26, arg4: 0, delay: 0);
            }
        }

        private class StateMakeTrue : TriggerState {
            internal StateMakeTrue(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{5005}, visible: true);
                context.SetMesh(triggerIds: new []{230500, 230501, 230502, 230503, 230504, 230505, 230506, 230507, 230508, 230509, 230510, 230511, 230512, 230513, 230514, 230515, 230516, 230517, 230518, 230519, 230520, 230521, 230522, 230523, 230524, 230525}, visible: false, arg3: 0, arg4: 0, arg5: 5f);
                context.SetRandomMesh(triggerIds: new []{430500, 430501, 430502, 430503, 430504, 430505, 430506, 430507, 430508, 430509, 430510, 430511, 430512, 430513, 430514, 430515, 430516, 430517, 430518, 430519, 430520, 430521, 430522, 430523, 430524, 430525}, visible: true, meshCount: 26, arg4: 0, delay: 50);
                context.SetAgent(triggerIds: new []{28051, 28052}, visible: false);
                context.SetPortal(portalId: 12, visible: true, enabled: true, minimapVisible: false);
                context.SetMesh(triggerIds: new []{4012}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateQuit(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMakeFalse : TriggerState {
            internal StateMakeFalse(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{230500, 230501, 230502, 230503, 230504, 230505, 230506, 230507, 230508, 230509, 230510, 230511, 230512, 230513, 230514, 230515, 230516, 230517, 230518, 230519, 230520, 230521, 230522, 230523, 230524, 230525}, visible: false, arg3: 0, arg4: 0, arg5: 5f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateQuit(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateQuit : TriggerState {
            internal StateQuit(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
