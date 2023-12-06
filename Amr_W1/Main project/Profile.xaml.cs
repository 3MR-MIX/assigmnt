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
    /// Interaction logic for Profile.xaml
    /// </summary>
    public partial class Profile : Page
    {
        Main_projectEntities1 db = new Main_projectEntities1();
        public Profile(string name)
        {
            InitializeComponent();
            data_grid.ItemsSource = db.Userr.Where(x => x.userr_name.Contains(name)).ToString();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
