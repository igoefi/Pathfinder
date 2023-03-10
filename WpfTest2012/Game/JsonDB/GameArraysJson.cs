using System;
using System.Collections.Generic;
using WpfTest2012.Cards;
using WpfTest2012.Game.Cards.Cards;

namespace WpfTest2012.Game
{
    [Serializable]
    public class GameArraysJson
    {
        public List<CardHero> Heroes;
        public Stack<GameCard> Deck;

        public GameArraysJson(List<CardHero> heroes, Stack<GameCard> deck)
        {
            Heroes = heroes;
            Deck = deck;
        }
    }
}
