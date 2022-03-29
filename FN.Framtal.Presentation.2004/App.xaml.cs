using Microsoft.Extensions.DependencyInjection;
using System;
using System.Windows;
using FN.Framtal.Presentation._2004.Forms.RSK0101.ViewModels;
using FN.Framtal.Presentation._2004.Navigation;

namespace FN.Framtal.Presentation._2004
{
    public partial class App : Application
    {
        private readonly IServiceProvider _serviceProvider;

        public App()
        {
            IServiceCollection services = new ServiceCollection();

            services.AddSingleton<NavigationStore>();

            services.AddSingleton(CreatePage1NavigationService);

            services.AddTransient(s => new RSK0101_01ViewModel(CreatePage1NavigationService(s)));
            services.AddTransient(s => new RSK0101_02ViewModel(CreatePage2NavigationService(s)));
            services.AddTransient(s => new RSK0101_03ViewModel(CreatePage3NavigationService(s)));
            services.AddTransient(s => new RSK0101_04ViewModel(CreatePage4NavigationService(s)));
            services.AddTransient(CreateNavigationBarViewModel);
            services.AddSingleton<MainViewModel>();

            services.AddSingleton(s => new MainWindow
            {
                DataContext = s.GetRequiredService<MainViewModel>()
            });

            _serviceProvider = services.BuildServiceProvider();
        }

        protected override void OnStartup(StartupEventArgs e)
        {
            var initialNavigationService = _serviceProvider.GetRequiredService<INavigationService>();
            initialNavigationService.Navigate();

            MainWindow = _serviceProvider.GetRequiredService<MainWindow>();
            MainWindow.Show();

            base.OnStartup(e);
        }

        private static INavigationService CreatePage1NavigationService(IServiceProvider serviceProvider)
        {
            return new LayoutNavigationService<RSK0101_01ViewModel>(
                serviceProvider.GetRequiredService<NavigationStore>(),
                serviceProvider.GetRequiredService<RSK0101_01ViewModel>,
                serviceProvider.GetRequiredService<NavigationBarViewModel>);
        }

        private static INavigationService CreatePage2NavigationService(IServiceProvider serviceProvider)
        {
            return new LayoutNavigationService<RSK0101_02ViewModel>(
                serviceProvider.GetRequiredService<NavigationStore>(),
                serviceProvider.GetRequiredService<RSK0101_02ViewModel>,
                serviceProvider.GetRequiredService<NavigationBarViewModel>);
        }

        private static INavigationService CreatePage3NavigationService(IServiceProvider serviceProvider)
        {
            return new LayoutNavigationService<RSK0101_03ViewModel>(
                serviceProvider.GetRequiredService<NavigationStore>(),
                serviceProvider.GetRequiredService<RSK0101_03ViewModel>,
                serviceProvider.GetRequiredService<NavigationBarViewModel>);
        }

        private static INavigationService CreatePage4NavigationService(IServiceProvider serviceProvider)
        {
            return new LayoutNavigationService<RSK0101_04ViewModel>(
                serviceProvider.GetRequiredService<NavigationStore>(),
                serviceProvider.GetRequiredService<RSK0101_04ViewModel>,
                serviceProvider.GetRequiredService<NavigationBarViewModel>);
        }

        private static NavigationBarViewModel CreateNavigationBarViewModel(IServiceProvider serviceProvider)
        {
            return new NavigationBarViewModel(
                CreatePage1NavigationService(serviceProvider),
                CreatePage2NavigationService(serviceProvider),
                CreatePage3NavigationService(serviceProvider),
                CreatePage4NavigationService(serviceProvider));
        }
    }
}
