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

namespace SEW02_07_06_Catchme
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        private Random rnd;

        public MainWindow()
        {
            InitializeComponent();

            rnd = new Random();
        }

        private void btnCatchme_MouseEnter(object sender, MouseEventArgs e)
        {

            

            btnCatchme.Margin = new Thickness(rnd.Next(1, 700), rnd.Next(1, 350), 0, 0);

            

        }

        private void btnCatchme_Click(object sender, RoutedEventArgs e)
        {
            meinmain.Background = new SolidColorBrush(Colors.Red);
        }
    }
}