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
        
        public Exec()
        {
            InitializeComponent();
        }
        private void UserControl_Initialized(object sender, EventArgs e)
        {
            
            SupplierListBox.Items.Add("Pick a Supplier");
            
            List<List<string>> list = DatabaseManagement.SelectQuery("Select supplierName from sql2231281.supplier");
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
            SupplierData.ItemsSource = LoadCollectionData();

        }

        private void Admin_Button_Click(object sender, RoutedEventArgs e)
        {
            Switcher.Switch(new Admin());
        }

        private void Logout_Button_Click(object sender, RoutedEventArgs e)
        {
            Switcher.Switch(new Index());
        }

        private List<SupplierItems> LoadCollectionData()
        {
            List<SupplierItems> SupplierItems = new List<SupplierItems>();
            string query = "SELECT  supplierprice.itemId, supplierprice.currentPrice, supplier.deliveryDays FROM supplier JOIN supplierprice ON supplier.supplierID = supplierprice.supplierID WHERE supplierName = '" + SupplierListBox.SelectedItem.ToString()  + "'";
            List<List<string>> supplierList = DatabaseManagement.SelectQuery(query);
            if (supplierList.Count != 0)
            {
                foreach (List<string> list in supplierList)
                {

                    SupplierItems.Add(new SupplierItems()
                    {

                        ItemsID = long.Parse(list[0]),
                        Price = double.Parse(list[1]),
                        DeliveryTime = int.Parse(list[2])
                    });



                }
            }
            return SupplierItems;
        }

        private void SupplierListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                if (SupplierListBox.SelectedItem.ToString() != "" && SupplierListBox.SelectedItem.ToString() != "Pick a Supplier")
                {
                    string SelectedSupplier = SupplierListBox.SelectedItem.ToString();
                    SupplierData.ItemsSource = LoadCollectionData();
                }
            }
            catch(Exception ex)
            {

            }
        }

        private void Delete_Button_Click(object sender, RoutedEventArgs e)
        {
            if (SupplierListBox.SelectedItem.ToString() != "" && SupplierListBox.SelectedItem.ToString() != "Pick a Supplier")
            {
                MessageBoxResult result = MessageBox.Show("Are you sure you want to delete this supplier?", "Supplier Delete Confirmation", MessageBoxButton.YesNo, MessageBoxImage.Warning, MessageBoxResult.No);
                if (result == MessageBoxResult.Yes)
                {
                    //delete supplier
                    string query = "Delete from `supplier` WHERE supplierName = '" + SupplierListBox.SelectedItem.ToString() + "';";
                    DatabaseManagement.Delete(query);
                    MessageBox.Show("Supplier has been deleted succesfully", "Confirmation", MessageBoxButton.OK, MessageBoxImage.Information, MessageBoxResult.OK);
                }
            }
        }

        private void Update_Click(object sender, RoutedEventArgs e)
        {
            SupplierListBox.IsEnabled = false;
            SupplierData.IsReadOnly = false;
            SupplierData.CanUserAddRows = true;
            SupplierData.CanUserDeleteRows = true;
            Update.IsEnabled = false;
        }

        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            SupplierListBox.IsEnabled = true;
            SupplierData.IsReadOnly = true;
            SupplierData.CanUserAddRows = false;
            SupplierData.CanUserDeleteRows = false;
            SupplierData.ItemsSource = LoadCollectionData();
            Update.IsEnabled = true;
        }

        

        private void Submit_Button1(object sender, RoutedEventArgs e)
        {
            SupplierListBox.IsEnabled = true;
            SupplierData.IsReadOnly = true;
            SupplierData.CanUserAddRows = false;
            SupplierData.CanUserDeleteRows = false;
            Update.IsEnabled = true;

            MessageBoxResult result = MessageBox.Show("All changes will be save and you won't be able to undo them. Are you sure?", "Supplier Update Confirmation", MessageBoxButton.YesNo, MessageBoxImage.Warning, MessageBoxResult.No);
            if (result == MessageBoxResult.Yes)
            {
                //Update the database with the new values

            }


        }

        private void button_Copy_Click(object sender, RoutedEventArgs e)
        {
            //add a supplier
            string query = "INSERT INTO supplier (supplierName, postalCode, location, country, deliveryDays) VALUES" ;
            DatabaseManagement.Add(query);
        }
    }
    public class SupplierItems
    {
        public Int64 ItemsID { get; set; }
        public double Price { get; set; }
        public int DeliveryTime { get; set; }

       
    }
}