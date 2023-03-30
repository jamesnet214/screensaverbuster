using Jamesnet.Wpf.Global.Location;
using ScreenSaverBuster.Automation.Local.ViewModels;
using ScreenSaverBuster.Automation.UI.Views;
using ScreenSaverBuster.Forms.Local.ViewModels;
using ScreenSaverBuster.Forms.UI.Views;

namespace ScreenSaverBuster.Properties
{
    internal class WireDataContext : ViewModelLocationScenario
    {
        protected override void Match(ViewModelLocatorCollection items)
        {
            items.Register<SaverWindow, SaverViewModel>();
            items.Register<AutoContent, AutoContentViewModel>();
        }
    }
}
