using Jamesnet.Wpf.Global.Location;
using ScreenSaverBuster.Automation.Local.ViewModels;
using ScreenSaverBuster.Automation.UI.Views;
using ScreenSaverBuster.Forms.Local.ViewModels;
using ScreenSaverBuster.Forms.UI.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
