using System.Windows;
using System.Windows.Controls;
using WpfTest2012.Models;

namespace WpfTest2012.Pages.UserPages
{
    /// <summary>
    /// Логика взаимодействия для PagePlayLobby.xaml
    /// </summary>
    public partial class PagePlayLobby : Page
    {
        readonly User _user;
        public PagePlayLobby(User user)
        {
            InitializeComponent();
            _user = user;
        }

        private void BtnContinueGame_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            if (_user.LastGame == null)
            {
                MessageBox.Show("Last game is null");
                return;
            }
        }

        private void BtnNewGame_Click(object sender, RoutedEventArgs e)
        {
            if (_user.LastGame != null)
            {
                var message = MessageBox.Show("У вас уже есть сохранённая игра. Всё равно начать новую?",
                    "Сохранённая игра",
                    MessageBoxButton.OKCancel,
                    MessageBoxImage.Information);
                if (message == MessageBoxResult.Cancel)
                    return;
            }

            
        }
    }
}
