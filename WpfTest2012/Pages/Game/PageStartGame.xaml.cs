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
using WpfTest2012.Pages.Game;

namespace WpfTest2012.Pages
{
    /// <summary>
    /// Логика взаимодействия для PageStartGame.xaml
    /// </summary>
    public partial class PageStartGame : Page
    {
        readonly private User _user;
        public PageStartGame(User user)
        {
            InitializeComponent();
            _user = user;

            var decks = DataBaseConnectContext.ConnectContext.Deck;
            var heroes = DataBaseConnectContext.ConnectContext.HeroCard;

            var decksName = new List<string>();
            var heroesName = new List<string>();

            foreach (var deck in decks)
                decksName.Add(deck.Name);

            foreach (var hero in heroes)
                heroesName.Add(hero.Name);

            CmbBoxHero.ItemsSource = heroesName;
            CmbBoxDeck.ItemsSource = decksName;

            CmbBoxDeck.SelectedIndex = 0;
            CmbBoxHero.SelectedIndex = 0;
        }

        private void BtnStartGame_Click(object sender, RoutedEventArgs e)
        {
            if(CmbBoxHero.SelectedItem == null || CmbBoxDeck.SelectedItem == null)
            {
                MessageBox.Show("Select all");
                return;
            }

            var hero = DataBaseConnectContext.ConnectContext.HeroCard.FirstOrDefault(x => x.Name == CmbBoxHero.SelectedItem.ToString());
            var deck = DataBaseConnectContext.ConnectContext.Deck.FirstOrDefault(x => x.Name == CmbBoxDeck.SelectedItem.ToString());

            FrameNav.frameNavigation.Navigate(new PageGame(_user, deck, hero));
        }
    }
}
