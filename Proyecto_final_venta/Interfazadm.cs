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
    public partial class Interfazadm : Form
    {
        static string conexionstr = "server = DARK-AHSOIZ\\SQLEXPRESS ; database = DataBase_DS ; integrated security = true";
        SqlConnection conexion = new SqlConnection(conexionstr);
        public Interfazadm(Boolean x)
        {
            InitializeComponent();
           
            conexion.Open();
            if (x)
            {
               btn_user.Visible = true;
            }

        }
      
 
        private void AbrirFormEnPanel(object openform)
        {
            if (this.panel_forms.Controls.Count > 0)
                this.panel_forms.Controls.RemoveAt(0);
            Form fh = openform as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panel_forms.Controls.Add(fh);
            this.panel_forms.Tag = fh;
            fh.Show();

        }

        private void btn_productos_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new Productos());
        }

        private void btn_ventas_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new compra());
        }

        private void btn_usuarios_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new Proveedores());
        }

        private void btn_reportes_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new reportes());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea salir ?", "Log out", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Form1 inic = new Form1();
                inic.Show();
                this.Hide();
            }
        }

        private void btn_user_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new usuarios());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new reportDevolucion());
        }

        private void btn_pago_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new Pagoprov());
        }
    }
}
