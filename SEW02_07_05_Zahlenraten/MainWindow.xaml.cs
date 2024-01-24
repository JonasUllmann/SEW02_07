using System.Security.Cryptography;
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
using System.Windows.Threading;

namespace SEW02_07_05_Zahlenraten
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int time;
        int tries;
        int rndmnum;




        public MainWindow()
        {
            InitializeComponent();
            start();


        }
        DispatcherTimer timer = new DispatcherTimer();
        public void timersetupandstart()
        {
            DateTime start = DateTime.Now;
            
            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += timer_Tick;
            timer.Start();
        }
        

        void timer_Tick(object sender, EventArgs e)
        {
            time++;
            tbltimer.Text = time.ToString() + " Sek.";
        }

        public void start()
        {
            Random rnd = new Random();
            int rndmnum = rnd.Next(1, 100);
            //tblsolution.Text = rndmnum.ToString();
            int tries = 0;

        }
        



        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
            
            if(tries == 0)
            {
                timersetupandstart();
            }


            if (Guess.Text == "")
            {
                Hint.Text = "Du hast nichts eingegeben!";
            }


            else if (Convert.ToUInt32(Guess.Text) > 100 || Convert.ToUInt32(Guess.Text) < 0)
            {
                Hint.Text = $"Deine Eingabe {Convert.ToUInt32(Guess.Text)} ist entweder kein Text oder außerhalb des Intervalls";
            }

            else if (Convert.ToUInt32(Guess.Text) > rndmnum)
            {
                Hint.Text = $"Deine Eingabe {Convert.ToUInt32(Guess.Text)} ist größer als die gesuchte Zahl!";
                tries++;
            }

            else if (Convert.ToUInt32(Guess.Text) < rndmnum)
            {
                Hint.Text = $"Deine Eingabe {Convert.ToUInt32(Guess.Text)} ist kleiner als die gesuchte Zahl!";
                tries++;
            }

            else if (Convert.ToUInt32(Guess.Text) == rndmnum)
            {
                Hint.Text = $"Du hast {rndmnum} erraten!";
                tries++;
                timer.Stop();
            }


            Triesblock.Text = tries.ToString();
            

        }
    }
}