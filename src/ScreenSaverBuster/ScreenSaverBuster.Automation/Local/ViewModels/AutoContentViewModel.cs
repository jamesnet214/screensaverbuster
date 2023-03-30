using Jamesnet.Wpf.Controls;
using Jamesnet.Wpf.Mvvm;
using System;
using System.Runtime.InteropServices;
using System.Windows.Threading;

namespace ScreenSaverBuster.Automation.Local.ViewModels
{
    public partial class AutoContentViewModel : ObservableBase, IViewLoadable
    {
        [DllImport("user32.dll")]
        static extern bool SetCursorPos(int X, int Y);

        private DispatcherTimer _timer;
        private int _toggle;

        public AutoContentViewModel()
        {
        }

        public void OnLoaded(IViewable smartWindow)
        {
            _timer = new DispatcherTimer();
            _timer.Interval = TimeSpan.FromMinutes(1);
            _timer.Tick += OnTimerTick;
            _timer.Start();
        }

        private void OnTimerTick(object sender, EventArgs e)
        {
            _toggle = (_toggle + 1) % 2;
            int x = System.Windows.Forms.Cursor.Position.X + (_toggle == 0 ? 1 : -1);
            int y = System.Windows.Forms.Cursor.Position.Y;

            SetCursorPos(x, y);
        }
    }
}
