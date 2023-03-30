using Jamesnet.Wpf.Controls;
using System.Windows;

namespace ScreenSaverBuster.Forms.UI.Views
{
    public class SaverWindow : JamesWindow
    {
        static SaverWindow()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(SaverWindow), new FrameworkPropertyMetadata(typeof(SaverWindow)));
        }
    }
}
