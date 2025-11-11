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

namespace GitHubTest2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int fahrenheit = 0;


            fahrenheit = Convert.ToInt32(textBoxF.Text);


            listBox1.Items.Add((fahrenheit - 32) / 1.8);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int celsius = 0;

            celsius = Convert.ToInt32(textBoxC.Text);

            listBox2.Items.Add(celsius * 1.8 + 32);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBoxC.Clear();
            textBoxF.Clear();
            listBox1.Items.Clear();
            listBox2.Items.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
