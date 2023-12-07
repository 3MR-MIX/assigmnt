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
    /// Interaction logic for sign_up.xaml
    /// </summary>
    public partial class sign_up : Page
    {
        test1Entities db = new test1Entities();
        public sign_up()
        {
            InitializeComponent();
        }
        bool Isvalid(string pass)
        {
            bool upper, lower, num, sp;
            upper = lower = num = sp = false;
            string spc = "!@#%^&*";
            foreach (char c in pass)
            {
                if (c >= 'A' && c <= 'Z')
                {
                    upper = true;
                }
                if (c >= 'a' && c <= 'z')
                {
                    lower = true;
                }
                if (c >= '0' && c <= '9')
                {
                    num = true;
                }
                if (spc.Contains(c))
                {
                    sp = true;
                }
            }
            return upper && lower && num && sp;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            user1 user1 = new user1();

            if (pass2.Text.Length < 8)
            {
                user1 u = new user1();
                u.username = user2.Text;
                u.pass = pass2.Text;
                u.gender = compo2.Text;
                u.age = age1.Text;
                u.city = compo1.Text;
                u.phonenum = num2.Text;
                db.user1.Add(u);
                db.SaveChanges();
                login lo = new login();
                MessageBox.Show("Enterd pass more than 8");
            }

            if (pass2.Text.Length == 20)
            {
                user1 u = new user1();
                u.username = user2.Text;
                u.pass = pass2.Text;
                u.gender = compo2.Text;
                u.age = age1.Text;
                u.city = compo1.Text;
                u.phonenum = num2.Text;
                db.user1.Add(u);
                db.SaveChanges();
                MessageBox.Show("Signed in");
                login lo = new login();
                this.NavigationService.Navigate(lo);

            }


            if (Isvalid(pass2.Text))
            {
                int age = int.Parse(age1.Text);
                if (age >= 18 && age <= 60)
                {
                    if (num2.Text.Length == 11)
                    {
                        user1 u = new user1();
                        u.username = user2.Text;
                        u.pass = pass2.Text;
                        u.gender = compo2.Text;
                        u.age = age1.Text;
                        u.city = compo1.Text;
                        u.phonenum = num2.Text;
                        db.user1.Add(u);
                        db.SaveChanges();
                        MessageBox.Show("Signed in");
                        login lo = new login();
                        this.NavigationService.Navigate(lo);


                    }
                    else
                    {
                        MessageBox.Show("Phone num lentgh must be equal 11");
                    }
                }
                else
                {
                    MessageBox.Show("Age must be between 18 and 60");
                }
            }
            else
            {
                MessageBox.Show("Pass must contain  upper , lower ,nums ,special chars");
            }




        
        }

        private void Sign_in_Click(object sender, RoutedEventArgs e)
        {

        }

        private void compo1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
