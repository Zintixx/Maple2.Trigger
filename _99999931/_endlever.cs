namespace Maple2.Trigger._99999931 {
    public static class _endlever {
        public class State게임종료 : TriggerState {
            internal State게임종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {211, 212}, arg2: true);
                context.SetMesh(arg1: new[] {551, 552}, arg2: false);
                context.SetInteractObject(arg1: new[] {10000216}, arg2: 1);
            }

            public override TriggerState Execute() {
                if (context.ObjectInteracted(arg1: new[] {10000216}, arg2: 0)) {
                    return new StateEnd안내(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnd안내 : TriggerState {
            internal StateEnd안내(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 3);
                context.SetEventUI(arg1: 5, arg3: 3000);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    return new State문열기(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State문열기 : TriggerState {
            internal State문열기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "2", arg2: 7);
                context.SetMesh(arg1: new[] {211, 212}, arg2: false);
                context.SetMesh(arg1: new[] {551, 552}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "2")) {
                    return new State문닫기(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State문닫기 : TriggerState {
            internal State문닫기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "3", arg2: 3);
                context.SetMesh(arg1: new[] {211, 212}, arg2: true);
                context.SetMesh(arg1: new[] {551, 552}, arg2: false);
                context.SetMesh(arg1: new[] {201, 202, 203, 204, 205, 206, 207, 208}, arg2: true);
                context.SetPortal(arg1: 101, arg2: false, arg3: true);
                context.SetPortal(arg1: 102, arg2: false, arg3: true);
                context.SetPortal(arg1: 103, arg2: false, arg3: true);
                context.SetPortal(arg1: 104, arg2: false, arg3: true);
                context.SetPortal(arg1: 115, arg2: false, arg3: true);
                context.SetPortal(arg1: 116, arg2: false, arg3: true);
                context.SetPortal(arg1: 117, arg2: false, arg3: true);
                context.SetPortal(arg1: 118, arg2: false, arg3: true);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "3")) {
                    return new State게임종료(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}