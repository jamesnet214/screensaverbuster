using ScreenSaverBuster.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
