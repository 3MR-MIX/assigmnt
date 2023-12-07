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
    /// Interaction logic for login.xaml
    /// </summary>
    public partial class login : Page
    {
        test1Entities db = new test1Entities();
        user1 u = new user1();
        public login()
        {
            InitializeComponent();
        }

        private void Login_Click(object sender, RoutedEventArgs e)
        {
            u = db.user1.FirstOrDefault(x => x.username == box1.Text && x.pass == pass.Text);
            if(u != null)
            {
                string name = box1.Text;
                MessageBox.Show("Login succ");
                profile p   = new profile(name);
                this.NavigationService.Navigate(p);
                p.name.Text = u.username;
                p.pass.Text = u.pass;
            }
            else
            {
                MessageBox.Show("check your username or password");
            }

        }

        private void forget_pass_Click(object sender, RoutedEventArgs e)
        {
            forget_pass f = new forget_pass();
            this.NavigationService.Navigate(f);
        }

        private void Sign_up_Click(object sender, RoutedEventArgs e)
        {
            sign_up sign_Up = new sign_up();
            NavigationService.Navigate(sign_Up);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Search s = new Search();    
            this.NavigationService.Navigate(s);
        }

        private void Del_Butt_Click(object sender, RoutedEventArgs e)
        {
            Delete deletep = new Delete();
            this.NavigationService.Navigate(deletep);
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Admin admin = new Admin();
            this.NavigationService.Navigate(admin);
        }

        private void box1_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
