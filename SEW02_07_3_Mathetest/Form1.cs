using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SEW02_07_3_Mathetest
{
    public partial class Form1 : Form
    {

        Random rnd = new Random();

        int addend1;
        int addend2;
        
        int minuend;
        int subtrahend;

        int multiplicand;
        int multiplier;

        int dividend;
        int divisor;

        int timeLeft;

        public void quizstart()
        {
            addend1 = rnd.Next(51);
            addend2 = rnd.Next(51);
            
            plusLeftLabel.Text = addend1.ToString();
            plusRightLabel.Text = addend2.ToString();
            sum.Value = 0;


            minuend = rnd.Next(1, 101);
            subtrahend = rnd.Next(1, minuend);
            leftSubLabel.Text = minuend.ToString();
            rightSubLabel.Text = subtrahend.ToString();
            difference.Value = 0;

            multiplicand = rnd.Next(2, 11);
            multiplier = rnd.Next(2, 11);
            leftMultLabel.Text = multiplicand.ToString();
            rightMultLabel.Text = multiplier.ToString();
            product.Value = 0;

            divisor = rnd.Next(2, 11);
            int temporaryQuotient = rnd.Next(2, 11);
            dividend = divisor * temporaryQuotient;
            leftDivLabel.Text = dividend.ToString();
            rightDivLabel.Text = divisor.ToString();
            quotient.Value = 0;

            timeLeft = 30;
            timeLabel.Text = "30 seconds";
            timer1.Start();
        }

        public bool check()
        {

            if ((addend1 + addend2 == sum.Value)
                && (minuend - subtrahend == difference.Value)
                && (multiplicand * multiplier == product.Value)
                && (dividend / divisor == quotient.Value))
            {
                return true;
            }

            else
                return false;

        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void startButton_Click(object sender, EventArgs e)
        {

            quizstart();
            startButton.Enabled = false;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (check())
            {

                timer1.Stop();
                MessageBox.Show("You got all the answers right!",
                                "Congratulations!");
                startButton.Enabled = true;
            }
            else if (timeLeft > 0)
            {

                timeLeft = timeLeft - 1;
                timeLabel.Text = timeLeft + " seconds";
            }
            else
            {

                timer1.Stop();
                timeLabel.Text = "Time's up!";
                MessageBox.Show("You didn't finish in time.", "Sorry!");
                sum.Value = addend1 + addend2;
                difference.Value = minuend - subtrahend;
                product.Value = multiplicand * multiplier;
                quotient.Value = dividend / divisor;
                startButton.Enabled = true;
            }
        }
    }
}
