using System.Windows.Input;
using FN.Framtal.Presentation._2004.Common;
using FN.Framtal.Presentation._2004.Navigation;

namespace FN.Framtal.Presentation._2004.Forms.RSK0101.ViewModels
{
    public class RSK0101_02ViewModel : ViewModelBase
    {
        public ICommand NavigatePage2Command { get; }

        public RSK0101_02ViewModel(INavigationService navigationService)
        {
            NavigatePage2Command = new NavigateCommand(navigationService);
        }
    }
}