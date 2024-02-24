using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SEW02_07_08_Tictactoe
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        private int turn;

        public MainWindow()
        {
            InitializeComponent();

            turn = 0;
        }

        

        
        private void redturn(Button pressedbutton)
        {
            pressedbutton.Content = "O";
            pressedbutton.Background = new SolidColorBrush(Colors.Red);


        }

        private void blueturn(Button pressedbutton)
        {
            pressedbutton.Content = "X";
            pressedbutton.Background = new SolidColorBrush(Colors.Blue);


        }

        private void btntopleft_Click(object sender, RoutedEventArgs e)
        {
            Button pressedbutton = e.Source as Button;

            if (turn % 2 == 0 && pressedbutton.Content == null) 
            {
                blueturn(pressedbutton);
                turn++;
                tbkturn.Background = new SolidColorBrush(Colors.Red);
            }
            else if (turn % 2 == 1 && pressedbutton.Content == null)
            {
                redturn(pressedbutton);
                turn++;
                tbkturn.Background = new SolidColorBrush(Colors.Blue);
            }

           

        }

        private void btntopmid_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btntopright_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnmidleft_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnmidmid_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnmidright_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnbotleft_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnbotmid_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnbotright_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
