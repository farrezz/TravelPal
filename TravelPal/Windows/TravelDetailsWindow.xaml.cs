using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
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
using System.Windows.Shapes;
using TravelPal.Manager;
using TravelPal.Models;

namespace TravelPal
{
    /// <summary>
    /// Interaction logic for TravelDetailsWindow.xaml
    /// </summary>
    public partial class TravelDetailsWindow : Window
    {
        public TravelDetailsWindow(Travel travelInformation)
        {
            
            InitializeComponent();


                txbCity.Text = travelInformation.City;
                txbDestination.Text = travelInformation.Country.ToString();
                txbTravellers.Text = travelInformation.Passangers.ToString();
                txbTypeOfTrip.Text = travelInformation.GetType() == typeof(Vacation) ? "Vacation" : "Work Trip";
                lblType.Visibility = Visibility.Visible;
                txbTypeOfTrip.Visibility = Visibility.Visible;

                if (travelInformation is WorkTrip workTrip)
                {
                    txbMeetingDetails.Text = workTrip.MeetingDetails;
                    txbMeetingDetails.Visibility = Visibility.Visible;
                    lblMeetingDetails.Visibility = Visibility.Visible;
                    txbTypeOfTrip.Text = "Work Trip";

                }
                else
                {
                    txbMeetingDetails.Visibility = Visibility.Hidden;
                    lblMeetingDetails.Visibility = Visibility.Hidden;
                }

                if (travelInformation is Vacation vacation)
                {
                    ckAllinclusive.IsChecked = vacation.AllInclusive;
                    ckAllinclusive.Visibility = Visibility.Visible;
                    lblAllinclusive.Visibility= Visibility.Visible;
                    txbTypeOfTrip.Text = "Vacation";
                }
                else
                {
                    ckAllinclusive.Visibility = Visibility.Hidden;
                    lblAllinclusive.Visibility = Visibility.Hidden;
                }

            }
            /*
                if (txbTypeOfTrip.Text == "Work Trip")
                {
                    txbMeetingDetails.Visibility = Visibility.Visible;
                    lblMeetingDetails.Visibility = Visibility.Visible;
                    txbMeetingDetails.Text = travelInformation.MeetingDetails;

                }
                else
                {
                    txbMeetingDetails.Visibility = Visibility.Hidden;

                }

                if (txbTypeOfTrip.Text == "Vacation")
                {
                    ckAllinclusive.Visibility = Visibility.Visible;


                    //checkar om checkbox är true
                    if (travelInformation is Vacation vacation && vacation.AllInclusive)
                    {
                        ckAllinclusive.IsChecked = true;
                    }
                }
                else
                {
                    ckAllinclusive.Visibility = Visibility.Hidden;
                }
            */

       

        private void btnReturn_Click(object sender, RoutedEventArgs e)
        {
            TravelsWindow travelWindow =new();
            travelWindow.Show();
            Close();
        }
    }
}


/*



if (UserManager.SignedInUser!.GetType() == typeof(User))
{
    // Om user är inloggad så visas det i textrutan
    //User signedInUser = (User)UserManager.SignedInUser;
    //displayUsername.Text = signedInUser.Username.ToString();
    // Displaya land i listview för användaren
    foreach (Travel trip in TravelManager.Travels)
    {
        ListViewItem destination = new();
        destination.Tag = trip;
        destination.Content = trip.Country;
        destination.Content = trip.City;
        destination.Content = trip.Passangers;
        destination.Content = trip.GetType();

        txbDestination.Text = trip.Country;
        txbCity.Text = trip.City;
        txbTravellers.Text = trip.Passangers.ToString();

        if (trip.GetType == Vacation.Equals)
        {
            txbTypeOfTrip.Visibility = Visibility.Visible;
            lblType.Visibility = Visibility.Visible;
            txbTypeOfTrip.Text = trip.GetType().Name;

        }
        else if (trip.GetType == WorkTrip.Equals)
        {
            txbMeetingDetails.Visibility = Visibility.Visible;
            lblMeetingDeetils
                        txbMeetingDetails.Text = trip.GetType().Name;

        }



    };

}
else if (UserManager.SignedInUser!.GetType() == typeof(Admin))
{
    foreach (Travel trip in TravelManager.Travels)
    {
        ListViewItem destination = new();
        destination.Tag = trip;
        destination.Content = trip.Country;
        destination.Content = trip.City;
        destination.Content = trip.Passangers;
        destination.Content =

        // destination.Content = trip.GetType();

        txbDestination.Text = trip.Country;
        txbCity.Text = trip.City;
        txbTravellers.Text = trip.Passangers.ToString();



    };

}

*/