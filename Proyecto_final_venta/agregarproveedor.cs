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
    public partial class agregarproveedor : Form
    {
        static string conexionstr = "server = DARK-AHSOIZ\\SQLEXPRESS ; database = DataBase_DS ; integrated security = true";
        SqlConnection conexion = new SqlConnection(conexionstr);
        public agregarproveedor()
        {
            InitializeComponent();
            conexion.Open();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_codProv.Text == "" || txt_nom.Text == "" || txt_direc.Text == "" || txt_tel.Text == "")
                {
                    MessageBox.Show("Llene todos los campos para agregar el producto");
                }
                else
                {
                    string query = "insert into Proveedor (codProveedor, nomProveedor, direccionProveedor, telefonoProveedor, ocultar)" +
                        "values (" + txt_codProv.Text + ", '" + txt_nom.Text + "','" + txt_direc.Text + "','" + txt_tel.Text + "', 'v')";
                    SqlCommand comando = new SqlCommand(query, conexion);
                    SqlDataAdapter data = new SqlDataAdapter(comando);
                    DataTable dt = new DataTable();
                    data.Fill(dt);
                    Close();

                }


            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void agregarproveedor_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
