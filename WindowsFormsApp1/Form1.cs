using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        decimal firstNumber,secondNumber,result;

        int opp; // 1 plus, 2 mınus, 3 multıply, 4 divison

        int start = 0;



        private void baslama() 
        {
            if (textadsoyad.Text.Trim() == string.Empty || textemail.Text.Trim() == string.Empty || textyas.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Lutfen gereklı alanları doldurunuz");
            }

        }

        private void Starts(string number)
        {
            if (Informatıonlabel.Text.Trim() != string.Empty)
                Informatıonlabel.Text = string.Empty;

            if (textdeger.Text == "0")
                textdeger.Text = number ;
            else
                textdeger.Text += number ;


        }


        private void groupBox1_Enter(object sender, EventArgs e)
        {
            
            if (start == 0)
            {
                start++;
            }
            else
            {
                baslama();
            }
            
            
        }
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabel1.LinkVisited = true;
            System.Diagnostics.Process.Start("https://www.google.com/url?sa=i&url=https%3A%2F%2Fflamingtext.com%2FWord-Logos%2Finformation%2F&psig=AOvVaw1zbBWVWHyhVO-NbDZG50f1&ust=1698954152914000&source=images&cd=vfe&opi=89978449&ved=0CBEQjRxqFwoTCLCaqsnHo4IDFQAAAAAdAAAAABAE");

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            int years = DateTime.Now.Year - dateTimePicker1.Value.Year;
            textyas.Text = years.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Starts("1");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Starts("2");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Starts("3");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Starts("4");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Starts("5");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Starts("6");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Starts("7");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Starts("8");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Starts("9");
        }
        private void buttonzero_Click(object sender, EventArgs e)
        {
            Starts("0");
        }
        private void buttonplus_Click(object sender, EventArgs e)
        {
            if (textdeger.Text.Trim() == string.Empty || textdeger.Text.Trim() == "0")
                MessageBox.Show("Lutfen hesaplanacak degerlerı gırınız", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            firstNumber = Convert.ToDecimal(textdeger.Text);
            opp = 1;

            textdeger.Text = "";
            Informatıonlabel.Text = "Please enter other value";
        }

        private void buttonequal_Click(object sender, EventArgs e)
        {
            if (textdeger.Text.Trim() == string.Empty || textdeger.Text.Trim() == "0")
                MessageBox.Show("Lutfen hesaplanacak degerlerı gırınız", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            secondNumber = Convert.ToDecimal(textdeger.Text.Trim());

            Hesapla();
            
        }

        private void Hesapla() 
        {
            switch (opp)
            {
                case 1:
                    result = firstNumber + secondNumber;
                    break;
                case 2:
                    result = firstNumber - secondNumber;
                    break;
                case 3:
                    result = firstNumber * secondNumber;
                    break;
                case 4:
                    result = firstNumber / secondNumber;
                    break;

                default:
                    break;
            }
            textdeger.Text = result.ToString();
        }

        private void buttonminus_Click(object sender, EventArgs e)
        {
            if (textdeger.Text.Trim() == string.Empty || textdeger.Text.Trim() == "0")
                MessageBox.Show("Lutfen hesaplanacak degerlerı gırınız", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            firstNumber = Convert.ToDecimal(textdeger.Text);
            opp = 2;

            textdeger.Text = "";
            Informatıonlabel.Text = "Please enter other value";
        }


        private void buttonmultıply_Click(object sender, EventArgs e)
        {
            if (textdeger.Text.Trim() == string.Empty || textdeger.Text.Trim() == "0")
                MessageBox.Show("Lutfen hesaplanacak degerlerı gırınız", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            firstNumber = Convert.ToDecimal(textdeger.Text);
            opp = 3;

            textdeger.Text = "";
            Informatıonlabel.Text = "Please enter other value";
        }

        private void buttonclear_Click(object sender, EventArgs e)
        {
            firstNumber = 0.0m;
            secondNumber = 0.0m;
            opp = 0;
            textdeger.Text = "0";
        }

        private void Pointbutton_Click(object sender, EventArgs e)
        {
            if (textdeger.Text != "0" )
            {
                if (!textdeger.Text.Contains("."))
                    textdeger.Text += ".";
            }
                
        }

        private void textadsoyad_Leave(object sender, EventArgs e)
        {
            if (textadsoyad.Text == "")
            {
                MessageBox.Show("Lutfen adınızı soyadınızı giriniz");
                textadsoyad.Focus();
            }

        }

        private void textemail_Leave(object sender, EventArgs e)
        {
            if (textemail.Text == "")
            {
                MessageBox.Show("Lutfen emailinizi giriniz");
                textemail.Focus();
            }

        }

        private void dateTimePicker1_Leave(object sender, EventArgs e)
        {
            int years = DateTime.Now.Year - dateTimePicker1.Value.Year;
            if (years == Convert.ToInt32(DateTime.Now.Year))
            {

                MessageBox.Show("Lutfen dogum tarihinizi giriniz");

            }
            if (dateTimePicker1.Value == DateTime.MaxValue)
            {
                
                MessageBox.Show("Lutfen dogum tarihinizi giriniz");
                
            }
            

        }

        private void buttondivide_Click(object sender, EventArgs e)
        {
            if (textdeger.Text.Trim() == string.Empty || textdeger.Text.Trim() == "0")
                MessageBox.Show("Lutfen hesaplanacak degerlerı gırınız", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            firstNumber = Convert.ToDecimal(textdeger.Text);
            opp = 4;

            textdeger.Text = "";
            Informatıonlabel.Text = "Please enter other value";
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
