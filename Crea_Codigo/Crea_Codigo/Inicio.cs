using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Crea_Codigo
{
    public partial class Inicio : Form
    {
        String Usuario;
        String Pas;
        public Inicio()
        {
            InitializeComponent();
            Pass_txt.PasswordChar = '*';

        }

        private void Inicio_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            Pass_txt.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Usuario = textBox1.Text;
            Pas = Pass_txt.Text;

            if (Usuario != "Mr_Fear" || Pas != "123")
            {
                MessageBox.Show("No eres Fear...");
            }
            else if(Usuario == "" || Pas == "")
            {
                MessageBox.Show("No pueden haber campos vacíos...");
            }

            if (Usuario == "Mr_Fear" && Pas == "123")
            {
                MessageBox.Show("Bienvenido Fear");
            }

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form3 F4 = new Form3();
            this.Hide();
            F4.Show();
        }
    }
}
