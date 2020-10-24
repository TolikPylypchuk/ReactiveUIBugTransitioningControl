using System.Reactive.Disposables;

using ReactiveUI;

namespace ReactiveUIBugTransitioningControl
{
    public partial class MainWindow : ReactiveWindow<MainViewModel>
    {
        public MainWindow()
        {
            this.InitializeComponent();

            this.WhenActivated(disposables =>
            {
                this.Bind(this.ViewModel, vm => vm.TestViewModel, v => v.TestHost.ViewModel)
                    ?.DisposeWith(disposables);
            });
        }
    }
}
