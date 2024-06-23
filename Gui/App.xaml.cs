using Microsoft.Extensions.Hosting;
using System.Windows;

namespace Gui
{
    public partial class App : Application
    {
        public static IHost? AppHost { get; private set; }
        public App()
        {
            // Moved DI setup to the VM locator because it doesn't work here
            // Init app services
            //AppHost = Host.CreateDefaultBuilder().ConfigureServices((hostContext, services) =>
            //{
            //    services.AddTransient<ICityMarketViewModel, CityMarketViewModel>();
            //    // services.AddSingleton<CityMarketControl>(services => new CityMarketControl(new CityMarketViewModel()));
            //    services.AddSingleton<CityMarketControl>();
            //    services.AddSingleton<MainWindow>();
            //}).Build();
        }
        protected override async void OnExit(ExitEventArgs e)
        {
            await ViewModels.ViewModelLocator.AppHost!.StopAsync();
            base.OnExit(e);
        }

        private void Application_Startup(object sender, StartupEventArgs e)
        {
            ViewModels.ViewModelLocator.AppHost!.Start();
            var mainWindow = new MainWindow();
            Current.MainWindow = mainWindow;
            Current.MainWindow.Show();
            //base.OnStartup(e); // Causes many new MainWindow objs to open, recursive call?
        }
    }

}
