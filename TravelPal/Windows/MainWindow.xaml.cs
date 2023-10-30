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
using System.Windows.Navigation;
using System.Windows.Shapes;
using TravelPal.Manager;
using TravelPal.Models;


namespace TravelPal
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        //Knapp för LogIN
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            // TextBox och PasswordBox läses in och sparas i string variabler username och password.

            string username = UsernameTextBox.Text;
            string password = PasswordBox.Password;

            //se Usemanager för process. 
            //variablerna username och passwords skickas till parametrar. Checkar true eller false. 
            bool isSuccessfulSignIn = UserManager.SignInUser(username, password);

            if (isSuccessfulSignIn) //Matchar lösenord och användarnman så öppnas TravelsWindow. "Användarekontot"
            {
                TravelsWindow travelsWindow = new();
                travelsWindow.Show();
                Close();
            }
            else //Misslyckas inloggningen... Visa varningsmeddelande!
            {
                MessageBox.Show("Incorrect username or password, try again!", "Warning");
            }

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            RegisterWindow registerWindow = new ();
            registerWindow.Show();
            Close();
        }
    }
}
