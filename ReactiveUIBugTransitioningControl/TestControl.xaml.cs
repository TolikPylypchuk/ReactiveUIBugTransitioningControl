using System.Reactive.Disposables;

using ReactiveUI;

namespace ReactiveUIBugTransitioningControl
{
    public partial class TestControl : ReactiveUserControl<TestViewModel>
    {
        public TestControl()
        {
            this.InitializeComponent();

            this.WhenActivated(disposables =>
            {
                this.OneWayBind(this.ViewModel, vm => vm.Test, v => v.TestTextBlock.Text)
                    ?.DisposeWith(disposables);
            });
        }
    }
}
