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
    public sealed partial class First_Aid_Tipsm2 : Page
    {
        public First_Aid_Tipsm2()
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(First_Aid_Tips2));
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(First_Aid_Tipsm3));
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(First_Aid_Tipsm4));
        }

        private void Button_Click_h2(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(MainPage));
        }

        private void ___Chest_Pain_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(ChestPaintreatment));
        }

        private void Chest_Pain__Angina__Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(ChestPaintreatment));
        }

        private void Choking_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(firstaidtipsC));
        }

        private void Carbon_Monoxide_Poisoning_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(firstaidtipsC));
        }

        private void Catfish_Sting_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(firstaidtipsC));
        }

        private void Chemical_Burns_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(firstaidtipsC));
        }

        private void Chemical_Eye_Burn_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(firstaidtipsC));
        }

        private void Chest_Injury_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(firstaidtipsC));
        }

        private void Choking_in_Children_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(firstaidtipsC));
        }

        private void Colds_in_Children_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(firstaidtipsC));
        }

        private void Concussion_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(firstaidtipsC));
        }

        private void Congestion_in_Children_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(firstaidtipsC));
        }

        private void Constipation_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Firstaidtipsc2));
        }

        private void Convulsions_in_Children_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(firstaidtipsC));
        }

        private void Coughs_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(firstaidtipsC));
        }

        private void CPR_for_Adults_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(firstaidtipsC));
        }

        private void CPR_for_Children_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(firstaidtipsC));
        }

        private void Cuts_and_Bleeding_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(firstaidtipsC));
        }

        private void Cyanide_Poisoning_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(firstaidtipsC));

        }

        private void Burns_Scalds_in_Children_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(First_Aid_Tips_4));
        }

        private void Dehydration_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(FirstaidtipsD));
        }

        private void Ear_Infections_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(firstaidtipsE));
        }

        private void Facial_Fracture_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(firstaidtipsF));
        }

        private void Fainting_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(firstaidtipsF));
        }

        private void Eczema_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(firstaidtipsE));
        }

        private void Elbow_Dislocation_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(firstaidtipsE));
        }

        private void Electric_Shock_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(firstaidtipsE));
        }

        private void Eye_Bleeding__Hyphema__Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(firstaidtipsE));
        }

        private void Eye_Burns_Corneal_Burns_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(firstaidtipsE));
        }

        private void Eye_Injuries_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(firstaidtipsE));
        }

        private void Eye_Sores_Corneal_Ulcers_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(firstaidtipsE));
        }

        private void Eyelid_Inflammation_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(firstaidtipsE));
        }

        private void Dehydration_in_Children_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(FirstaidtipsD));
        }

        private void Diarrhea_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(FirstaidtipsD));
        }

        private void Diving_Ear_Pain_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(FirstaidtipsD));
        }

        private void Dizziness_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(FirstaidtipsD));
        }

        private void Drowning_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(FirstaidtipsD));
        }

        private void Drug_Allergy_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(FirstaidtipsD));
        }

        private void Drug_Overdose_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(FirstaidtipsD));
        }
    }
}
