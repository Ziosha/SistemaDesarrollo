using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Proyecto_final_venta
{
    public partial class productomodificar : Form
    {
        static string conexionstr = "server = DARK-AHSOIZ\\SQLEXPRESS ; database = DataBase_DS ; integrated security = true";
        SqlConnection conexion = new SqlConnection(conexionstr);
        public productomodificar()
        {
            InitializeComponent();
            conexion.Open();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string query = "update Producto set codProveedor = "+txt_idprov.Text+", descripcionProducto ='"+txt_des.Text+"'," +
                "precioCompra = "+txt_pre.Text+", cantidad = "+txt_cant.Text+"   " +
                "where codProducto = '"+txt_id.Text+"'" ;
                       
            SqlCommand comando = new SqlCommand(query, conexion);
            SqlDataAdapter data = new SqlDataAdapter(comando);
            DataTable dt = new DataTable();
            data.Fill(dt);
            Close();
        }
    }
}
