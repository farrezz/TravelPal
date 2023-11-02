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

namespace TravelPal
{
    /// <summary>
    /// Interaction logic for TravelsWindow.xaml
    /// </summary>
    public partial class TravelsWindow : Window
    {
        List<Travel> Travels = new();
        public TravelsWindow()
        {
            InitializeComponent();

            if (UserManager.SignedInUser!.GetType() == typeof(User))
            {
                // Om user är inloggad så visas det i textrutan
                User signedInUser = (User)UserManager.SignedInUser;

                displayUsername.Text = signedInUser.Username.ToString();
                
            }
            else if (UserManager.SignedInUser!.GetType() == typeof(Admin))
            {

                // Om admin är inloggad så visas det i textrutan som admin
                Admin signedInUser = (Admin)UserManager.SignedInUser;

                displayUsername.Text = signedInUser.Username.ToString();

                //visa user listan
            }

        }

        private void bttnInfo_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("TravelPal is an app for your travels. \n  Add, delete or View details of your trip.", "Information");
        }

        private void bttnAddTravel_Click(object sender, RoutedEventArgs e)
        {
            AddTravelWindow addTravelWindow = new();
            addTravelWindow.Show();
            Close();

        }

        private void bttnDetails_Click(object sender, RoutedEventArgs e)
        {
            TravelDetailsWindow travelDetailsWindow = new();
            travelDetailsWindow.Show(); 
            Close();
        }

        private void displayUsername_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void lstDestination_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            if (lstDestination.Items.Count > 0)
            {
                ListBoxItem destination = (ListBoxItem)lstDestination.SelectedItem;

                Travel selectedTrip = (Travel)destination.Tag;

                //lstDestination.TextInput = selectedTrip.Country;
                //lblPrio.Content = selectedTodo.Priority.ToString();
            }
            /*

            var travel = lstDestination.SelectedItem as Travel;

            if (travel != null)
            {
                foreach (var Travel in Travels)
                {
                    lstDestination.SelectedItem = Travel;

                }
            }

            */

        }

        private void UpdateUi()
        {
            // Rensa listan
            //lstDestination.Items.Clear();

            // Hämta alla employees i "databasen"
            List<Travel> travels = Travels;

            // Toggla "Show Details"-, och "Remove"-knappen beroende på om vi har personer i databasen
           /* if (travels.Count > 0)
            {
                btnShowDetails.IsEnabled = true;
                btnRemove.IsEnabled = true;
            }
            else
            {
                btnShowDetails.IsEnabled = false;
                btnRemove.IsEnabled = false;
            }
           */

            // Lägg till varje employee från databasen i listan
            foreach (Travel Travel in travels)
            {
                ListViewItem item = new();

                item.Content = Travel.Country;

               /* if (Travel.GetType() == typeof(Employee))
                {
                    item.Content += " | ";

                    Employee employee = (Employee)person;

                    item.Content += employee.Department.ToString();
                    item.Tag = employee;
                }
                else
                {
                    item.Content += " | Customer";
                    item.Tag = person;
                }
               */
                lstDestination.Items.Add(item);
            }

            // Rensa alla inputs
            /*txtFirstName.Text = "";
            txtLastName.Text = "";
            txtAge.Text = "";
            txtBio.Text = "";
            txtSalary.Text = "";
            cbDepartments.SelectedIndex = -1;
            */
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
            ListBoxItem selectedItem = (ListBoxItem)lstDestination.SelectedItem;
            
            // Ta bort det itemet från listView:en
            lstDestination.Items.Remove(selectedItem);
        }
    }
}
