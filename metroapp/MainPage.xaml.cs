using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.ServiceModel.Description;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Imaging;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238
using Windows.UI.Xaml.Shapes;

namespace metroapp
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();

            //// Connecting to an instance of SQL Server using SQL Server Authentication
            //Server srv1 = new Server();   // connects to default instance
            //srv1.ConnectionContext.LoginSecure = false;   // set to true for Windows Authentication
            //srv1.ConnectionContext.Login = sqlServerLogin;
            //srv1.ConnectionContext.Password = password;
            //Console.WriteLine(srv1.Information.Version);   // connection is established
  
        }

        /// <summary>
        /// Invoked when this page is about to be displayed in a Frame.
        /// </summary>
        /// <param name="e">Event data that describes how this page was reached.  The Parameter
        /// property is typically used to configure the page.</param>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
        }
        

        private void b1_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof (Health_Tips));
        }

        private void b2_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof (Dite_Chat));
        }

        private void b4_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof (Calorie_Intake));
        }

        private void b3_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof (First_Aid_Tips2));
        }

        private void b9_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Health_Tips));
        }

        private void b10_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Dite_Chat));
        }

        private void b11_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(First_Aid_Tips2));
        }

        private void b12_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Calorie_Intake));
        }

        private void b1_Click_1(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Health_Tips));
        }
        

    }
}
