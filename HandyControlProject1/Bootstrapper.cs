using HandyControlProject1.Views;
using Prism.DryIoc;
using Prism.Ioc;
using System.Windows;

namespace HandyControlProject1
{
    public class Bootstrapper : PrismBootstrapper
    {
        protected override DependencyObject CreateShell()
        {
            return Container.Resolve<MainWindow>();
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {

        }
    }
}
