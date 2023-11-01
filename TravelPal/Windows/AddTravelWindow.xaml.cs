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
    /// Interaction logic for AddTravelWindow.xaml
    /// </summary>
    public partial class AddTravelWindow : Window
    {
        public AddTravelWindow()
        {
            InitializeComponent();

            //lägger länder i rullistan - comboboxen
            foreach (var cbCountries in Enum.GetValues(typeof(Country)))
            {
                cbCountry.Items.Add(cbCountries);
            }
            // lägger till alterantiven worktrip och vacation
            /*foreach (var type in Enum.GetValues(typeof(Type)))
            {
                cbTypeTrip.Items.Add(type);
            }
            */
            cbTypeTrip.Items.Add("Work");
            cbTypeTrip.Items.Add("Vacation");

        }

        
        //Combobox Type of trip
        private void cbTypeTrip_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
 
            if((string)cbTypeTrip.SelectedItem == "Work")
            {
                txbWorkTrip.Visibility = Visibility.Visible;
                txtMeetingDetails.Visibility = Visibility.Visible;
            } 
            else 
            {
                txbWorkTrip.Visibility = Visibility.Hidden;
                txtMeetingDetails.Visibility = Visibility.Hidden; 
            }
            if ((string)cbTypeTrip.SelectedItem == "Vacation")
            {
                ckAllinclusive.Visibility = Visibility.Visible;
            }
            else
            {
                ckAllinclusive.Visibility = Visibility.Hidden;
            }
        }
        private void bttnAdd_Click(object sender, RoutedEventArgs e)
        {
            // Checka alla inputs
            string country = cbCountry.Text;
            string city = txtbCity.Text;
            //Todo:
            //tryCatch
            int passangers = int.Parse(txtbPassangers.Text);

            
            if (country != "" && city != "" && passangers > 0 && cbCountry.SelectedIndex > -1)
            {
                if((string)cbTypeTrip.SelectedItem == "Work")
                {
                    Country selectedCountry = (Country)cbCountry.SelectedItem;

                    string meetingDetails = txbWorkTrip.Text;

                    WorkTrip newWorkTrip = new(meetingDetails, country, city, passangers);

                    //lägg till i listan i static
                    TravelManager.Travels.Add(newWorkTrip);
                    //samt i user listans resor.
                    ((User)UserManager.SignedInUser).Travels.Add(newWorkTrip);
                }
                else if ((string)cbTypeTrip.SelectedItem == "Vacation")
                {
                    Country selectedCountry = (Country)cbCountry.SelectedItem;

                    bool allInclusive = (bool)ckAllinclusive.IsChecked;

                    Vacation newVacation = new(allInclusive, country, city, passangers);

                    //lägg till i statiska listan.
                    Manager.TravelManager.Travels.Add(newVacation);
                    //lägg till i user-specifika listan
                    ((User)UserManager.SignedInUser).Travels.Add(newVacation);

                }
                UpdateUI();
                TravelsWindow travelsWindow = new();
                travelsWindow.Show();
                Close();
                
            }
        }

        private void UpdateUI()
        {
            // Rensa alla inputs
            cbCountry.Text = "";
            txtbCity.Text = "";
            txtbPassangers.Text = "";
     

            //nollställa comboboxen
            if ((string)cbTypeTrip.SelectedItem == "Vacation" || (string)cbTypeTrip.SelectedItem == "Work")
            {
                cbTypeTrip.Visibility = Visibility.Visible;
                txtMeetingDetails.Visibility = Visibility.Hidden;
                txbWorkTrip.Visibility = Visibility.Hidden;
                ckAllinclusive.Visibility = Visibility.Hidden;

            }

        }
    }
}
