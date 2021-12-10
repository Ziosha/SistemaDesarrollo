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
    public partial class producagregar : Form
    {
        static string conexionstr = "server = DARK-AHSOIZ\\SQLEXPRESS ; database = DataBase_DS ; integrated security = true";
        SqlConnection conexion = new SqlConnection(conexionstr);

        public producagregar()
        {
            InitializeComponent();
            conexion.Open();
        }
        int posx = 0;
        int posy = 0;
        private void producagregar_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_Prod_Enter(object sender, EventArgs e)
        {
            if (txt_codProd.Text == "Item")
            {
                txt_codProd.Text = "";
                txt_codProd.ForeColor = Color.Turquoise;
                panel1.BackColor = Color.Turquoise;
            }
        }

        private void txt_item_Leave(object sender, EventArgs e)
        {
            if (txt_codProd.Text == "")
            {
                txt_codProd.Text = "Item";
                txt_codProd.ForeColor = Color.White;
                panel1.BackColor = Color.White;
            }
        }

        private void txt_producto_Enter(object sender, EventArgs e)
        {
            if (txt_codProv.Text == "Producto")
            {
                txt_codProv.Text = "";
                txt_codProv.ForeColor = Color.Turquoise;
                panel2.BackColor = Color.Turquoise;
            }
        }

        private void txt_producto_Leave(object sender, EventArgs e)
        {
            if (txt_codProv.Text == "")
            {
                txt_codProv.Text = "Producto";
                txt_codProv.ForeColor = Color.White;
                panel2.BackColor = Color.White;
            }
        }

        private void txt_cantidad_Enter(object sender, EventArgs e)
        {
            if (txt_des.Text == "Cantidad")
            {
                txt_des.Text = "";
                txt_des.ForeColor = Color.Turquoise;
                panel3.BackColor = Color.Turquoise;
            }
        }

        private void txt_cantidad_Leave(object sender, EventArgs e)
        {
            if (txt_des.Text == "")
            {
                txt_des.Text = "cantidad";
                txt_des.ForeColor = Color.White;
                panel3.BackColor = Color.White;
            }
        }

        private void txt_precio_Enter(object sender, EventArgs e)
        {
            if (txt_precio.Text == "Precio")
            {
                txt_precio.Text = "";
                txt_precio.ForeColor = Color.Turquoise;
                panel4.BackColor = Color.Turquoise;
            }
        }

        private void txt_precio_Leave(object sender, EventArgs e)
        {
            if (txt_precio.Text == "")
            {
                txt_precio.Text = "precio";
                txt_precio.ForeColor = Color.White;
                panel4.BackColor = Color.White;
            }
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            try
            {
                if(txt_codProd.Text == "" || txt_codProv.Text == "" || txt_des.Text == "" || txt_precio.Text =="" || txt_cant.Text =="")
                {
                    MessageBox.Show("Llene todos los campos para agregar el producto");
                }
                else
                {
                    string query = "insert into Producto (codProducto, codProveedor, descripcionProducto, precioCompra, Cantidad)" +
                        "values ('"+txt_codProd.Text +"',"+txt_codProv.Text +", '"+txt_des.Text+"',"+txt_precio.Text+","+txt_cant.Text+")";
                    SqlCommand comando = new SqlCommand(query, conexion);
                    SqlDataAdapter data = new SqlDataAdapter(comando);
                    DataTable dt = new DataTable();
                    data.Fill(dt);
                    InitializeComponent();
                    Close();

                }
                

            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void panel5_MouseMove(object sender, MouseEventArgs e)
        {

            if (e.Button != MouseButtons.Left)
            {
                posx = e.X;
                posy = e.Y;

            }
            else
            {
                Left = Left + (e.X - posx);
                Top = Top + (e.Y - posy);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txt_producto_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_cantidad_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_precio_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
