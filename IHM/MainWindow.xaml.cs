using System.Diagnostics;
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
using IHM.controllers;
using LogicLayer;

namespace IHM
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private SolitaireController controller;
         
        public MainWindow()
        {
            InitializeComponent();
            controller = new SolitaireController();
        }

        public void Next(object sender, RoutedEventArgs e)
        {
            stack.Source = controller.GetNextCardImage();
            if (stack.Source == null )
            {
                backStack.Visibility = Visibility.Visible;
            }
            if (this.controller.IsStackEmpty())
            {
                backStack.Visibility = Visibility.Hidden;
            }
            else
            {
                backStack.Visibility = Visibility.Visible;
            }
        }
    }
}