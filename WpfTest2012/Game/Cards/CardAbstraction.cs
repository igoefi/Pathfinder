namespace WpfTest2012.Cards
{
    internal abstract class CardAbstraction
    {
        public string Name { get; private set; }
        public string Description { get; private set; }

        protected CardAbstraction(string name, string description)
        {
            Name = name;
            Description = description;
        }
    }
}
