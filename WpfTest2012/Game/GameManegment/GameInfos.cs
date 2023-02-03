using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfTest2012.Cards;
using WpfTest2012.Game.Cards.Cards;
using WpfTest2012.HelperClasses;
using WpfTest2012.Models;

namespace WpfTest2012.Game.GameManegment
{
    internal class GameInfos
    {
        private Stack<GameCard> _deck;
        private List<CardHero> _heroes;

        private User _user;
        public GameInfos(GameArrays arrays, User user)
        {
            _deck = arrays.Deck;
            _heroes = arrays.Heroes.ToList();

            _user = user;
        }

        public void Save()
        {
            var arrays = new GameArrays(_heroes, _deck);
            SaveCotroller.SaveGameInUser(arrays, _user);
        }
    }
}
