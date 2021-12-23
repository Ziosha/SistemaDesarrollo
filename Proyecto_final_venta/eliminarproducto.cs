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
    public partial class eliminarproducto : Form
    {
        static string conexionstr = "server = DARK-AHSOIZ\\SQLEXPRESS ; database = DataBase_DS ; integrated security = true";
        SqlConnection conexion = new SqlConnection(conexionstr);
        public eliminarproducto()
        {
            InitializeComponent();
            conexion.Open();
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            if(id_eliminar.Text == "")
            {
                MessageBox.Show("Ingrese un id para eliminar");
            }
            else
            {
                string query = "update Producto set ocultar = 'f' where codProducto = '"+id_eliminar.Text+"'";
                SqlCommand comando = new SqlCommand(query, conexion);
                SqlDataAdapter data = new SqlDataAdapter(comando);
                DataTable dt = new DataTable();
                data.Fill(dt);

                MessageBox.Show("Dato eliminado correctamente");
                Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
