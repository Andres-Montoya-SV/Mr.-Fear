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
    public partial class Form2 : Form
    {
        int pbCOMPLETE = 0;
        Timer T = new Timer();
        public Form2()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            T.Interval = 50;
            T.Tick += new EventHandler(this.T_Tick);
            T.Start();
        }

        private void T_Tick(object sender, EventArgs e)
        {
            pbCOMPLETE++;
            if (pbCOMPLETE > 100)
            {
                Inicio F3 = new Inicio();
                T.Stop();
                this.Hide();
                F3.Show();
            }

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
