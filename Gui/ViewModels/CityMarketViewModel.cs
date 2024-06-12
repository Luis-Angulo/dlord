using Models;
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace Gui.ViewModels
{
    class CityMarketViewModel : ViewModelBase
    {
        public ObservableCollection<Product>? Products { get; set; }
        public string CityName { get; set; } = "[Cityname]";
        private Product? _SelectedProduct { get; set; }
        public Product SelectedProduct
        {
            get => _SelectedProduct;
            set
            {
                _SelectedProduct = value;
                OnPropertyChanged();
            }
        }
        public event PropertyChangedEventHandler? PropertyChanged;
        // TODO[Remove]: Default CTOR for devtests
        public CityMarketViewModel()
        {
            Products = new ObservableCollection<Product>();
            Products.Add(new Product { Name = "Cannabis", Amount = 5, CashValue = 40.00m });
            Products.Add(new Product { Name = "Shrooms", Amount = 5, CashValue = 60.01m });
            Products.Add(new Product { Name = "LSD", Amount = 5, CashValue = 150.01m });
            CityName = "Charlottesville Kentucky";
        }
    }
}
