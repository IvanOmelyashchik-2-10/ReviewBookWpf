using System.Windows;
using System.Windows.Media;

namespace ReviewBookWpf.View.Windows
{
    /// <summary>
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }


        private void RegstrationClick(object sender, RoutedEventArgs e)
        {
            string login = LoginField.Text.Trim();
            string pass = PasswordField.Password.Trim();
            string passCheck = PasswordCheckField.Password.Trim();
            string email = EmailField.Text.Trim().ToLower();
            if (login.Length < 5)
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
            else if (email.Length < 0 || email.Contains("@") || email.Contains("."))
            {
                EmailField.ToolTip = "Try another";
                EmailField.Background = Brushes.Red;
            }
            else
            {
                MessageBox.Show("Suscefull!");
            }
        }
    }
}
