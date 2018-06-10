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
    public partial class inicio_de_secion : Form
    {
        List<vendedor> vent1 = new List<vendedor>();
        public inicio_de_secion()
        {
            InitializeComponent();
        }

        private void inicio_de_secion_Load(object sender, EventArgs e)
        {

            string fileName = @"C:\Users\erick\source\repos\proyecto_final2.0\proyecto_final2.0\bin\Debug\datvend.txt";

            FileStream stream = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(stream);
            while (reader.Peek() > -1)
            {
                //Leer los datos y guardarlos en un temporal
                vendedor clientetemp = new vendedor();
                clientetemp.Usuario = reader.ReadLine();
                clientetemp.Nit1 = reader.ReadLine();
                clientetemp.Clave = reader.ReadLine();
                clientetemp.Correo = reader.ReadLine();
                clientetemp.Dpi1 = reader.ReadLine();

                //Agregar a la lista el temporal
                vent1.Add(clientetemp);


            }
            reader.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {

            crear_cuenta f = new crear_cuenta();
            f.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < vent1.Count; i++)
            {

                if (txtcont.Text == vent1[i].Clave && txtusu.Text == vent1[i].Usuario)
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
}
