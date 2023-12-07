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

namespace test
{
    /// <summary>
    /// Interaction logic for forget_pass.xaml
    /// </summary>
    public partial class forget_pass : Page
    {
        test1Entities db =  new test1Entities();
        public forget_pass()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
           user1 u  = new user1();
            u = db.user1.FirstOrDefault(x => x.phonenum == phone_forget.Text);
            if (u != null)
            {
                if (new_pass.Text == con_pass.Text) 
                {
                    u.pass = new_pass.Text;
                }
                db.user1.AddOrUpdate(u);
                db.SaveChanges();
                MessageBox.Show("Updatet");
                login l = new login();
                this.NavigationService.Navigate(l);
            }
            else
            {
                MessageBox.Show("Error Happiens");
            }
          
        }


        
    }
}
