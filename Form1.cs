using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CasinoApp
{
    public partial class Form1 : Form
    {
        int a;
        public Form1()
        {
            InitializeComponent();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            Random rand1 = new Random();
            Random rand2 = new Random();
            label9.Text = rand.Next(0, 15).ToString();
            label10.Text = rand1.Next(0, 16).ToString();
            label11.Text = rand2.Next(0, 17).ToString();
            if (label13.Text=="")
            {             
                label9.Text = "";
                label10.Text = "";
                label11.Text = "";
                MessageBox.Show("PUT YOUR MONEY FIRST!");
                
            }
            else if(label9.Text==label10.Text&&label10.Text==label11.Text)
            {

                a--;
                label13.Text = a.ToString();
                MessageBox.Show("YOU WIN 50$!!!");
                if (a == 0)
                {
                    MessageBox.Show("GAME OVER! TRY AGAIN!");
                    label9.Text = "";
                    label10.Text = "";
                    label11.Text = "";
                    label13.Text = "";

                }

            }
            else
            {

                a--;
                label13.Text = a.ToString();
                if (a == 0)
                {

                    MessageBox.Show("GAME OVER! TRY AGAIN!");
                    label9.Text = "";
                    label10.Text = "";
                    label11.Text = "";
                    label13.Text = "";

                }
               
            }

        }
        private void label12_Click(object sender, EventArgs e)
        {

        }   
        private void button4_Click(object sender, EventArgs e)
        {
             a = int.Parse(textBox2.Text);
            label13.Text = a.ToString();
            textBox2.Text = "";

        }
        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }
        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void label13_Click(object sender, EventArgs e)
        {

        }
    }
}

