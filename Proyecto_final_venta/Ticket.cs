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
    public partial class Ticket : Form
    {
        static string conexionstr = "server = DARK-AHSOIZ\\SQLEXPRESS ; database = DataBase_DS ; integrated security = true";
        SqlConnection conexion = new SqlConnection(conexionstr);
        string cd;
        public Ticket(string a, string x, string c, string d)
        {
            InitializeComponent();
            conexion.Open();
            codigo.Text = a;
            fech.Text = d;
            nro.Text = x;
            total.Text = c;


             cd  = a ;
            Console.WriteLine(a, x, c, d);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
       
        }

        private void codigo_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void Ticket_Load(object sender, EventArgs e )
        {
            try
            {
                string query = " select pagoProveedor.codCompra,nroFactura,totalFactura,fecha, Producto.descripcionProducto " +
            "FROM pagoProveedor INNER JOIN Compra ON pagoProveedor.codCompra = Compra.codCompra " +
            " INNER JOIN Producto ON Compra.codCompra = Producto.codCompra  where pagoProveedor.codCompra =" + cd + "";
                SqlCommand comando = new SqlCommand(query, conexion);
                SqlDataAdapter data = new SqlDataAdapter(comando);
                DataTable dt = new DataTable();
                data.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
