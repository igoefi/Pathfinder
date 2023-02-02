﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfTest2012.Cards;
using WpfTest2012.Models;

namespace WpfTest2012.Game.Cards.Cards
{
    internal class GameCard : CardAbstraction
    {
        public GameCard(Card card) : base(card.Name, card.Description) { }
    }
}