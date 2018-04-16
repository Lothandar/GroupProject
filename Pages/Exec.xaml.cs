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
    /// Logique d'interaction pour Exec.xaml
    /// </summary>
    public partial class Exec : UserControl
    {
        SupplierItems supp = new SupplierItems();
        public Exec()
        {
            InitializeComponent();
        }
        private void UserControl_Initialized(object sender, EventArgs e)
        {
            
            SupplierListBox.Items.Add("Pick a Supplier");
            
            List<string>[] list = DatabaseManagement.SelectQuery("Select supplierName from sql2231281.supplier");
            if (list.Count() == 0)
            {
                SupplierListBox.Items.Add("No supplier in the database");
            }
            else
            {
                foreach (List<string> items in list)
                {
                    foreach (string item in items)
                    {
                        SupplierListBox.Items.Add(item);
                    }
                }
                //SupplierListBox.Items.Add(list.Count());
            }
            SupplierListBox.SelectedItem = "Pick a Supplier";
            
        }

        private void Admin_Button_Click(object sender, RoutedEventArgs e)
        {
            Switcher.Switch(new Admin());
        }

        private void Logout_Button_Click(object sender, RoutedEventArgs e)
        {
            Switcher.Switch(new Index());
        }

        private void SupplierListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                if (SupplierListBox.SelectedItem.ToString() != "" && SupplierListBox.SelectedItem.ToString() != "Pick a Supplier")
                {
                    string SelectedSupplier = SupplierListBox.SelectedItem.ToString();
                    string query = ("Select * from sql2231281.supplier WHERE supplierName ='" + SelectedSupplier + "'");
                    List<string>[] supplierList = DatabaseManagement.SelectQuery(query);
                    SupplierData.ItemsSource = supp.LoadCollectionData();
                }
            }
            catch(Exception ex)
            {

            }
        }
    }
    public class SupplierItems
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public int DeliveryTime { get; set; }

        public List<SupplierItems> LoadCollectionData()
        {
            List<SupplierItems> SupplierItems = new List<SupplierItems>();
            SupplierItems.Add(new SupplierItems()
            {
                ID = 101,
                Name = "Mahesh Chand",
            });


            return SupplierItems;
        }
    }
}