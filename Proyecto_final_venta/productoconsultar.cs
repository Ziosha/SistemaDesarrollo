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
    public partial class productoconsultar : Form
    {
        static string conexionstr = "server = DARK-AHSOIZ\\SQLEXPRESS ; database = DataBase_DS ; integrated security = true";
        SqlConnection conexion = new SqlConnection(conexionstr);
        public productoconsultar()
        {
            InitializeComponent();
            conexion.Open();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string query = "select * from producto where codProveedor = '"+txt_id.Text+"'";
            SqlCommand comando = new SqlCommand(query, conexion);
            SqlDataAdapter data = new SqlDataAdapter(comando);
            DataTable dt = new DataTable();
            data.Fill(dt);
            dgvresult.DataSource = dt;
        }
    }
}
