using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace příklad___2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listBox1.Items.Clear();            
            Random nh = new Random();

            for (int i = 0; i < 10; i++)
            {
                int x = nh.Next(0, 11);
                listBox1.Items.Add(x);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int soucet = 0;
            foreach(int a in listBox1.SelectedItems)
            {
                soucet += a;
            }
            label1.Text = "Počet vybraných položek: " + listBox1.SelectedItems.Count;
            label2.Text = "Součet vybraných položek: " + soucet;
        }
    }
}
