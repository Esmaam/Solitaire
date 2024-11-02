using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicLayer
{
    public class Card
    {
        #region attributes
        private TypeSign sign;

        private int number;
        #endregion

        #region properties
        public TypeSign Sign { get => sign; set => sign = value; }
        public int Number { get => number; set => number = value; }
        #endregion

        #region constructor
        public Card(int number, TypeSign sign) 
        { 
            this.number = number;
            this.sign = sign;
        }
        #endregion
    }
}
