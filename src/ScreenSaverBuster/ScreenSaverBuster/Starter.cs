using ScreenSaverBuster.Properties;
using System;

namespace ScreenSaverBuster
{
    internal class Starter
    {
        [STAThread]
        private static void Main(string[] args)
        {
            new App()
                .AddWireDataContext<WireDataContext>()
                .AddInversionModule<ViewModules>()
                .Run();
        }
    }
}
