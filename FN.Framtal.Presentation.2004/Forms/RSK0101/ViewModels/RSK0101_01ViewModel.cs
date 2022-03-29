using System.Windows.Input;
using FN.Framtal.Presentation._2004.Common;
using FN.Framtal.Presentation._2004.Navigation;

namespace FN.Framtal.Presentation._2004.Forms.RSK0101.ViewModels
{
    public class RSK0101_01ViewModel : ViewModelBase
    {
        public ICommand NavigatePage1Command { get; }

        public RSK0101_01ViewModel(INavigationService navigationService)
        {
            NavigatePage1Command = new NavigateCommand(navigationService);
        }
    }
}