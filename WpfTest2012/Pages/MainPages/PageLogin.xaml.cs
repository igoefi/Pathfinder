using System.Windows;
using System.Windows.Controls;
using WpfTest2012.HelperClasses;
using WpfTest2012.Models;
using WpfTest2012.Pages.UserPages;

namespace WpfTest2012.Pages
{
    /// <summary>
    /// Логика взаимодействия для PageLogin.xaml
    /// </summary>
    public partial class PageLogin : Page
    {
        public PageLogin()
        {
            InitializeComponent();
        }

        private void BtnLoginIn_Click(object sender, RoutedEventArgs e)
        {
            User user = UserController.FindUser(TxbLogin.Text, PsbxPassword.Password);
            if (user != null)
                FrameNav.frameNavigation.Navigate(new PageUserLobby(user));
            else
                MessageBox.Show("Неправильный логин или пароль");
        }

        private void BtnCreateUser_Click(object sender, RoutedEventArgs e) =>
            FrameNav.frameNavigation.Navigate(new PageCreateUser());
    }
}
