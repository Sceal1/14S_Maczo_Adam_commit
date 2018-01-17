using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _14SMaczoAdamOrai_01_17
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void okButton_Click(object sender, EventArgs e)
        {
            List<Hiba> lista = new List<Hiba>();
            if (!String.IsNullOrWhiteSpace(hibaBox.Text) && !String.IsNullOrWhiteSpace(bejelentesBox.Text) && !String.IsNullOrWhiteSpace(leirasBox.Text))
            {
                lista.Add(new Hiba(hibaBox.Text, bejelentesBox.Text, leirasBox.Text));
                hibaBox.Text = "";
                bejelentesBox.Text = "";
                leirasBox.Text = "";
            }
            else {
                MessageBox.Show("Valami probléma adódott. Sad react");
            }
            
        }
    }
}
