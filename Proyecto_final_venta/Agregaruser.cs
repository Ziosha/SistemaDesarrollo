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
    public partial class Agregaruser : Form
    {
        static string conexionstr = "server = DARK-AHSOIZ\\SQLEXPRESS ; database = DataBase_DS ; integrated security = true";
        SqlConnection conexion = new SqlConnection(conexionstr);
        public Agregaruser()
        {
            InitializeComponent();
            conexion.Open();
        }
       
        private void txt_user_Enter(object sender, EventArgs e)
        {
            
        }

        private void txt_user_Leave(object sender, EventArgs e)
        {
            
        }

        private void txt_pass_Enter(object sender, EventArgs e)
        {
            
        }

        private void txt_pass_Leave(object sender, EventArgs e)
        {
            
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            try
            {

                if (txt_cod.Text == "" || txt_priv.Text == "" || txt_log.Text == "" || txt_pass.Text == "" || txt_name.Text == "" || txt_last.Text == "")
                {
                    MessageBox.Show("Llene todos los campos para agregar el producto");
                }
                else
                {
                    string query = "insert into Usuario (codigoUsuario, codigoPriv, loginU, passwordU, NombreUsuario, ApellidosUsuario)" +
                        "values ('" + txt_cod.Text + "', '" + txt_priv.Text + "','" + txt_log.Text + "','" + txt_pass.Text + "','"+ txt_name.Text+ "', '"+txt_last.Text+"')";
                    SqlCommand comando = new SqlCommand(query, conexion);
                    SqlDataAdapter data = new SqlDataAdapter(comando);
                    DataTable dt = new DataTable();
                    data.Fill(dt);
                    MessageBox.Show("usuario agregado");
                    Close();

                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void panel5_MouseMove(object sender, MouseEventArgs e)
        {
           
        }
    }
}
