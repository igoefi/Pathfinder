using WpfTest2012.Cards;
using WpfTest2012.Models;

namespace WpfTest2012.Game.Cards.Cards
{
    public class GameCard : CardAbstraction
    {
        public GameCard(Card card) : base(card.Name, card.Description) { }
    }
}
