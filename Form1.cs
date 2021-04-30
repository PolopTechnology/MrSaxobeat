using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BatBeat
{
    public partial class Form1 : Form
    {
        int bpm = 0;
        bool beat = true;
        bool start = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == null)
            {
                MessageBox.Show("INPUT A BPM!");
            } 
            else
            {
                bpm = Int32.Parse(textBox1.Text);
                int f1 = bpm / 60;
                string f2 = f1.ToString();
                string[] f3 = f2.Split('.');
                int f4 = Int32.Parse(f3[0]);
                int f5 = 1000 / f4;
                int f6 = f5 / 2;
                Temmy.Interval = f6;
                start = true;
            }
        }

        private void Temmy_Tick(object sender, EventArgs e)
        {
            if(start == true)
            {
                if(beat == true)
                {
                    pictureBox8.BackColor = Color.Blue;
                    beat = false;
                }
                else if(beat == false)
                {
                    pictureBox8.BackColor = Color.Red;
                    beat = true;
                }
            }
        }
    }
}
