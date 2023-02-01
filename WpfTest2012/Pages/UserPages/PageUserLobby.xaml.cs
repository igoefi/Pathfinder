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
using WpfTest2012.HelperClasses;
using WpfTest2012.Models;
using WpfTest2012.Pages.AdminManipulation;
using WpfTest2012.Pages.InfoPages;

namespace WpfTest2012.Pages.UserPages
{
    /// <summary>
    /// Логика взаимодействия для PageUserLobby.xaml
    /// </summary>
    public partial class PageUserLobby : Page
    {
        User _user;
        public PageUserLobby(User user)
        {
            InitializeComponent();
            _user = user;
        }

        private void BtnPlay_Click(object sender, RoutedEventArgs e) =>
            FrameNav.frameNavigation.Navigate(new PagePlayLobby(_user));

        private void BtnUpdateUserInfo_Click(object sender, RoutedEventArgs e) =>
            FrameNav.frameNavigation.Navigate(new UpdateUserInformationPage(_user));
    }
}
