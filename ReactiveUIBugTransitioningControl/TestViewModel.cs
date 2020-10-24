using ReactiveUI;

namespace ReactiveUIBugTransitioningControl
{
    public sealed class TestViewModel : ReactiveObject
    {
        private string test = "If you can see this, then it's all good";

        public string Test
        {
            get => this.test;
            set => this.RaiseAndSetIfChanged(ref this.test, value);
        }
    }
}
