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
        public TravelDetailsWindow()
        {
            InitializeComponent();

            if (UserManager.SignedInUser!.GetType() == typeof(User))
            {
                // Om user är inloggad så visas det i textrutan
                User signedInUser = (User)UserManager.SignedInUser;

                //displayUsername.Text = signedInUser.Username.ToString();

                // Displaya land i listview för användaren
                foreach (Travel trip in TravelManager.Travels)
                {
                    ListViewItem destination = new();
                    destination.Tag = trip;
                    destination.Content = trip.Country;
                    destination.Content = trip.City;
                    destination.Content = trip.Passangers;
                    // destination.Content = trip.GetType();

                    txbDestination.Text = trip.Country;
                    txbCity.Text = trip.City;
                    txbTravellers.Text = trip.Passangers.ToString();
                    //txbTypeOfTrip.Text = trip.GetType();
                }



            }

        }
    }
}

