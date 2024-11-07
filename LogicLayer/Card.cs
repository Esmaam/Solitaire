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
        public TypeSign Sign { get => sign; }

        public TypeColor Color
        {
            get
            {
                TypeColor color = TypeColor.NULL;
                switch (sign)
                {
                    case TypeSign.HEART: color = TypeColor.RED; break;
                    case TypeSign.DIAMOND: color = TypeColor.RED; break;
                    case TypeSign.SPADE: color = TypeColor.BLACK; break;
                    case TypeSign.CLUB: color = TypeColor.BLACK; break;
                }
                return color;
            }
        }
        public int Number { get => number; set => number = value; }
        #endregion

        #region constructor
        public Card(int number, TypeSign sign)
        {
            this.number = number;
            this.sign = sign;
        }
        #endregion

        #region methods
        public bool IsStackableColumn(Stack column)
        {
            bool res = false;

            if (this.Color != column.GetLastCard.Color && Number != column.GetLastCard.Number - 1)
            {
                res = true;
            }

            return res;
        }

        public bool IsStackableFinalStack(Stack finalStack)
        {
            bool res = false;

            if (this.Sign == finalStack.GetLastCard.Sign && Number == finalStack.GetLastCard.Number + 1)
            {
                res = true;
            }

            return res;
        }
        #endregion
    }
}
