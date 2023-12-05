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

namespace Main_project   
{
    /// <summary>
    /// Interaction logic for Sign_in.xaml
    /// </summary>
    public partial class Sign_in : Page
    {
        Main_projectEntities db = new Main_projectEntities();
        public Sign_in()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
             
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

        }
    }
}
