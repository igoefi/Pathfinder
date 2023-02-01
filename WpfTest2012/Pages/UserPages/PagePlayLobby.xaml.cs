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
using WpfTest2012.Models;

namespace WpfTest2012.Pages.UserPages
{
    /// <summary>
    /// Логика взаимодействия для PagePlayLobby.xaml
    /// </summary>
    public partial class PagePlayLobby : Page
    {
        User _user;
        public PagePlayLobby(User user)
        {
            InitializeComponent();
            _user = user;
        }
    }
}
