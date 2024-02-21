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

namespace SEW02_07_07_Personenliste
{

    public partial class MainWindow : Window
    {

        private List<Person> personlist = new List<Person>();

        public MainWindow()
        {
            InitializeComponent();
            
        }

        

        private void btnadd_Click(object sender, RoutedEventArgs e)
        {

            Person p1 = new Person(tbxvorname.Text, tbxnachname.Text, dtpbirthday.Text);

            personlist.Add(p1);

            lbxlist.Items.Add(p1.tostring());
            

        }

        private void btnclear_Click(object sender, RoutedEventArgs e)
        {
            tbxvorname.Text = "";
            tbxnachname.Text = "";
            dtpbirthday.Text = "";

            lbxlist.Items.Clear();
        }
    }

    public class Person
    {
        private string fname;
        private string lname;
        private string bday;

        

        public Person(string fname, string lname, string bday)
        {

            this.fname = fname;
            this.lname = lname;
            this.bday = bday;

        }

        public string tostring()
        {
            string str = $"{this.fname} {this.lname} {this.bday}";
            return str;
        }




    }
}