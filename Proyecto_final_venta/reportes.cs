using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

using System.Data.SqlClient;

namespace Proyecto_final_venta
{
    public partial class reportes : Form
    {
        static string conexionstr = "server = DARK-AHSOIZ\\SQLEXPRESS ; database = DataBase_DS ; integrated security = true";
        SqlConnection conexion = new SqlConnection(conexionstr);
        public reportes()
        {
            
            InitializeComponent();
            conexion.Open();
        }

        private void reportes_Load(object sender, EventArgs e)
        {
           
        }

        private void re_comp_Click(object sender, EventArgs e)
        {
            string query = "select * from Compra";
            SqlCommand comando = new SqlCommand(query, conexion);
            SqlDataAdapter data = new SqlDataAdapter(comando);
            DataTable dt = new DataTable();
            data.Fill(dt);
            dgv_resul.DataSource = dt;
            viewcompra com = new viewcompra();
            com.Show();



        }

        private void re_ven_Click(object sender, EventArgs e)

        {
            var fecha = DateTime.Now;
            var Date = fecha.Date.ToString("yyyy-MM-dd");


            string query = "delete reportven insert into reportven(codProducto, cantidad, descripcionProducto, precioCompra, fechaVencimiento) select codProducto, cantidad, descripcionProducto, precioCompra, fechaVencimiento from Producto where fechaVencimiento < '"+Date+"' ";
            SqlCommand comando = new SqlCommand(query, conexion);
            SqlDataAdapter data = new SqlDataAdapter(comando);
            DataTable dt = new DataTable();
            data.Fill(dt);
            dgv_resul.DataSource = dt;

            viewvencido ven = new viewvencido();
            ven.Show();


        }

        private void reporte_inv_Click(object sender, EventArgs e)
        {
            viewinventario inven = new viewinventario();
            inven.Show();
            
        }

        private void btn_prov_Click(object sender, EventArgs e)
        {
            string query = "delete reportprov insert into reportprov(telefono, nomProveedor, codProducto, descripcionProducto, precioCompra) select telefonoProveedor, nomProveedor, codProducto, descripcionProducto, precioCompra from Proveedor inner join Producto on Producto.codProveedor = Proveedor.codProveedor order by(nomProveedor)";
            SqlCommand comando = new SqlCommand(query, conexion);
            SqlDataAdapter data = new SqlDataAdapter(comando);
            DataTable dt = new DataTable();
            data.Fill(dt);
            dgv_resul.DataSource = dt;

            viewprov prov = new viewprov();
            prov.Show();
        }
    }
}
