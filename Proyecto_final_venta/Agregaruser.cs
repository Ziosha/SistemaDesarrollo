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
    public partial class Agregaruser : Form
    {
        public Agregaruser()
        {
            InitializeComponent();
        }
        int posx = 0;
        int posy = 0;
        private void txt_user_Enter(object sender, EventArgs e)
        {
            if (txt_user.Text == "Usuario")
            {
                txt_user.Text = "";
                txt_user.ForeColor = Color.White;
                panel1.BackColor = Color.White;
            }
        }

        private void txt_user_Leave(object sender, EventArgs e)
        {
            if (txt_user.Text == "")
            {
                txt_user.Text = "Usuario";
                txt_user.ForeColor = Color.Blue;
                panel1.BackColor = Color.Blue;
            }
        }

        private void txt_pass_Enter(object sender, EventArgs e)
        {
            if (txt_pass.Text == "Contraseña")
            {
                txt_pass.Text = "";
                txt_pass.ForeColor = Color.White;
                panel1.BackColor = Color.White;
            }
        }

        private void txt_pass_Leave(object sender, EventArgs e)
        {
            if (txt_pass.Text == "")
            {
                txt_pass.Text = "Contraseña";
                txt_pass.ForeColor = Color.Blue;
                panel1.BackColor = Color.Blue;
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

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
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
    }
}
