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
    /// Logique d'interaction pour PuchaseAssistant.xaml
    /// </summary>
    public partial class PuchaseAssistant : UserControl
    {
        public PuchaseAssistant()
        {
            InitializeComponent();
        }

        private void button1_Copy1_Click(object sender, RoutedEventArgs e)
        {
            Switcher.Switch(new Index());
        }

        private void Submit_Button_Click(object sender, RoutedEventArgs e)
        {
            //Create the Order
            string query = "INSERT INTO table_name (orderDate, deliveryDate, paid, supplierNo, EmployeeNo) VALUES(); ";
            DatabaseManagement.Add(query);
        }

        private void UserControl_Initialized(object sender, EventArgs e)
        {
            CheapOrFast.Items.Add("Search for");
            CheapOrFast.Items.Add("Cheapest");
            CheapOrFast.Items.Add("Fastest");
            CheapOrFast.SelectedItem = "Search for";


            ItemsListBox.Items.Add("Pick an Item");

            List<List<string>> list = DatabaseManagement.SelectQuery("Select title from sql2231281.garden WHERE StockLevel < ReorderLevel");
            if (list.Count() == 0)
            {
                ItemsListBox.Items.Add("No Item in the database need to be Refilled");
            }
            else
            {
                foreach (List<string> items in list)
                {
                    foreach (string item in items)
                    {
                        ItemsListBox.Items.Add(item);
                    }
                }
                //SupplierListBox.Items.Add(list.Count());
            }
            ItemsListBox.SelectedItem = "Pick an Item";

        }

        private void Add_button_Click(object sender, RoutedEventArgs e)
        {
            if (CheapOrFast.SelectedItem.ToString() == "Pick an Item" && ItemsListBox.SelectedItem.ToString() == "Search for")
            {
                string query = string.Empty;
                if (ItemsData.HasItems)
                {
                    query = "Select * from supplierprice where supplierprice.itemid = garden.itemId  and supplierprice.supplierId = supplier.supplierID and supplier.suppliername= '"+ label.Content.ToString() +"' and garden.title = '"+ ItemsListBox.SelectedItem.ToString() +"'";
                }
                else
                {
                    //get delivery time and supplier name
                    if (CheapOrFast.SelectedItem.ToString() == "Cheapest")
                    {
                        query = "(SELECT MIN(currentPrice) AS price, itemId FROM `supplierprice` GROUP BY itemId) AS MinPrice ON MinPrice.itemId = SP.itemId JOIN (SELECT currentPrice, itemId, supplierId FROM supplierprice) AS priceItem WHERE priceItem.itemId = SP.itemId AND MinPrice.price = priceItem.currentPrice;";
                    }
                    else
                    {
                        query = "(SELECT MIN(currentPrice) AS price, itemId FROM `supplierprice` GROUP BY itemId) AS MinPrice ON MinPrice.itemId = SP.itemId JOIN (SELECT currentPrice, itemId, supplierId FROM supplierprice) AS priceItem WHERE priceItem.itemId = SP.itemId AND MinPrice.price = priceItem.currentPrice;";

                    }

                    List<List<String>> list =DatabaseManagement.SelectQuery(query);
                    List<string> littlelist = list[0];
                    label.Content = littlelist[1];

                }

                DatabaseManagement.SelectQuery(query);
            }
        }
        private List<PurchaseItems> LoadCollectionData()
        {
            List<PurchaseItems> PurchaseItems = new List<PurchaseItems>();
            


            return PurchaseItems;
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            ItemsData.ItemsSource = null;
            label.Content = "Current Supplier";

            ItemsListBox.Items.Add("Pick an Item");

            ItemsListBox.Items.Clear();

            List<List<string>> list = DatabaseManagement.SelectQuery("Select title from sql2231281.garden WHERE StockLevel < ReorderLevel");
            if (list.Count() == 0)
            {
                ItemsListBox.Items.Add("No Item in the database need to be Refilled");
            }
            else
            {
                foreach (List<string> items in list)
                {
                    foreach (string item in items)
                    {
                        ItemsListBox.Items.Add(item);
                    }
                }
                //SupplierListBox.Items.Add(list.Count());
            }
            ItemsListBox.SelectedItem = "Pick an Item";
        }
    }
    public class PurchaseItems
    {
        public int ID { get; set; }
        public int Price { get; set; }
        public int Quantity { get; set; }
        public int DeliveryTime { get; set; }
        public int TotalPrice { get; set; }
    }
}
