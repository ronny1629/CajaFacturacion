using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace login
{
    class FacturaDetalle
    {
        public int ID { set; get; }
        public int FacturaID { set; get; }
        public int ProductoID { set; get; }
        public string Producto { set; get; }
        public double Precio { set; get; }
        public double Cantidad { set; get; }
        public double SubTotal { set; get; }

    }
}
