using WpfTest2012.Models;

namespace WpfTest2012.Cards
{
    public class CardHero : CardAbstraction
    {
        public CardHero(HeroCard card) : base(card.Name, card.Description) { }
    }
}
