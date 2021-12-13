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
            btn_cuad.Visible = false;
            conexion.Open();
            if (x)
            {
               btn_user.Visible = true;
            }





        }
        int posx = 0;
        int posy = 0;

        private void bunifuGradientPanel1_MouseMove(object sender, MouseEventArgs e)
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
        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_cuad_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btn_cuad.Visible = false;
            btn_maximize.Visible = true;
        }

        private void btn_minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btn_maximize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btn_maximize.Visible = false;
            btn_cuad.Visible = true;
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
            Form1 inic = new Form1();
            inic.Show();
            this.Hide();
        }

        private void btn_user_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new usuarios());
        }
    }
}
