using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfTest2012.Models;

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
