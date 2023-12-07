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
    /// Interaction logic for Delete.xaml
    /// </summary>
    public partial class Delete : Page
    {
        test1Entities db = new test1Entities();
        public Delete()
        {
            InitializeComponent();
            DG.ItemsSource = db.user1.ToList();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            user1 u = new user1();
            u = db.user1.First(x => x.city == C_Txt.Text);
            db.user1.Remove(u);
            db.SaveChanges();
            MessageBox.Show("Deleted successfully");  
            DG.ItemsSource = db.user1.ToList();
        }
    }
}
