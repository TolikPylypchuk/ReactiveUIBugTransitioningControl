using System.Reflection;
using System.Windows;

using ReactiveUI;

using Splat;

namespace ReactiveUIBugTransitioningControl
{
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            Locator.CurrentMutable.InitializeReactiveUI();
            Locator.CurrentMutable.RegisterViewsForViewModels(Assembly.GetExecutingAssembly());

            var mainWindow = new MainWindow
            {
                ViewModel = new MainViewModel()
            };

            this.MainWindow = mainWindow;
            mainWindow.Show();

            base.OnStartup(e);
        }
    }
}
