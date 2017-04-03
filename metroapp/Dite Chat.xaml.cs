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

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace metroapp
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Dite_Chat : Page
    {
        public Dite_Chat()
        {
            this.InitializeComponent();
        }

        /// <summary>
        /// Invoked when this page is about to be displayed in a Frame.
        /// </summary>
        /// <param name="e">Event data that describes how this page was reached.  The Parameter
        /// property is typically used to configure the page.</param>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
        }

        private void b6_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof (MainPage));
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Dietchartforbabies1));
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(DietchartforkidsandTeens));
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(BlankPage1));
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Dietchartforweightloss));
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Dietchartforheight));
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(DietchartforSyndromes));
        }
    }
}
