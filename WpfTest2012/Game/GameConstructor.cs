using System.Collections.Generic;
using System.Windows;
using WpfTest2012.Cards;
using WpfTest2012.Game.Cards.Cards;
using WpfTest2012.Game.JsonDB;
using WpfTest2012.Models;

namespace WpfTest2012.Game
{
    internal class GameConstructor
    {
        private readonly List<CardHero> _heroes;
        private readonly Stack<GameCard> _cards;

        public GameConstructor()
        {
            _heroes = new List<CardHero>();
            _cards = new Stack<GameCard>();
        }

        public void AddHero(HeroCard hero)
        {
            if (hero == null)
            {
                MessageBox.Show("Hero is null");
                return;
            }
            _heroes.Add(new CardHero(hero));
        }

        public void AddCard(Card card)
        {
            if (card == null)
            {
                MessageBox.Show("Card is null");
                return;
            }
            _cards.Push(new GameCard(card));
        }

        public void Addcard(DeckJson deck)
        {
            if (deck == null)
            {
                MessageBox.Show("Deck is null");
                return;
            }

            _cards.Clear();
            foreach (var card in deck.Cards)
                _cards.Push(new GameCard(card));
        }

    }
}
