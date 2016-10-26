using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;

namespace PrismUnityApp2.ViewModels
{
    class MasterDetailViewModel :BindableBase, INavigationAware
    {
        private INavigationService _navigationService;
        public MasterDetailViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;
            NavigateCommand = new DelegateCommand<string>(NavigatePage);
        }

        public DelegateCommand<string> NavigateCommand { get; set; }
        private void NavigatePage(string name)
        {
            _navigationService.NavigateAsync($"Navigation/MainPage/{name}");
        }

        public void OnNavigatedFrom(NavigationParameters parameters)
        {
           
        }

        public void OnNavigatedTo(NavigationParameters parameters)
        {
           
        }
    }
}
