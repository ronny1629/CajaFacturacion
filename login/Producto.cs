using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace login
{
    class Producto
    {
        public Producto(int iD, string nombre, double precio)
        {
            ID = iD;
            Nombre = nombre;
            Precio = precio;
        }

        public int ID { set; get; }
        public string Nombre { set; get; }
        public double Precio { set; get; }
       
    }
}
