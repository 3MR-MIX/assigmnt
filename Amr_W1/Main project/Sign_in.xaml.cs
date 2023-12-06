using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
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
        Main_projectEntities1 db = new Main_projectEntities1();
        public Sign_in()
        {
            InitializeComponent();
        }

        private void Login_Click(object sender, RoutedEventArgs e)
        {
            foreach (var x in db.Userr)
            {
                if (x.userr_name == box1.Text && x.user_password == pass.Text)
                {
                    string name = box1.Text;
                    MessageBox.Show("Signed in");
                    Profile profile = new Profile(name);
                    this.NavigationService.Navigate(profile);
                }
                else if (x.userr_name != box1.Text || x.user_password != pass.Text)
                {
                    MessageBox.Show("Invalid data");
                }
                else
                {
                    MessageBox.Show("Something is wrong");
                }
                break;
            }
        }

        private void Sign_up_Click(object sender, RoutedEventArgs e)
        {
            Sign_Up sign = new Sign_Up();
            NavigationService.Navigate(sign);
        }

        private void forget_pass_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
