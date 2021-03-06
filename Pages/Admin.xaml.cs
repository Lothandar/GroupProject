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

namespace GroupProject.Pages
{
    /// <summary>
    /// Logique d'interaction pour Admin.xaml
    /// </summary>
    public partial class Admin : UserControl
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void Logout_button_Click(object sender, RoutedEventArgs e)
        {
            Switcher.Switch(new Index());
        }

        private void Executive_Button_Click(object sender, RoutedEventArgs e)
        {
            Switcher.Switch(new Exec());
        }
    }
}
