using System.Windows;
using System.Windows.Media;
using ReviewBookWpf.Services.DataBase;

namespace ReviewBookWpf.View.Windows
{
    /// <summary>
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class RegistrationWindow : Window
    {
        private AppContext db;
        public RegistrationWindow()
        {
            InitializeComponent();
            db = new AppContext();
        }
        #region Регистрация пользователя в бд
        
        

        
        private void RegstrationClick(object sender, RoutedEventArgs e)
        {
            string login = LoginField.Text.Trim();
            string pass = PasswordField.Password.Trim();
            string passCheck = PasswordCheckField.Password.Trim();
            string email = EmailField.Text.Trim().ToLower();
            if (login.Length < 0)
            {
                LoginField.ToolTip = "Try another more than 5";
                LoginField.Background = Brushes.Red;
            }
            else if (pass.Length < 5 || pass != passCheck)
            {
                PasswordField.ToolTip = "Try another more than 5";
                PasswordCheckField.Background = Brushes.Red;
                PasswordField.Background = Brushes.Red;
            }
            else if (email.Length < 0 )
            {
                EmailField.ToolTip = "Try another";
                EmailField.Background = Brushes.Red;
            }
            else
            {
                MessageBox.Show("Suscefull!");
                User user = new User(login,pass,email);
                db.Users.Add(user);
                db.SaveChanges();
                MainWindow mainWindow = new MainWindow();
                mainWindow.Show();
                this.Close();
            }
        }
        #endregion

        private void AuthorizationButt(object sender, RoutedEventArgs e)
        {
            AutorizationWindow autorizationWindow = new AutorizationWindow();
            autorizationWindow.Show();
            this.Close();
            
        }
    }
}
