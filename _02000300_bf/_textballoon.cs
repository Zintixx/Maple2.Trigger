namespace Maple2.Trigger._02000300_bf {
    public static class _textballoon {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.MonsterInCombat(arg1: new[] {1099})) {
                    return new StateRandom대화(context);
                }

                if (context.MonsterDead(arg1: new[] {1099})) {
                    return new StateEnd대화(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateRandom대화 : TriggerState {
            internal StateRandom대화(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.RandomCondition(arg1: 25f)) {
                    return new State20초(context);
                }

                if (context.RandomCondition(arg1: 25f)) {
                    return new State25초(context);
                }

                if (context.RandomCondition(arg1: 25f)) {
                    return new State30초(context);
                }

                if (context.RandomCondition(arg1: 25f)) {
                    return new State35초(context);
                }

                if (context.MonsterDead(arg1: new[] {1099})) {
                    return new StateEnd대화(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State20초 : TriggerState {
            internal State20초(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "20", arg2: 20);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "20")) {
                    return new State대화(context);
                }

                if (context.MonsterDead(arg1: new[] {1099})) {
                    return new StateEnd대화(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State25초 : TriggerState {
            internal State25초(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "25", arg2: 25);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "25")) {
                    return new State대화(context);
                }

                if (context.MonsterDead(arg1: new[] {1099})) {
                    return new StateEnd대화(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State30초 : TriggerState {
            internal State30초(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "30", arg2: 30);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "30")) {
                    return new State대화(context);
                }

                if (context.MonsterDead(arg1: new[] {1099})) {
                    return new StateEnd대화(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State35초 : TriggerState {
            internal State35초(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "35", arg2: 35);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "35")) {
                    return new State대화(context);
                }

                if (context.MonsterDead(arg1: new[] {1099})) {
                    return new StateEnd대화(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State대화 : TriggerState {
            internal State대화(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.RandomCondition(arg1: 25f)) {
                    return new State대사1(context);
                }

                if (context.RandomCondition(arg1: 25f)) {
                    return new State대사2(context);
                }

                if (context.RandomCondition(arg1: 25f)) {
                    return new State대사3(context);
                }

                if (context.RandomCondition(arg1: 25f)) {
                    return new State대사4(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State대사1 : TriggerState {
            internal State대사1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "2", arg2: 2);
                context.SetConversation(arg1: 1, arg2: 1002, arg3: "$02000300_BF__TEXTBALLOON__0$", arg4: 2, arg5: 0);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "2")) {
                    return new StateWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State대사2 : TriggerState {
            internal State대사2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "2", arg2: 2);
                context.SetConversation(arg1: 1, arg2: 1003, arg3: "$02000300_BF__TEXTBALLOON__1$", arg4: 2);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "2")) {
                    return new StateWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State대사3 : TriggerState {
            internal State대사3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "2", arg2: 2);
                context.SetConversation(arg1: 1, arg2: 1003, arg3: "$02000300_BF__TEXTBALLOON__2$", arg4: 2);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "2")) {
                    return new StateWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State대사4 : TriggerState {
            internal State대사4(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "2", arg2: 2);
                context.SetConversation(arg1: 1, arg2: 1004, arg3: "$02000300_BF__TEXTBALLOON__3$", arg4: 2);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "2")) {
                    return new StateWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnd대화 : TriggerState {
            internal StateEnd대화(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "10", arg2: 10);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "10")) {
                    context.SetConversation(arg1: 1, arg2: 1001, arg3: "$02000300_BF__TEXTBALLOON__4$", arg4: 3, arg5: 0);
                    context.SetConversation(arg1: 1, arg2: 1003, arg3: "$02000300_BF__TEXTBALLOON__5$", arg4: 2, arg5: 2);
                    context.SetConversation(arg1: 1, arg2: 1002, arg3: "$02000300_BF__TEXTBALLOON__6$", arg4: 2, arg5: 4);
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnd : TriggerState {
            internal StateEnd(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}