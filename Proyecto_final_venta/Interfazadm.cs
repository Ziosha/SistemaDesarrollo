using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_final_venta
{
    public partial class Interfazadm : Form
    {
        public Interfazadm()
        {
            InitializeComponent();
            btn_cuad.Visible = false;
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

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            ActiveForm.Opacity = 10.0;
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
