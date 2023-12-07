using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace test
{
    /// <summary>
    /// Interaction logic for Admin.xaml
    /// </summary>
    public partial class Admin : Page
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Delete delete= new Delete();
            this.NavigationService.Navigate(delete);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Search search = new Search();
            this.NavigationService.Navigate(search);
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            update2 update2 = new update2();
            this.NavigationService.Navigate(update2);
        }
    }
}
