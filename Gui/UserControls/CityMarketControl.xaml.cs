using Gui.ViewModels;
using System.Windows.Controls;

namespace Gui.UserControls
{   
    public partial class CityMarketControl : UserControl
    {
        public CityMarketControl()
        {
            // TODO[Remove]: Hardcoded, should be injected
            DataContext = new CityMarketViewModel();
            InitializeComponent();
        }

        // TODO[Impl]: Implement item picking logic, trend column value generation
    }
}
