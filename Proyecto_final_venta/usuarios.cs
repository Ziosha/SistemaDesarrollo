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
    public partial class usuarios : Form
    {
        static string conexionstr = "server = DARK-AHSOIZ\\SQLEXPRESS ; database = DataBase_DS ; integrated security = true";
        SqlConnection conexion = new SqlConnection(conexionstr);
        public usuarios()
        {
            InitializeComponent();
            conexion.Open();


        }

        private void usuarios_Load(object sender, EventArgs e)
        {
            string query = "select * from Usuario";
            SqlCommand comando = new SqlCommand(query, conexion);
            SqlDataAdapter data = new SqlDataAdapter(comando);
            DataTable dt = new DataTable();
            data.Fill(dt);
            dvg_user.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Agregaruser user = new Agregaruser();
            user.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txt_del.Visible = true;
            lbl.Visible = true;
            button3.Visible = true;
            

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string query = "delete Usuario where codigoUsuario = '" + txt_del.Text + "'";
            SqlCommand comando = new SqlCommand(query, conexion);
            SqlDataAdapter data = new SqlDataAdapter(comando);
            DataTable dt = new DataTable();
            data.Fill(dt);

            MessageBox.Show("Usuario Eliminado");

            txt_del.Visible = false;
            lbl.Visible = false;
            button3.Visible = false;
        }
    }
}
