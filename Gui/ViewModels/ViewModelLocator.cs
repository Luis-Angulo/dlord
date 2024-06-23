using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace Gui.ViewModels
{
    public class ViewModelLocator
    {
        private static IHost _AppHost;

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
        
        private static void InitAppHost()
        {
            _AppHost = Host.CreateDefaultBuilder().ConfigureServices((hostContext, services) =>
            {
                services.AddTransient<ICityMarketViewModel, CityMarketViewModel>();
                services.AddSingleton<NewsPanelViewModel>();
            }).Build();
        }

        public static NewsPanelViewModel NewsPanelViewModel { get { return AppHost!.Services.GetRequiredService<NewsPanelViewModel>(); } }
    }
}
