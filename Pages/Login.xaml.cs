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

namespace GroupProject.Pages
{
    /// <summary>
    /// Logique d'interaction pour Login.xaml
    /// </summary>
    public partial class Login : UserControl
    {
        List<string> list = new List<string>();
        public Login()
        {
            InitializeComponent();
        }
        private void Submit_Button_Click(object sender, RoutedEventArgs e)
        {

            list = DatabaseManagement.LoginCommand(UserName.Text, Password.Password);
            //ErrorLabel.Content = "Connected Successfully ";

            if (list.Count() == 0)
            {
                ErrorLabel.Visibility = Visibility.Visible;
            }
            else
            {
                ErrorLabel.Visibility = Visibility.Collapsed;
                ErrorLabel.Visibility = Visibility.Visible; //just for debuging as to be removed then
                if (list[2] == "administrator")
                {
                    ErrorLabel.Content = "Admin to be loged";
                }
                if (list[2] == "executive")
                {
                    ErrorLabel.Content = "Exec to be loged";
                }
                if (list[2] == "purchasing assistant")
                {
                    ErrorLabel.Content = "purchasing assistant to be loged";
                }
                if (list[2] == "warehouse manager")
                {
                    ErrorLabel.Content = "warehouse manager to be loged";
                }
            }



            /*if(!Connection)
            {
                ErrorLabel.Visibility = Visibility.Visible;
            }*/
        }
    }
}
