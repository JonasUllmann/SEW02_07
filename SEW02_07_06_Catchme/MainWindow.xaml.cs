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
        public MainWindow()
        {
            InitializeComponent();
        }



        private void button1_MouseEnter(object sender, MouseEventArgs e)
        {
            int maxLeft = Convert.ToInt32(Grid.ActualWidth - button1.Width);
            int maxTop = Convert.ToInt32(Grid.ActualHeight - button1.Height);
            Random rand = new Random();
            button1.Margin = new Thickness(rand.Next(maxLeft), rand.Next(maxTop), 0, 0);
        }
    }
}