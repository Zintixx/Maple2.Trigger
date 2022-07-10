namespace Maple2.Trigger._02000498_bf {
    public static class _debuff_05 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{106})) {
                    return new StateBuff(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBuff : TriggerState {
            internal StateBuff(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "3600", seconds: 3600);
                context.AddBuff(boxIds: new []{106}, skillId: 70000071, level: 5, arg4: false, arg5: false);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "3600")) {
                    return new StateWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}
