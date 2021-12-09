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

namespace Proyecto_final_venta
{
    public partial class producagregar : Form
    {
        public producagregar()
        {
            InitializeComponent();
        }
        int posx = 0;
        int posy = 0;
        private void producagregar_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_item_Enter(object sender, EventArgs e)
        {
            if (txt_item.Text == "Item")
            {
                txt_item.Text = "";
                txt_item.ForeColor = Color.Turquoise;
                panel1.BackColor = Color.Turquoise;
            }
        }

        private void txt_item_Leave(object sender, EventArgs e)
        {
            if (txt_item.Text == "")
            {
                txt_item.Text = "Item";
                txt_item.ForeColor = Color.White;
                panel1.BackColor = Color.White;
            }
        }

        private void txt_producto_Enter(object sender, EventArgs e)
        {
            if (txt_producto.Text == "Producto")
            {
                txt_producto.Text = "";
                txt_producto.ForeColor = Color.Turquoise;
                panel2.BackColor = Color.Turquoise;
            }
        }

        private void txt_producto_Leave(object sender, EventArgs e)
        {
            if (txt_producto.Text == "")
            {
                txt_producto.Text = "Producto";
                txt_producto.ForeColor = Color.White;
                panel2.BackColor = Color.White;
            }
        }

        private void txt_cantidad_Enter(object sender, EventArgs e)
        {
            if (txt_cantidad.Text == "Cantidad")
            {
                txt_cantidad.Text = "";
                txt_cantidad.ForeColor = Color.Turquoise;
                panel3.BackColor = Color.Turquoise;
            }
        }

        private void txt_cantidad_Leave(object sender, EventArgs e)
        {
            if (txt_cantidad.Text == "")
            {
                txt_cantidad.Text = "cantidad";
                txt_cantidad.ForeColor = Color.White;
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
    }
}
