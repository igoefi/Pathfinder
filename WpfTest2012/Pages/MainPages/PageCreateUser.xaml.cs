using System;
using System.Windows;
using System.Windows.Controls;
using WpfTest2012.HelperClasses;
using WpfTest2012.Models;

namespace WpfTest2012.Pages
{
    /// <summary>
    /// Логика взаимодействия для PageCreateUser.xaml
    /// </summary>
    public partial class PageCreateUser : Page
    {
        public PageCreateUser()
        {
            InitializeComponent();
        }

        private void BtnCreateUser_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                User newUser = UserController.CreateUser(TxbLogin.Text, PsbPassUser.Password,
                    TxbNameUser.Text, TxbEmailUser.Text);
                if (newUser == null) return;

                DataBaseConnectContext.ConnectContext.User.Add(newUser);
                DataBaseConnectContext.ConnectContext.SaveChanges();
                FrameNav.frameNavigation.GoBack();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }
    }
}
