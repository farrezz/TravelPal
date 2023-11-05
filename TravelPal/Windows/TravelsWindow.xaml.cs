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
using TravelPal.Models;
using TravelPal.Manager;
using System.Diagnostics;
using System.Configuration;
using System.Diagnostics.Metrics;

namespace TravelPal
{
    /// <summary>
    /// Interaction logic for TravelsWindow.xaml
    /// </summary>
    public partial class TravelsWindow : Window
    {
        //List<Travel> Travels = new();

        public TravelsWindow()
        {
            InitializeComponent();


            if (UserManager.SignedInUser.GetType() == typeof(User))
            {
                User signedInUser = (User)UserManager.SignedInUser;
                displayUsername.Text = signedInUser.Username.ToString();

                // Displaya land i listview för användaren
                //även default resa visas för användaren

                foreach (Travel trip in TravelManager.Travels)
                {
                    ListViewItem destination = new();
                    destination.Tag = trip;
                    destination.Content = trip.Country;
                    lstDestination.Items.Add(destination);

                }

            }
            else if (UserManager.SignedInUser.GetType() == typeof(Admin))
            {
                Admin signedInUser = (Admin)UserManager.SignedInUser;
                displayUsername.Text = signedInUser.Username.ToString();

                bttnAddTravel.Visibility = Visibility.Hidden;
                //List<Travel> travels = new();
                //visa user listan
                foreach (Travel trip in TravelManager.Travels)
                {
                    ListViewItem destination = new();

                    destination.Tag = trip;
                    destination.Content = trip.Country;
                    lstDestination.Items.Add(destination);
                }


            }

        }

        private void bttnInfo_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("TravelPal is an app for your travels. \n Add, delete or View details for your trip.", "Information");
        }

        private void bttnAddTravel_Click(object sender, RoutedEventArgs e)
        {

            AddTravelWindow addTravelWindow = new();
            addTravelWindow.Show();
            Close();

        }

        private void bttnDetails_Click(object sender, RoutedEventArgs e)
        {

            ListViewItem selectedItem = (ListViewItem)lstDestination.SelectedItem;

            if (selectedItem == null)
            {
                MessageBox.Show("Choose a country from the list to see more details", "Warning");
            }
            else
            {
                Travel travel = (Travel)selectedItem.Tag;

                TravelDetailsWindow travelDetailsWindow = new(travel);
                travelDetailsWindow.Show();
                Close();


            }


        }

        private void displayUsername_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void lstDestination_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
        private void bttSignOut_Click(object sender, RoutedEventArgs e)
        {
            // Logga ut användaren
            UserManager.SignOutUser();

            // Gå tillbaka till MainWindow
            MainWindow mainWindow = new();
            mainWindow.Show();

            // Stäng detta fönster
            Close();
        }
        private void bttnDelete_Click(object sender, RoutedEventArgs e)
        {

            // Kolla vilket item som är selectat i listan
            ListViewItem selectedItem = (ListViewItem)lstDestination.SelectedItem;
            Travel travels = (Travel)selectedItem.Tag;
            // UserManager.SignInUser("user", "password");
            //IUser currentUser = UserManager.SignedInUser;
            // Check if the selected item's Tag is a Travel object
            
            if (selectedItem == null)
            {
                MessageBox.Show("Choose a country from the list to delete", "Warning");
            }
            else if(UserManager.SignedInUser is Admin)
            {
                TravelManager.RemoveTravel(travels);
               // ((User)UserManager.SignedInUser).Remove(travels);

            }
            else
            {
                MessageBox.Show("You have to be admin to remove a travel", "Warning");
            }


            //User user = new("user", "password");

            //user.Travels.Remove(travels);
            // user = new(meetingDetails, country, city, passangers);
            //newWorkTrip.TravelBelongsTo = UserManager.SignedInUser;
            //lägg till i listan i static

            //samt i user listans reso
            //((User)UserManager.SignedInUser).Travels.Remove(travels);


            lstDestination.Items.Remove(selectedItem);
        }


    }

}
   
    

