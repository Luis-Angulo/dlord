using Models;
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace Gui.ViewModels
{
    public interface ICityMarketViewModel
    {
        string CityName { get; set; }
        ObservableCollection<Product>? Products { get; set; }
        Product SelectedProduct { get; set; }

        event PropertyChangedEventHandler? PropertyChanged;
    }
}