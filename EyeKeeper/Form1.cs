using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
namespace EyeKeeper
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Interval = Convert.ToInt32(textBox1.Text) * 1000 * 60;
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            SoundPlayer simpleSound = new SoundPlayer(@"start.wav");
            simpleSound.Play();
            timer2.Interval = Convert.ToInt32(textBox2.Text) * 1000 * 60;
            timer2.Enabled = true;
            
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            SoundPlayer simpleSound = new SoundPlayer(@"finish.wav");
            simpleSound.Play();
            timer2.Enabled = false;
            label3.Text = "relaxing complete!";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }
    }
}
