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
    public partial class consultarproveedor : Form
    {
        static string conexionstr = "server = DARK-AHSOIZ\\SQLEXPRESS ; database = DataBase_DS ; integrated security = true";
        SqlConnection conexion = new SqlConnection(conexionstr);
        public consultarproveedor()
        {
            InitializeComponent();
            conexion.Open();
        }

        private void btn_consultar_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "select codProducto,codProveedor, descripcionProducto,precioCompra,cantidad,fechaVencimiento,cantidadMin from producto where ocultar = 'v'and  codProveedor = '" + cb_id.Text + "'";
                SqlCommand comando = new SqlCommand(query, conexion);
                SqlDataAdapter data = new SqlDataAdapter(comando);
                DataTable dt = new DataTable();
                data.Fill(dt);
                dgvresult.DataSource = dt;

            }
            catch (Exception error)
            {
                MessageBox.Show("Datos incorectos", error.Message);
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void consultarproveedor_Load(object sender, EventArgs e)
        {
            conexion.Close();
            conexion.Open();
            string query = "select codProveedor from Proveedor";
            SqlCommand comand = new SqlCommand(query, conexion);
            SqlDataReader dt;
            dt = comand.ExecuteReader();
            while (dt.Read())
            {
                cb_id.Items.Add(dt["codProveedor"].ToString());
            }
            conexion.Close();
        }
    }
}
