using Jamesnet.Wpf.Controls;
using System.Windows;

namespace ScreenSaverBuster.Automation.UI.Views
{
    public class AutoContent : JamesContent
    {
        static AutoContent()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(AutoContent), new FrameworkPropertyMetadata(typeof(AutoContent)));
        }
    }
}
