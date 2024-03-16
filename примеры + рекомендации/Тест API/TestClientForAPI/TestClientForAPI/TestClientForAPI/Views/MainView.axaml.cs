using Avalonia.Controls;
using TestClientForAPI.ViewModels;

namespace TestClientForAPI.Views
{
    public partial class MainView : UserControl
    {
        public MainView()
        {
            InitializeComponent();
            DataContext = new MainViewModel();
        }
    }
}