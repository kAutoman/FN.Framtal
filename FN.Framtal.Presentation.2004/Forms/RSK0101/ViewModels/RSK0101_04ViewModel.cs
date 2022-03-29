using System.Windows.Input;
using FN.Framtal.Presentation._2004.Common;
using FN.Framtal.Presentation._2004.Navigation;

namespace FN.Framtal.Presentation._2004.Forms.RSK0101.ViewModels
{
    public class RSK0101_04ViewModel : ViewModelBase
    {
        public ICommand NavigatePage4Command { get; }

        public RSK0101_04ViewModel(INavigationService navigationService)
        {
            NavigatePage4Command = new NavigateCommand(navigationService);
        }
    }
}