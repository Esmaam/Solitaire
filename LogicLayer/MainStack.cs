using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicLayer
{
    public class MainStack
    {
        #region attributes
        const int NUMBER_MAX = 13;

        private List<Card> cards;

        private int currentCardNumber;
        #endregion

        #region properties
        public List<Card> Cards { get => cards; }
        public bool IsEmpty() => currentCardNumber >= cards.Count;
        #endregion

        #region constructor
        public MainStack()
        {
            cards = new List<Card>();
            InitCards();
            currentCardNumber = 0;
        }
        #endregion

        #region methods
        private void InitCards()
        {
            foreach (TypeSign sign in Enum.GetValues(typeof(TypeSign)))
            {
                for (int i = 0; i < NUMBER_MAX; i++)
                {
                    Card card = new Card(i + 1, sign);
                    cards.Add(card);
                }
            }

            //Shuffle();
        }

        private void Shuffle()
        {
            List<Card> shuffledCard = new List<Card>();
            Random rnd = new Random();

            while (cards.Count > 0)
            {
                int index = rnd.Next(0, cards.Count);
                shuffledCard.Add(cards[index]);
                cards.RemoveAt(index);
            }
            cards = shuffledCard;
        }

        public Card ?Next()
        {
            Card ?card = null;
            if (this.currentCardNumber < this.cards.Count)
            {
                card = this.cards[this.currentCardNumber++];
            }
            else if (this.currentCardNumber == this.cards.Count)
            {
                this.currentCardNumber = 0;
            }
            return card;
        }
        #endregion
    }
}
