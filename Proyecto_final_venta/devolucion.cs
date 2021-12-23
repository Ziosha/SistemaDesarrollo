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
    public partial class devolucion : Form
    {
        static string conexionstr = "server = DARK-AHSOIZ\\SQLEXPRESS ; database = DataBase_DS ; integrated security = true";
        SqlConnection conexion = new SqlConnection(conexionstr);
        public devolucion()
        {
            InitializeComponent();
            conexion.Open();
            string query = "select descripcionProducto from Producto";
            SqlCommand comand = new SqlCommand(query, conexion);
            SqlDataReader dt;
            dt = comand.ExecuteReader();
            while (dt.Read())
            {
                cb_name.Items.Add(dt["descripcionProducto"].ToString());
            }
            conexion.Close();

           



        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
               
                var fecha = DateTime.Now;
                var Date = fecha.Date.ToString("yyyy-MM-dd");

                conexion.Open();
                string query = "update Producto set cantidad = cantidad - "+cb_cant.Text+" where codProducto = '"+txt_cod.Text+"' ";
                SqlCommand comando = new SqlCommand(query, conexion);
                SqlDataAdapter data = new SqlDataAdapter(comando);
                DataTable dt = new DataTable();
                data.Fill(dt);
                conexion.Close();

                conexion.Open();
                string query2 = "insert into Devolucion (codProducto, cantidad, PrecioBase, fechaDevolucion, nomProducto)" +
                        "values ( '" + txt_cod.Text + "'," + cb_cant.Text + "," + txt_pre.Text + ", '"+Date +"', '"+cb_name.Text +"' )";
                SqlCommand comando2 = new SqlCommand(query2, conexion);
                SqlDataAdapter data2 = new SqlDataAdapter(comando2);
                DataTable dt2 = new DataTable();
                data2.Fill(dt2);
                conexion.Close();
            

                MessageBox.Show("Devolucion registrada");

                conexion.Open();
                string query3 = "select codProducto, descripcionProducto from Producto where cantidad < cantidadMin + 10";
                SqlCommand comando3 = new SqlCommand(query3, conexion);
                SqlDataReader lectordata;
                lectordata = comando3.ExecuteReader();
                Boolean ex = lectordata.Read();
                conexion.Close();
                if (ex)
                {
                    MessageBox.Show("Hay productos que llegan a la cantidad Minima");
                }
                Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cb_name_SelectedIndexChanged(object sender, EventArgs e)
        {
            conexion.Open();
            string query = "select codProducto from Producto where descripcionProducto = '"+cb_name.Text+"' ";
            SqlCommand comand = new SqlCommand(query, conexion);
            SqlDataReader dt;
            dt = comand.ExecuteReader();
            if (dt.Read())
            {
                txt_cod.Text = dt["codProducto"].ToString();
            }
            
            conexion.Close();

            cb_cant.Items.Clear();
            conexion.Open();
            string querys = "select cantidad from Producto where codProducto = '" + txt_cod.Text + "'";
            SqlCommand comands = new SqlCommand(querys, conexion);
            SqlDataReader dts;
            dts = comands.ExecuteReader();
            
            while (dts.Read())
            {
                int con = 1;
                string resul = dts["cantidad"].ToString();
                int num = Convert.ToInt32(resul);
                while(num > con)
                {
                    cb_cant.Items.Add(con.ToString());
                    con++;

                }
            }
            conexion.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txt_pre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo Numeros", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }
    }
}
