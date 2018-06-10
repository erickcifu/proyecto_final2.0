using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace proyecto_final2._0
{   
    public partial class crear_cuenta : Form
    {
        List<vendedor> vent = new List<vendedor>();
        public crear_cuenta()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            vendedor Atemp = new vendedor();
            Atemp.Usuario = txtusuario.Text;
            Atemp.Nit1 = txtnit.Text;
            Atemp.Clave = txtclave.Text;
            Atemp.Correo = txtcorreo.Text;
            Atemp.Dpi1 = txtdpi.Text;
            vent.Add(Atemp);

            string fileName = "datvend.txt";

            FileStream stream = new FileStream(fileName, FileMode.Append, FileAccess.Write);
            StreamWriter writer = new StreamWriter(stream);
            for (int i = 0; i < vent.Count; i++)
            {
                writer.WriteLine(vent[i].Usuario);
                writer.WriteLine(vent[i].Nit1);
                writer.WriteLine(vent[i].Clave);
                writer.WriteLine(vent[i].Correo);
                writer.WriteLine(vent[i].Dpi1);
            }
            writer.Close();
            MessageBox.Show("guardado exitosamente");
        }

        private void cargar_Click(object sender, EventArgs e)
        {

        }
    }
}
