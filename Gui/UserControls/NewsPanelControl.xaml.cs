using Gui.ViewModels;
using System.Windows.Controls;

namespace Gui.UserControls
{   
    public partial class NewsPanelControl : UserControl
    {
        public NewsPanelControl()
        {
            InitializeComponent();
        }
        public NewsPanelControl(NewsPanelViewModel vm)
        {
            DataContext = vm;
            InitializeComponent();
        }
    }
}
