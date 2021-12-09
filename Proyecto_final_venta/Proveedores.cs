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
    public partial class Proveedores : Form
    {
        static string conexionstr = "server = DARK-AHSOIZ\\SQLEXPRESS ; database = DataBase_DS ; integrated security = true";
        SqlConnection conexion = new SqlConnection(conexionstr);
        public Proveedores()
        {
            InitializeComponent();
            conexion.Open();
        }

        private void usuarios_Load(object sender, EventArgs e)
        {
            string query = "select * from proveedor";
            SqlCommand comando = new SqlCommand(query, conexion);
            SqlDataAdapter data = new SqlDataAdapter(comando);
            DataTable dt = new DataTable();
            data.Fill(dt);
            dgresul1.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            consultarproveedor cons = new consultarproveedor();
            cons.Show();

        }

        private void btn_agre_Click(object sender, EventArgs e)
        {
            agregarproveedor aprov = new agregarproveedor();
            aprov.Show();
        }

        private void btn_eli_Click(object sender, EventArgs e)
        {
            eliminarproducto elim = new eliminarproducto();
            elim.Show();
        }
    }
}
