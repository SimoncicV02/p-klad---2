using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace příklad___3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int pocet = 0;
            double prumer = 0;
            foreach (Control ctrl in groupBox1.Controls)
            {
                if (ctrl is TextBox && (ctrl as TextBox).Text != "")
                {
                    prumer += int.Parse((ctrl as TextBox).Text);
                    pocet++;
                }
            }
            if (pocet != 0)
                prumer = prumer / pocet;
            label7.Text = "Průměr: " + prumer;

            string text = "";
            foreach (string item in listBox1.SelectedItems)
                text += item + ", ";

            foreach (Control ctrl in groupBox1.Controls)
                if (ctrl is Label)
                    (ctrl as Label).Text = text;
        }
    }
}
