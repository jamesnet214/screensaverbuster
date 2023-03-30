using Jamesnet.Wpf.Controls;
using ScreenSaverBuster.Forms.UI.Views;
using System.Windows;

namespace ScreenSaverBuster
{
    internal class App : JamesApplication
    {
        protected override Window CreateShell()
        {
            return new SaverWindow();
        }
    }
}
