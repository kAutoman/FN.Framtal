using System.Windows.Input;
using FN.Framtal.Presentation._2004.Common;

namespace FN.Framtal.Presentation._2004.Navigation
{
    public class NavigationBarViewModel : ViewModelBase
    {
        public ICommand NavigatePage1Command { get; }
        public ICommand NavigatePage2Command { get; }
        public ICommand NavigatePage3Command { get; }
        public ICommand NavigatePage4Command { get; }

        public NavigationBarViewModel(
            INavigationService page1NavigationService,
            INavigationService page2NavigationService,
            INavigationService page3NavigationService,
            INavigationService page4NavigationService)
        {
            NavigatePage1Command = new NavigateCommand(page1NavigationService);
            NavigatePage2Command = new NavigateCommand(page2NavigationService);
            NavigatePage3Command = new NavigateCommand(page3NavigationService);
            NavigatePage4Command = new NavigateCommand(page4NavigationService);
        }
    }
}