using System;
using System.Windows.Forms;

namespace příklad___1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string pismena = " .,MNBVCXY!?LKJHGFDSAPOIUZTREWQ";
            int i = 0;
            foreach (Control ctrl in panel1.Controls)
            {
                if (ctrl is Button)
                    (ctrl as Button).Text = pismena[i].ToString();
                i++;
            }
        }

        private void OnClick_key(object sender, EventArgs e)
        {
            textBox1.Text += (sender as Button).Text;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                textBox2.Text = "";
                string text = textBox1.Text;
                foreach (char znak in text)
                {
                    int ascii = Convert.ToInt32(znak);
                    if (ascii >= 88 && ascii <= 90)
                        ascii -= 23;
                    else if (znak != '?' && znak != '!' && znak != ',' && znak != '.' && znak != ' ')
                    {
                        ascii += 3;
                    }
                    textBox2.Text += Convert.ToChar(ascii);
                }
            }
        }
    }
}
