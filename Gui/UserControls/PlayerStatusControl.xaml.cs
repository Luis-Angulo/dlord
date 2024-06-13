using Gui.ViewModels;
using System.Windows.Controls;

namespace Gui.UserControls
{
    public partial class PlayerStatusControl : UserControl
    {
        public PlayerStatusControl()
        {
            DataContext = new PlayerStatusViewModel();
            InitializeComponent();
        }
    }
}
