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
    public partial class reportDevolucion : Form
    {
        static string conexionstr = "server = DARK-AHSOIZ\\SQLEXPRESS ; database = DataBase_DS ; integrated security = true";
        SqlConnection conexion = new SqlConnection(conexionstr);
        public reportDevolucion()
        {
            InitializeComponent();

        }

        private void btn_repot_Click(object sender, EventArgs e)
        {
            try
            {
                conexion.Open();
                string query = "select * from Devolucion";
                SqlCommand comando = new SqlCommand(query, conexion);
                SqlDataAdapter data = new SqlDataAdapter(comando);
                DataTable dt = new DataTable();
                data.Fill(dt);
                dvg_re.DataSource = dt;
                conexion.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_dev_Click(object sender, EventArgs e)
        {
            devolucion dev = new devolucion();
            dev.Show();

        }
    }
}
