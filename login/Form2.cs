using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace login
{
    public partial class Form2 : Form
    {
        private List<Cliente> clientes = new List<Cliente>();
        private List<Producto> productos = new List<Producto>();
        
        public Form2()
        {
            InitializeComponent();
            this.llenarListaCliente();
            this.mostrarClienteDGV();
            this.llenarListaProducto();
            this.mostrarProductoDVG();
        }

        public void llenarListaCliente()
        {
            this.clientes.Add(new Cliente(1, "Ronny","Marte"));
            this.clientes.Add(new Cliente(2, "Pedro ", "Martinez"));
            this.clientes.Add(new Cliente(3, "Juan", "Peguero"));
        }

        public void llenarListaProducto()
        {
            this.productos.Add(new Producto(1,"Batata", 20.30));
            this.productos.Add(new Producto(2,"Salami", 50.60));
            this.productos.Add(new Producto(3, "Habichuela", 60.75));
        }
        public void mostrarClienteDGV()
        {
            this.dataGridView1.DataSource = this.clientes;
        }

        public void mostrarProductoDVG()
        {
            this.dataGridView2.DataSource = this.productos;
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {


            
        }
    }
}
