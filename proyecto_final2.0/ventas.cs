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
    public partial class Form2 : Form
    {
        
        List<compras> comp = new List<compras>();
        List<compras> cat = new List<compras>();
        
        public Form2()
        {
            InitializeComponent();

           // classcompras.RemoveRange(0, classcompras.count);
            string filename = "articulos.txt";
            FileStream stream = new FileStream(filename, FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(stream);
            while (reader.Peek() > -1)
            {
                compras catemp = new compras();
                catemp.Categorias = reader.ReadLine();
                catemp.Nombre = reader.ReadLine();
                catemp.Codigo = reader.ReadLine();
                catemp.Existencia = reader.ReadLine();
                catemp.Precio = reader.ReadLine();

                comp.Add(catemp);
            }
            reader.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cat.RemoveRange(0, cat.Count);
            string filename = "articulos.txt";
            FileStream stream = new FileStream(filename, FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(stream);
            for (int i = 0; i < comp.Count; i++)
             {

                if (comboBox1.Text == comp[i].Categorias)
                {
                        compras cemp = new compras();
                        cemp.Categorias = comp[i].Categorias;
                        cemp.Nombre = comp[i].Nombre;
                        cemp.Codigo = comp[i].Codigo;
                        cemp.Existencia = comp[i].Existencia;
                        cemp.Precio = comp[i].Precio;

                        cat.Add(cemp);
                   
                }


                //for i = num delproducto
                //if combobox1 == comp[i].categoria
                //guardar nueva lista
                //data grid nueva lista

            }
            dataGridView1.DataSource = null;
            dataGridView1.Refresh();
            dataGridView1.DataSource = cat;
            dataGridView1.Refresh();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
