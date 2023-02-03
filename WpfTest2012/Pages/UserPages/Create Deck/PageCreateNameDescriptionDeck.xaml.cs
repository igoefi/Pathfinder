using System.Linq;
using System.Windows;
using System.Windows.Controls;
using WpfTest2012.HelperClasses;
using WpfTest2012.Models;

namespace WpfTest2012.Pages.UserPages
{
    /// <summary>
    /// Логика взаимодействия для PageCreateNameDescriptionDeck.xaml
    /// </summary>
    public partial class PageCreateNameDescriptionDeck : Page
    {
        public PageCreateNameDescriptionDeck()
        {
            InitializeComponent();
        }

        private void BtnStartCreateDeck(object sender, RoutedEventArgs e)
        {
            if (TxbName.Text.Count() > 20)
            {
                MessageBox.Show("Name so long");
                return;
            }
            if (TxbDescription.Text.Count() > 100)
            {
                MessageBox.Show("Description so long");
                return;
            }

            var checkDeck = DataBaseConnectContext.ConnectContext.Deck.FirstOrDefault(x => x.Name.ToLower() == TxbName.Text.ToLower());
            if(checkDeck != null)
            {
                MessageBox.Show("This deck name is engaged");
                return;
            }

            FrameNav.frameNavigation.Navigate(
                new PageCreateDeck(
                    new Deck { Name = TxbName.Text, Description = TxbDescription.Text }));
        }
    }
}
