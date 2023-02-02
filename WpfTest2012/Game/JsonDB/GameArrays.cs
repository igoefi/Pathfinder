using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfTest2012.Cards;
using WpfTest2012.Game.Cards.Cards;

namespace WpfTest2012.Game
{
    [Serializable]
    internal class GameArrays
    {
        public CardHero[] Heroes { get; private set; }
        public Stack<GameCard> Deck { get; private set; }

        public GameArrays(CardHero[] heroes, Stack<GameCard> deck) 
        {
            Heroes = heroes;
            Deck = deck;
        }
    }
}
