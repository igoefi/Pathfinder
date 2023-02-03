using System;
using System.Collections.Generic;
using System.Windows;
using WpfTest2012.Game.Cards.Cards;
using WpfTest2012.Models;

namespace WpfTest2012.Game.JsonDB
{
    [Serializable]
    internal class DeckJson
    {
        public List<Card> Cards;

        public DeckJson() =>
            Cards = new List<Card>();

        public List<Card> GetCards() => Cards;

        public void AddCard(Card card)
        {
            if (!CheckCard(card)) return;

            Cards.Add(card);
        }

        public void RemoveCard(Card card)
        {
            if (!CheckCard(card)) return;

            Cards.Remove(card);
        }

        private bool CheckCard(Card card)
        {
            if (card == null)
            {
                MessageBox.Show("Card is null");
                return false;
            }
            return true;
        }
    }
}
