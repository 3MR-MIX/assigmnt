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
    /// Interaction logic for update2.xaml
    /// </summary>
    public partial class update2 : Page
    {
        test1Entities db = new test1Entities();
        public update2()
        {
            InitializeComponent();
        }

        private void update_name_Click(object sender, RoutedEventArgs e)
        {
            user1 u = new user1();
            u = db.user1.FirstOrDefault(x => x.username == user_name.Text);
            if (u != null)
            {
                if (new_name.Text == confirm_new_name.Text)
                {
                    u.username = new_name.Text;
                }
                db.SaveChanges();
                MessageBox.Show("Error Happiens");
                login l = new login();
                this.NavigationService.Navigate(l);
               
            }

        }
    }
}
