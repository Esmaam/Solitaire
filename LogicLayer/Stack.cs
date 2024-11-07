using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicLayer
{
    public class Stack
    {
        private List<Card> cards;
        public List<Card> Cards { get => cards; }

        public Card GetLastCard
        {
            get { return this.cards.Last(); }
        }
    }
}
