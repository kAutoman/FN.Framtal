using System.Windows.Input;
using FN.Framtal.Presentation._2004.Common;
using FN.Framtal.Presentation._2004.Navigation;

namespace FN.Framtal.Presentation._2004.Forms.RSK0101.ViewModels
{
    public class RSK0101_03ViewModel : ViewModelBase
    {
        public ICommand NavigatePage3Command { get; }

        public RSK0101_03ViewModel(INavigationService navigationService)
        {
            NavigatePage3Command = new NavigateCommand(navigationService);
        }
    }
}