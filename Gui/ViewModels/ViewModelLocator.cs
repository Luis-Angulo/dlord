using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace Gui.ViewModels
{
    public class ViewModelLocator
    {
        // Every member must be static as to be accessible from App.xaml.cs's statics
        // Since we only need one Host (DI container) and one ServiceLocator instance, this isn't a problem
        private static IHost _AppHost;
        // Handrolled singleton accessor
        public static IHost AppHost
        {
            get
            {
                if (_AppHost == null)
                {
                    InitAppHost();
                }
                return _AppHost;
            }
            private set { _AppHost = value; }
        }
        // Configure injector here
        private static void InitAppHost()
        {
            _AppHost = Host.CreateDefaultBuilder().ConfigureServices((hostContext, services) =>
            {
                services.AddTransient<ICityMarketViewModel, CityMarketViewModel>();
                services.AddSingleton<NewsPanelViewModel>();
            }).Build();
        }
        // All VMs MUST be fetched from the Host container
        public static NewsPanelViewModel NewsPanelViewModel { get { return AppHost!.Services.GetRequiredService<NewsPanelViewModel>(); } }
    }
}
