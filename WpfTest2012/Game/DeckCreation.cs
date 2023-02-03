using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Documents;
using WpfTest2012.Game.JsonDB;
using WpfTest2012.Models;

namespace WpfTest2012.Game
{
    internal class DeckCreation
    {
        private readonly DeckJson _deckJson;
        private readonly Deck _deck;

        private readonly Card[] _mainCards = DataBaseConnectContext.ConnectContext.Card.ToArray();

        public List<Card> GetCards() => _deckJson.GetCards();

        public DeckCreation(Deck deck)
        {
            _deckJson = new DeckJson();
            _deck = deck;
        }

        public void RemoveCard(string cardName)
        {
            Card needCard = FindCard(cardName);

            if (needCard == null)
                MessageBox.Show("Card is not found");
            else
                _deckJson.RemoveCard(needCard);
        }

        public void AddCard(string cardName)
        {
            Card needCard = FindCard(cardName);

            if (needCard == null)
                MessageBox.Show("Card is not found");
            else
                _deckJson.AddCard(needCard);
        }

        public bool Save()
        {
            try
            {
                MessageBox.Show("Save");
                _deck.JsonArray = JsonConvert.SerializeObject(_deckJson);
                DataBaseConnectContext.ConnectContext.Deck.Add(_deck);
                DataBaseConnectContext.ConnectContext.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public Card FindCard(string cardName)
        {
            if (cardName == null) return null;

            Card needCard = null;
            foreach (Card card in _mainCards)
                if (card.Name == cardName)
                {
                    needCard = card;
                    break;
                }
            return needCard;
        }
    }
}
