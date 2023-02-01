using System;
using System.Collections.Generic;
using System.Data.Entity;
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
using WpfTest2012.Interface;
using WpfTest2012.Models;

namespace WpfTest2012.Pages.AdminManipulation
{
    /// <summary>
    /// Логика взаимодействия для UpdateUserInformationPage.xaml
    /// </summary>
    public partial class UpdateUserInformationPage : Page
    {
        User _user;
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
