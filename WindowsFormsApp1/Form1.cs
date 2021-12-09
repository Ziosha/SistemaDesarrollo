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

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        static string conexionstring = "server= DESKTOP-34BDT7A ; database= DataBase_DS ; integrated security= true";
        SqlConnection conexion = new SqlConnection(conexionstring);
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            conexion.Open();
            MessageBox.Show("La conexion a la BD: " + conexion.Database + " fue exitosa");
        }
        private void consula_Click(object sender, EventArgs e)
        {
            if (consulta.Text == "")
            {
                string query = "Select * from Proveedor";
                SqlCommand comando = new SqlCommand(query, conexion);
                SqlDataAdapter data = new SqlDataAdapter(comando);
                DataTable tabla = new DataTable();
                data.Fill(tabla);
                dataGridView1.DataSource = tabla;

            }
            else
            {
                string query = "Select * from Proveedor where codProveedor = '" + consulta.Text + "'";
                SqlCommand comando = new SqlCommand(query, conexion);
                SqlDataAdapter data = new SqlDataAdapter(comando);
                DataTable tabla = new DataTable();
                data.Fill(tabla);
                dataGridView1.DataSource = tabla;

            }
        }

        private void elimi_Click(object sender, EventArgs e)
        {

          
            string cadena = "Delete from Producto where codProveedor = '" +elimina.Text + "'Delete from Proveedor where codProveedor = '" + elimina.Text + "'";
            SqlCommand comando = new SqlCommand(cadena, conexion);
            SqlDataAdapter data = new SqlDataAdapter(comando);
            DataTable tabla = new DataTable();
            data.Fill(tabla);

            MessageBox.Show("se realizo la eliminacion correctamente");
            
            elimina.Text = "";
        }

        private void actuali_Click(object sender, EventArgs e)
        {
            
            string cadena = "Update Proveedor set codProveedor = '" + codP.Text + "',nomProveedor='" + nomP.Text + "',direccionProveedor='" + dirP.Text + "',telefonoProveedor='" + telP.Text + "' where nomProveedor ='" + actualiza.Text + "' ";
            SqlCommand comando = new SqlCommand(cadena, conexion);
            SqlDataAdapter data = new SqlDataAdapter(comando);
            DataTable tabla = new DataTable();
            data.Fill(tabla);

            MessageBox.Show("se realizo la actualizacion correctamente");
          
            
              
            
           actualiza.Text = "";

            codP.Text = "";
            nomP.Text = "";
            dirP.Text = "";
            telP.Text = "";
        }

        private void agrega_Click(object sender, EventArgs e)
        {
            string cadena = "insert into Proveedor (codProveedor, nomProveedor, direccionProveedor, telefonoProveedor) values (" + codP.Text + ",'" + nomP.Text + "','" + dirP.Text + "','" + telP.Text + "')";
            SqlCommand comando = new SqlCommand(cadena, conexion);
            SqlDataAdapter data = new SqlDataAdapter(comando);
            DataTable tabla = new DataTable();
            data.Fill(tabla);

            MessageBox.Show("los datos fueron agregado correctamente");

            codP.Text = "";
            nomP.Text = "";
            dirP.Text = "";
            telP.Text = "";
        }
    }
}
