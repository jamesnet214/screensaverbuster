using Jamesnet.Wpf.Controls;
using Jamesnet.Wpf.Mvvm;
using Prism.Ioc;
using Prism.Regions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenSaverBuster.Forms.Local.ViewModels
{
    public partial class SaverViewModel : ObservableBase, IViewLoadable
    {
        private readonly IContainerProvider _containerProvider;
        private readonly IRegionManager _regionManager;

        public SaverViewModel(IContainerProvider containerProvider, IRegionManager regionManager)
        {
            _containerProvider = containerProvider;
            _regionManager = regionManager;
        }

        public void OnLoaded(IViewable smartWindow)
        {
            IViewable autoContent = _containerProvider.Resolve<IViewable>("AutoContent");
            IRegion mainRegion = _regionManager.Regions["MainRegion"];

            if (!mainRegion.Views.Contains(autoContent))
            {
                mainRegion.Add(autoContent);
            }
            mainRegion.Activate(autoContent);
        }
    }
}
