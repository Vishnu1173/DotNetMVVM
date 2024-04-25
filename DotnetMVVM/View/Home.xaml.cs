using System.Windows;
using DotnetMVVM.ViewModel;

namespace DotnetMVVM.View
{
    /// <summary>
    /// Interaction logic for Home.xaml
    /// </summary>
    public partial class Home : Window
    {
        public Home()
        {
            InitializeComponent();
            this.DataContext = new HomeViewmodel();
        }
    }
}
