using Jamesnet.Wpf.Controls;
using Prism.Ioc;
using Prism.Modularity;
using ScreenSaverBuster.Automation.UI.Views;

namespace ScreenSaverBuster.Properties
{
    internal class ViewModules : IModule
    {
        public void OnInitialized(IContainerProvider containerProvider)
        {
        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterSingleton<IViewable, AutoContent>("AutoContent");
        }
    }
}
