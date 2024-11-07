using LogicLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace IHM.controllers
{
    public class SolitaireController
    {
        private MainStack mainStack;

        public SolitaireController()
        {
            mainStack = new MainStack();
        }

        public BitmapImage ?GetNextCardImage()
        {
            Card ?nextCard = mainStack.Next();
            BitmapImage ?image = null;
            if (nextCard != null)
            {
                CardHMI cardHMI = new CardHMI(nextCard);
                image = cardHMI.Image;
            }
            return image;
        }

        public bool IsStackEmpty() => mainStack.IsEmpty();
    }
}
