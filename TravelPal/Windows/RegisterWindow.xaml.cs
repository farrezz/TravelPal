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

namespace TravelPal
{
    /// <summary>
    /// Interaction logic for RegisterWindow.xaml
    /// </summary>
    public partial class RegisterWindow : Window
    {
        public RegisterWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {


            // Läsa våra inputs
           string username = registerUsername.Text.Trim();
           string password = registerPassword.Text.Trim();

            // Checka alla inputs
            if (username == "")
            {
                //warnFirstName.Visibility = Visibility.Visible;
                MessageBox.Show("Please enter a username!", "Warning");
            }

            if (password == "")
            {
                // warnLastName.Visibility = Visibility.Visible;
                MessageBox.Show("Please enter a password!", "Warning");
            }

            if (username != "" && password != "")
            {
                // Skapa en user

                User newUser = new(username, password);

                // Lägg till usern i listan

                List<IUser> users = new();
                users.Add(newUser);
                //om användare registerat. går tillbaka till main window för att logga in
                MainWindow mainWindow = new();
                mainWindow.Show();
                Close();

            }

        }
    }
}
