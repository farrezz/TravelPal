using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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
           string? username = registerUsername.Text.Trim();
           string password = registerPassword.Text.Trim();
           bool usernameExists = false;

            // Checka alla inputs
 
                if (username == "" && password == "")
                {

                    MessageBox.Show("Please enter all the required fields", "Warning");
                }
                else if (username == "")
                {
                    MessageBox.Show("Please enter a username!", "Warning");
                }
                else if (password == "")
                {

                    MessageBox.Show("Please enter a password!", "Warning");
                }
                // loopar genom alla användarnamn i listan, Om användaren är i bruk så poppar en varningsruta upp. 
                else
                {
 
                    foreach (var user in UserManager.Users)
                    {
                        if (user.Username == username)
                        {
                            usernameExists = true;
                            
                        }
                    }
                }
                if (usernameExists)
                {
                    MessageBox.Show("The username is already in use!", "Warning");
 
                }
                //Inga input är tomma och att användarnamn inte är redan upptaget.
            if (username != "" && password != "" && !usernameExists)
            {
                User newUser = new(username, password);

                List<IUser> Users = new();
                // Skapa en user
                // Lägg till usern i listan
                //vi har redan listan i kodblocken
                UserManager.Users.Add(newUser);
                //om användare register- går tillbaka till main window för att logga in
                MainWindow mainWindow = new();
                mainWindow.Show();
                Close();

            }


        }

    }
}
