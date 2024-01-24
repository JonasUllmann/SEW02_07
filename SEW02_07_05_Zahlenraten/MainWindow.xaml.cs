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

namespace SEW02_07_05_Zahlenraten
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        

        public MainWindow()
        {
            InitializeComponent();
            
        }

        public int randomgen()
        {
            Random rnd = new Random();
            int a = rnd.Next(1, 100);

            return a;
        }

        int rndmnum = 12;
        
        int tries = 0;


        private void Button_Click(object sender, RoutedEventArgs e)
        {

            if (Convert.ToUInt32(Guess.Text) == rndmnum)
            {
                Hint.Text = $"Du hast {rndmnum} erraten!";
            }

            else if(Convert.ToUInt32(Guess.Text) > 100 || Convert.ToUInt32(Guess.Text) < 0)
            {
                Hint.Text = $"Deine Eingabe {Convert.ToUInt32(Guess.Text)} ist entweder kein Text oder außerhalb des Intervalls";
            }

            else if (Convert.ToUInt32(Guess.Text) > rndmnum)
            {
                Hint.Text = $"Deine Eingabe {Convert.ToUInt32(Guess.Text)} ist größer als die gesuchte Zahl!";
            }

            else if (Convert.ToUInt32(Guess.Text) < rndmnum)
            {
                Hint.Text = $"Deine Eingabe {Convert.ToUInt32(Guess.Text)} ist kleiner als die gesuchte Zahl!";
            }

        }
    }
}