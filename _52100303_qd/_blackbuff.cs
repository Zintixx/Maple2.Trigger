namespace Maple2.Trigger._52100303_qd {
    public static class _blackbuff {
        public class StateStart : TriggerState {
            internal StateStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {12000607}, arg2: 0);
                context.SetInteractObject(arg1: new[] {12000607}, arg2: 1);
            }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {801})) {
                    return new StateCheckObject(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateStart(context);
                }

                if (context.UserDetected(arg1: new[] {801})) {
                    return new StateCheckObject(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCheckObject : TriggerState {
            internal StateCheckObject(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.ObjectInteracted(arg1: new[] {12000606}, arg2: 0)) {
                    return new State오브젝트재Creation(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State오브젝트재Creation : TriggerState {
            internal State오브젝트재Creation(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.SetInteractObject(arg1: new[] {12000606}, arg2: 1);
                    return new StateCheckObject(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}