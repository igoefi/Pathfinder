using System.Windows;
using System.Windows.Controls;
using WpfTest2012.HelperClasses;
using WpfTest2012.Models;

namespace WpfTest2012.Pages.AdminManipulation
{
    /// <summary>
    /// Логика взаимодействия для UpdateUserInformationPage.xaml
    /// </summary>
    public partial class UpdateUserInformationPage : Page
    {
        readonly User _user;
        public UpdateUserInformationPage(User user)
        {
            InitializeComponent();
            _user = user;
        }

        private void BtnUpdateUserInfo_Click(object sender, RoutedEventArgs e)
        {
            UserController.UpdateUserInformation(_user, TxbLogin.Text, PsbPassUser.Password,
                TxbNameUser.Text, TxbEmailUser.Text);

            FrameNav.frameNavigation.GoBack();
        }
    }
}
