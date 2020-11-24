using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Příklad___4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int cislo = int.Parse(comboBox1.SelectedItem.ToString());
            int cislo1 = int.Parse(textBox1.Text);
            int cislo2 = int.Parse(textBox2.Text);
            int cislo3 = int.Parse(textBox3.Text);
            int mv = cislo1;
            for (int i = cislo; i > 1; i--)
            {
                cislo1 *= mv;
            }
            mv = cislo2;
            for (int i = cislo; i > 1; i--)
            {
                cislo2 *= mv;
            }
            mv = cislo3;
            for (int i = cislo; i > 1; i--)
            {
                cislo3 *= mv;
            }
            label1.Text = "Číslo 1: " + cislo1 +Environment.NewLine + "Číslo 2: " + cislo2 +Environment.NewLine + "Číslo 3: " + cislo3;
        }
    }
}
