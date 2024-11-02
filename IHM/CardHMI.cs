using LogicLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace IHM
{
    internal class CardHMI
    {
        private Card card;

        public BitmapImage Image
        {
            get
            {
                BitmapImage image = new BitmapImage();
                image.BeginInit();
                switch (this.card.Sign)
                {
                    case TypeSign.HEART: image.UriSource = new Uri($"pack://application:,,,/IHM;component/img/cards/{this.card.Number}_of_hearts.png", UriKind.Absolute); break;
                    case TypeSign.SPADE: image.UriSource = new Uri($"pack://application:,,,/IHM;component/img/cards/{this.card.Number}_of_spades.png", UriKind.Absolute); break;
                    case TypeSign.CLUB: image.UriSource = new Uri($"pack://application:,,,/IHM;component/img/cards/{this.card.Number}_of_clubs.png", UriKind.Absolute); break;
                    case TypeSign.DIAMOND: image.UriSource = new Uri($"pack://application:,,,/IHM;component/img/cards/{this.card.Number}_of_diamonds.png", UriKind.Absolute); break;
                }
                image.EndInit();
                return image;
            }
        }

        public CardHMI(Card card)
        {
            this.card = card;
        }
    }
}
