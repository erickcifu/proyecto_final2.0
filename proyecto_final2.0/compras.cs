using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto_final2._0
{
    class compras
    {   string categorias;
        string nombre;
        string codigo;
        string existencia;
        string precio;

        public string Nombre { get => nombre; set => nombre = value; }
        public string Codigo { get => codigo; set => codigo = value; }
        public string Existencia { get => existencia; set => existencia = value; }
        public string Precio { get => precio; set => precio = value; }
        public string Categorias { get => categorias; set => categorias = value; }
    }
}
