﻿using System;
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
    /// Interaction logic for profile.xaml
    /// </summary>
    public partial class profile : Page
    {
        public profile(string name)
        {
            InitializeComponent();
            ll.Content = "Welcome "+name;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void name_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
