using ReactiveUI;

namespace ReactiveUIBugTransitioningControl
{
    public sealed class MainViewModel : ReactiveObject
    {
        private TestViewModel testViewModel = new TestViewModel();

        public TestViewModel TestViewModel
        {
            get => this.testViewModel;
            set => this.RaiseAndSetIfChanged(ref this.testViewModel, value);
        }
    }
}
