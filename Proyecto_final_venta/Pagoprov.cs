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
    public partial class Pagoprov : Form
    {
        static string conexionstr = "server = DARK-AHSOIZ\\SQLEXPRESS ; database = DataBase_DS ; integrated security = true";
        SqlConnection conexion = new SqlConnection(conexionstr);
        public Pagoprov()
        {
            InitializeComponent();
        }

        private void txt_direc_TextChanged(object sender, EventArgs e)
        {

        }

        private void insertar_Click(object sender, EventArgs e)
        {
            try
            {
                if (codC.Text == "" || fact.Text == "" || total.Text == "" || fecha.Text == "")
                {
                    MessageBox.Show("Llene todos los campos para agregar el producto");
                }
                else
                {
                    string query = "insert into pagoProveedor(codCompra,nroFactura,totalFactura,fecha)" +
                        "values (" + codC.Text + ", '" + fact.Text + "'," + total.Text + ",'" + fecha.Text + "')";
                    SqlCommand comando = new SqlCommand(query, conexion);
                    SqlDataAdapter data = new SqlDataAdapter(comando);
                    DataTable dt = new DataTable();
                    data.Fill(dt);
                    string z = codC.Text;
                    string q = fact.Text;
                    string w = total.Text;
                    string r = fecha.Text;

                    Close();
                    
                    Ticket ticket = new Ticket(z, q,w,r);
                    ticket.Show();
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void Pagoprov_Load(object sender, EventArgs e)
        {

            var fech = DateTime.Now;
            var Date = fech.Date.ToString("yyyy-MM-dd");

            fecha.Text = Date;

        }

        private void total_KeyPress(object sender, KeyPressEventArgs e)
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
