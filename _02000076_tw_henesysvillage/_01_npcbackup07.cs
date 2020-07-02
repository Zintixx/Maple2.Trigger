namespace Maple2.Trigger._02000076_tw_henesysvillage {
    public static class _01_npcbackup07 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.QuestUserDetected(arg1: new[] {1001}, arg2: new[] {10002041}, arg3: new byte[] {1})) {
                    return new State지원군Creation(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State지원군Creation : TriggerState {
            internal State지원군Creation(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {107}, arg2: false);
                context.MoveNpc(arg1: 107, arg2: "MS2PatrolData_17");
            }

            public override TriggerState Execute() {
                if (context.NpcDetected(arg1: 3007, arg2: new[] {107})) {
                    return new State지원군이동(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State지원군이동 : TriggerState {
            internal State지원군이동(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 104, arg3: "$02000076_TW_HenesysVillage__01_NPCBACKUP07__0$", arg4: 1);
                context.MoveNpc(arg1: 107, arg2: "MS2PatrolData_107");
            }

            public override TriggerState Execute() {
                if (context.NpcDetected(arg1: 2001, arg2: new[] {107})) {
                    return new State지원군소멸(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State지원군소멸 : TriggerState {
            internal State지원군소멸(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {107});
                context.SetTimer(arg1: "3", arg2: 90);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "3")) {
                    return new StateWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}