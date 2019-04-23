using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Crea_Codigo
{
    public partial class Form4 : Form
    {
        int counter = 0;
        int Longi = 0;
        String txt;
        public Form4()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            counter++;
            if (counter > Longi)
            {
                counter = 0;
                timer1.Stop();

            }
            else
            {
                label2.Text = txt.Substring(0, counter);
            }
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            txt = label2.Text;
            Longi = txt.Length;
            label2.Text = "";
            timer1.Start();
        }
    }
}
