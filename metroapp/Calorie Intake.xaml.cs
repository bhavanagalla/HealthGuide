using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Windows.Storage;


// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace metroapp
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    [System.Runtime.InteropServices.GuidAttribute("5BA45759-BC86-48C8-AF37-C5EBB63DB5FD")]
    public sealed partial class Calorie_Intake : Page
    {
        MyHealthCheckService.HealthMonitorClient objWCFservice;
        List<Dictionary<string, int>> lstCalorieItems = null;
        int totalCalories;
        int itemCalories;
        public Calorie_Intake()
        {
            itemCalories = 0;
            totalCalories = 0;
            lstCalorieItems = new List<Dictionary<string, int>>();
            this.InitializeComponent();
        }

        /// <summary>
        /// Invoked when this page is about to be displayed in a Frame.
        /// </summary>
        /// <param name="e">Event data that describes how this page was reached.  The Parameter
        /// property is typically used to configure the page.</param>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            objWCFservice = new MyHealthCheckService.HealthMonitorClient();
        }

        private void b8_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(MainPage));
        }

        public class ListViewWithComboBox : ListView
        {

        }

        private void btnAddItemToList_Click(object sender, RoutedEventArgs e)
        {
            ListBox.Items.Add(cbCategoryItem.SelectedItem + " >> " + cbItem.SelectedItem + " >> " + QuantityValue.Text);
            if (ListBox.Items.Count > 0)
            {
                totalCalories = totalCalories + itemCalories;
                btnSubmit.IsEnabled = true;
            }
            else
                btnSubmit.IsEnabled = false;
            tblkTotalCalories.Text = "";
        }

        private void listView_Load(object sender, EventArgs e)
        {
            /* cb1.Items.Add("Fresh Fruits");
             cb1.Items.Add("Dried Fruits");
             cb1.Items.Add("Vegetables");*/
        }

        private void btnRemoveSelectedItem_Click(object sender, RoutedEventArgs e)
        {
            int result = 0;
            for (int i = ListBox.SelectedItems.Count - 1; i >= 0; i--)
            {
                string[] arrItems = ListBox.SelectedItems[i].ToString().Replace(">>", "^").Split('^');
                ListBox.Items.Remove(ListBox.SelectedItems[i]);
                int.TryParse(lstCalorieItems.SelectMany(m=>m).Where(l => l.Key.ToString() == (arrItems[1].Trim() + "," + arrItems[2].Trim())).Select(l => l.Value).FirstOrDefault().ToString(), out result);
                totalCalories = totalCalories - result;
            }
            if (ListBox.Items.Count > 0)
                btnSubmit.IsEnabled = true;
            else
                btnSubmit.IsEnabled = false;
            tblkTotalCalories.Text = "Total calories consumed : " + totalCalories.ToString();
        }

        private void b16_Click(object sender, RoutedEventArgs e)
        {

        }

        private void cb1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private async void cbCategoryItem_Loaded(object sender, RoutedEventArgs e)
        {
            List<MyHealthCheckService.Category> lstCategory = new List<MyHealthCheckService.Category>();
            lstCategory = await objWCFservice.GetCategoriesAsync();
            MyHealthCheckService.Category obj = new MyHealthCheckService.Category { CategoryId = 0, Value = "Select a Category" };
            lstCategory.Insert(0, obj);
            cbCategoryItem.ItemsSource = lstCategory.Select(l => l.Value).ToList();
            cbCategoryItem.SelectedIndex = 0;
        }

        private async void cbCategoryItem_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            List<MyHealthCheckService.Items> lstItems = new List<MyHealthCheckService.Items>();
            lstItems = await objWCFservice.GetItemsByItemAsync(cbCategoryItem.SelectedItem.ToString());
            MyHealthCheckService.Items obj = new MyHealthCheckService.Items { CategoryId = 0, ItemsId = 0, ItemValue = "Select an Item", QuantityValue = "0" };
            lstItems.Insert(0, obj);
            cbItem.ItemsSource = lstItems.Select(l => l.ItemValue).ToList();
            cbItem.SelectedIndex = 0;
        }

        private async void cbItem_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                if (cbItem.SelectedItem != null && cbItem.SelectedIndex > 0)
                {
                    MyHealthCheckService.Items objItems = new MyHealthCheckService.Items();
                    objItems = await objWCFservice.GetQuantityAndCalorieByItemAsync(cbItem.SelectedItem.ToString());
                    QuantityValue.Text = objItems.QuantityValue;
                    itemCalories = objItems.Calories;
                    Dictionary<string, int> obj = new Dictionary<string, int>();
                    obj.Add(objItems.ItemValue + "," + objItems.QuantityValue, objItems.Calories);
                    if (lstCalorieItems.IndexOf(obj) == -1)
                        lstCalorieItems.Add(obj);
                }
            }
            catch (Exception ex)
            {
                itemCalories = 0;
                QuantityValue.Text = "";
            }
        }

        private void btnSubmit_Click(object sender, RoutedEventArgs e)
        {
            tblkTotalCalories.Text = "Total calories consumed : " + totalCalories.ToString();
        }

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (ListBox.SelectedIndex > -1)
                btnRemoveSelectedItem.IsEnabled = true;
            else
                btnRemoveSelectedItem.IsEnabled = false;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(MainPage));
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(MainPage));
        }
    }
}
