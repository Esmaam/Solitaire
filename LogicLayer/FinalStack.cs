using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicLayer
{
    internal class FinalStack : Stack
    {
        public bool IsComplete
        {
            get { return Cards.Count == 13; }
        }
    }
}
