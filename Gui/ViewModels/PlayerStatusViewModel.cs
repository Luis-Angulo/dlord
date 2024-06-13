using Models;
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace Gui.ViewModels
{
    class PlayerStatusViewModel : ViewModelBase
    {
        public ObservableCollection<Product>? PlayerProducts { get; set; }
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
        public PlayerStatusViewModel()
        {
            PlayerProducts = new ObservableCollection<Product>();
            PlayerProducts.Add(new Product { Name = "Cannabis", Amount = 2, CashValue = 40.00m });
            PlayerProducts.Add(new Product { Name = "Shrooms", Amount = 2, CashValue = 60.01m });
            PlayerProducts.Add(new Product { Name = "LSD", Amount = 2, CashValue = 150.01m });
        }
    }
}
