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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
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

       

        private void txt_user_Enter(object sender, EventArgs e)
        {
            if (txt_user.Text == "Usuario")
            {
                txt_user.Text = "";
                txt_user.ForeColor = Color.Turquoise;
                panel1.BackColor = Color.Turquoise;
            }
        }

        private void txt_user_Leave(object sender, EventArgs e)
        {
            if (txt_user.Text == "")
            {
                txt_user.Text = "Usuario";
                txt_user.ForeColor = Color.White;
                panel1.BackColor = Color.White;
            }
        }

        private void txt_pass_Enter(object sender, EventArgs e)
        {
            if (txt_pass.Text == "Contraseña")
            {
                txt_pass.Text = "";
                txt_pass.ForeColor = Color.Turquoise;
                panel2.BackColor = Color.Turquoise;
                txt_pass.UseSystemPasswordChar = true;
            }
        }

        private void txt_pass_Leave(object sender, EventArgs e)
        {
            if (txt_pass.Text == "")
            {
                txt_pass.Text = "Contraseña";
                txt_pass.ForeColor = Color.White;
                panel2.BackColor = Color.White;
                txt_pass.UseSystemPasswordChar = false;
            }
        }
        private void txt_user_TextChanged(object sender, EventArgs e)
        {
            if ((txt_user.Text != "Usuario") && (txt_pass.Text != "Contraseña"))
            {
                btn_ingreso.Enabled = true;
            }
            else { btn_ingreso.Enabled = false; }
        }

        private void txt_pass_TextChanged(object sender, EventArgs e)
        {
            if ((txt_user.Text != "Usuario") && (txt_pass.Text != "Contraseña"))
            {
                btn_ingreso.Enabled = true;
            }
            else { btn_ingreso.Enabled = false; }
        }
        private void btn_ingreso_Click(object sender, EventArgs e)
        {
           

            
                if (txt_user.Text == "admin" && txt_pass.Text == "admin")
                {
                    MessageBox.Show(" >>>>   bienvenido  <<<<");
                    Interfazadm adm = new Interfazadm();
                    adm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Datos incorrectos", "ERROR");
                }
            
          
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

  

        
    }
}
