using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace login
{
    class Factura
    {
        public int ID { set; get; }
        public int CienteID { set; get; }
        public int UsuarioID { set; get; }
        public float Total { set; get; }
    }
}
