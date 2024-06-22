using Gui.UserControls;
using Gui.ViewModels;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System.Windows;

namespace Gui
{
    public partial class App : Application
    {
        public static IHost? AppHost { get; private set; }
        public App()
        {
            // Init app services
            AppHost = Host.CreateDefaultBuilder().ConfigureServices((hostContext, services) =>
            {
                services.AddTransient<ICityMarketViewModel, CityMarketViewModel>();
                // services.AddSingleton<CityMarketControl>(services => new CityMarketControl(new CityMarketViewModel()));
                services.AddSingleton<CityMarketControl>();
                services.AddSingleton<MainWindow>();
            }).Build();
        }
        protected override async void OnStartup(StartupEventArgs e)
        {
            await AppHost!.StartAsync();
            AppHost.Services.GetRequiredService<MainWindow>().Show();
            base.OnStartup(e);
        }
        protected override async void OnExit(ExitEventArgs e)
        {
            await AppHost!.StopAsync();
            base.OnExit(e);
        }
    }

}
