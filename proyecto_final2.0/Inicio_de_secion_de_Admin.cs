using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyecto_final2._0
{
    public partial class Inicio_de_secion_de_Admin : Form
    {
        public Inicio_de_secion_de_Admin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtadmc.Text =="4770" && txtadm.Text == "Erick")
            {

                Form2 f = new Form2();
                f.Show();
            }
            else
            {
                label4.Text = "no existe: ";
            }
        }
    }
}
