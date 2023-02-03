using System.Windows;
using System.Windows.Controls;
using WpfTest2012.HelperClasses;
using WpfTest2012.Models;
using WpfTest2012.Pages.AdminManipulation;

namespace WpfTest2012.Pages.UserPages
{
    /// <summary>
    /// Логика взаимодействия для PageUserLobby.xaml
    /// </summary>
    public partial class PageUserLobby : Page
    {
        readonly User _user;
        public PageUserLobby(User user)
        {
            InitializeComponent();
            _user = user;
        }

        private void BtnPlay_Click(object sender, RoutedEventArgs e) =>
            FrameNav.frameNavigation.Navigate(new PagePlayLobby(_user));

        private void BtnUpdateUserInfo_Click(object sender, RoutedEventArgs e) =>
            FrameNav.frameNavigation.Navigate(new UpdateUserInformationPage(_user));

        private void BtnCreateDeck_click(object sender, RoutedEventArgs e) =>
            FrameNav.frameNavigation.Navigate(new PageCreateNameDescriptionDeck());
    }
}
