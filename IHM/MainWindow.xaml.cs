using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using LogicLayer;

namespace IHM
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Card card = new Card(1, TypeSign.CLUB);
            CardHMI cardHMI = new CardHMI(card);
            this.test.Source = cardHMI.Image;
        }

        public void Next(object sender, RoutedEventArgs e)
        {
            // Generate a random card number
            Random rndNumber = new Random();
            int number = rndNumber.Next(1,14);

            // Generate a random card sign
            Array values = Enum.GetValues(typeof(TypeSign));
            Random rndSign = new Random();
            TypeSign sign = (TypeSign)values.GetValue(rndSign.Next(values.Length));
            
            // Creates a new card
            Card card = new Card(number, sign);
            CardHMI cardHMI = new CardHMI(card);

            // Display the card
            this.test.Source = cardHMI.Image;
        }
    }
}