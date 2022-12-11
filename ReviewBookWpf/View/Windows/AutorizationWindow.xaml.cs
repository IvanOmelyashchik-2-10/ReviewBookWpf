using System.Linq;
using System.Windows;
using System.Windows.Media;
using ReviewBookWpf.Services.DataBase;
using ReviewBookWpf.ViewModel;

namespace ReviewBookWpf.View.Windows
{
    /// <summary>
    /// Логика взаимодействия для AutorizationWindow.xaml
    /// </summary>
    public partial class AutorizationWindow : Window
    {
        public AutorizationWindow()
        {
            InitializeComponent();
        }

        private void AutorizationClick(object sender, RoutedEventArgs e)
        {
            string login = LoginField.Text.Trim();
            string pass = PasswordField.Password.Trim();

            if (login.Length < 0)
            {
                LoginField.ToolTip = "Try another more than 5";
                LoginField.Background = Brushes.Red;
            }
            else if (pass.Length < 5)
            {
                PasswordField.ToolTip = "Try another more than 5";
                PasswordField.Background = Brushes.Red;
            }
            else
            {

                User AuthUser = null;
                using (AppContext db = new AppContext())
                {
                    AuthUser = db.Users
                        .FirstOrDefault(b => b.login == login && b.pass == pass);
                }
                if (AuthUser != null)
                {
                    MessageBox.Show("Ok");
                    MainWindow mainWindow = new MainWindow();
                    mainWindow.Show();
                    this.Close();
                    

                }
                else
                {
                    MessageBox.Show("Error");

                }
            }
        }

        private void ButtonRegister(object sender, RoutedEventArgs e)
        {
            RegistrationWindow registrationWindow = new RegistrationWindow();
            registrationWindow.Show();
            this.Close();
        }
    }
}
