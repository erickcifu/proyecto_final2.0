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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked && !checkBox2.Checked)
            {
                inicio_de_secion f = new inicio_de_secion();
                f.Show();
            }
            else if (checkBox2.Checked && !checkBox1.Checked)
            {
                Inicio_de_secion_de_Admin a = new Inicio_de_secion_de_Admin();
                a.Show();
            }
            else if (checkBox2.Checked && checkBox1.Checked)
            {
                label1.Text = "no puedes seleccionar ambos";
            }
            else
            {
                label1.Text = "valor no ingresado";

            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
