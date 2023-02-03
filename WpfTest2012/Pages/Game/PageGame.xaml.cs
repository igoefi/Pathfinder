using Newtonsoft.Json;
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
using WpfTest2012.Cards;
using WpfTest2012.Game;
using WpfTest2012.Game.Cards.Cards;
using WpfTest2012.Game.GameManegment;
using WpfTest2012.Game.JsonDB;
using WpfTest2012.Models;

namespace WpfTest2012.Pages.Game
{
    /// <summary>
    /// Логика взаимодействия для PageGame.xaml
    /// </summary>
    public partial class PageGame : Page
    {
        private GameInfos _game;
        private User _user;
        public PageGame(User user, Deck deck, HeroCard heroCard)
        {
            InitializeComponent();

            _user = user;

            var heroes = new List<CardHero>
            {
                new CardHero(heroCard)
            };

            var needDeck = new Stack<GameCard>();
            var unserDeck = (DeckJson)JsonConvert.DeserializeObject(deck.JsonArray);

            foreach (var card in unserDeck.Cards)
                needDeck.Push(new GameCard(card));
            _game = new GameInfos(new WpfTest2012.Game.GameArraysJson(heroes, needDeck), user);
        }

        /*
        public PageGame(User user, GameArrays arrays)
        {
            InitializeComponent();

            _user = user;

            var heroes = new List<CardHero>
            {
                new CardHero(heroCard)
            };

            var needDeck = new Stack<GameCard>();
            var unserDeck = (DeckJson)JsonConvert.DeserializeObject(deck.JsonArray);

            foreach (var card in unserDeck.Cards)
                needDeck.Push(new GameCard(card));
            _game = new GameInfos(new WpfTest2012.Game.GameArrays(heroes, needDeck), user);
        }*/
    }
}
