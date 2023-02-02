using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using WpfTest2012.Game.Cards.Cards;
using WpfTest2012.Models;

namespace WpfTest2012.Game.JsonDB
{
    [Serializable]
    internal class DeckJson
    {
        public List<GameCard> Cards;

        public DeckJson() =>
            Cards= new List<GameCard>();

        public void AddCard(Card card)
        {
            if (!CheckCard(card)) return;

            Cards.Add(new GameCard(card));
        }

        public void RemoveCard(Card card)
        {
            if (!CheckCard(card)) return;

            Cards.Remove(new GameCard(card));
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
