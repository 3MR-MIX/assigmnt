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
    /// Interaction logic for search.xaml
    /// </summary>
    public partial class search : Page
    {
        Main_projectEntities1 db = new Main_projectEntities1();
        public search()
        {
            InitializeComponent();
            data_grid.ItemsSource=db.Userr.ToList();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Userr user = new Userr();
            user = db.Userr.FirstOrDefault(x => x.user_city == t1.Text);
            data_grid.ItemsSource = db.Userr.ToList();
        }
    }
}
