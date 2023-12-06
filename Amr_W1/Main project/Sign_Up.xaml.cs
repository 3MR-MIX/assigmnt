using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
    /// Interaction logic for Sign_Up.xaml
    /// </summary>
    public partial class Sign_Up : Page
    {
        Main_projectEntities1 db = new Main_projectEntities1();
        public Sign_Up()
        {
            InitializeComponent();
        }


        private void Sign_in_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Userr userr = new Userr();
                if (compo1.SelectedIndex == 0 && compo2.SelectedIndex == 0)
                {
                    userr.userr_name = user2.Text;
                    userr.user_password = pass2.Text;
                    userr.user_age = int.Parse(age1.Text);
                    userr.user_number = int.Parse(num2.Text);
                    db.Userr.Add(userr);
                    db.SaveChanges();
                    string name = user2.Text;
                    Profile profile = new Profile(name);
                    this.NavigationService.Navigate(profile);
                    MessageBox.Show("Hello in my broject");
                    
                }
                else if (compo1.SelectedIndex == 1 && compo2.SelectedIndex == 1)
                {
                    if (Regex.IsMatch(pass2.Text, @"!@#{}]#$%"))
                    {
                        userr.userr_name = user2.Text;
                        userr.user_password = pass2.Text;
                        userr.user_age = int.Parse(age1.Text);
                        userr.user_number = int.Parse(num2.Text);
                        db.Userr.Add(userr);
                        db.SaveChanges();
                        string name = user2.Text;
                        Profile profile = new Profile(name);
                        this.NavigationService.Navigate(profile);
                        MessageBox.Show("Hello in my broject");
                    }
                    
                    

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void pass2_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}


