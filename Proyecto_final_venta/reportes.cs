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
            string query = "select codProducto, cantidad, precioCompra from Producto";
            SqlCommand comando = new SqlCommand(query, conexion);
            SqlDataAdapter data = new SqlDataAdapter(comando);
            DataTable dt = new DataTable();
            data.Fill(dt);
            dgv_resul.DataSource = dt;
        }

        private void re_ven_Click(object sender, EventArgs e)
        {
            string query = "select codProducto, fechaVencimiento from Producto";
            SqlCommand comando = new SqlCommand(query, conexion);
            SqlDataAdapter data = new SqlDataAdapter(comando);
            DataTable dt = new DataTable();
            data.Fill(dt);
            dgv_resul.DataSource = dt;
        }
    }
}
