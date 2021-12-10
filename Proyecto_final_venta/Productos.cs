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
   
    public partial class Productos : Form

    {
        static string conexionstr = "server = DARK-AHSOIZ\\SQLEXPRESS ; database = DataBase_DS ; integrated security = true";
        SqlConnection conexion = new SqlConnection(conexionstr);

        public Productos()
        {
            InitializeComponent();
            conexion.Open();
        }

        private void inventarioBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.inventarioBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.proyecto_finalDataSet);

        }

        private void Productos_Load(object sender, EventArgs e)
        {
                string query = "select * from producto";
                SqlCommand comando = new SqlCommand(query, conexion);
                SqlDataAdapter data = new SqlDataAdapter(comando);
                DataTable dt = new DataTable();
                data.Fill(dt);
                dgresult.DataSource = dt;
            
        }
         private void btn_refrescar_Click(object sender, EventArgs e)
        {
            
        
        }
        private void btn_agregar_Click(object sender, EventArgs e)
        {
            producagregar agregar = new producagregar();

            agregar.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            eliminarproducto borrar = new eliminarproducto();

            borrar.Show();
        }
    }
}
