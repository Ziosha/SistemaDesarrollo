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
    public partial class Form1 : Form
    {

        static string conexionstr = "server = DARK-AHSOIZ\\SQLEXPRESS ; database = DataBase_DS ; integrated security = true";
        SqlConnection conexion = new SqlConnection(conexionstr);

        public Form1()
        {
            InitializeComponent();

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
            conexion.Close();
            try
            {
                conexion.Open();
                string query = "select loginU, passwordU from Usuario where loginU ='" + txt_user.Text + "' and passwordU = '" + txt_pass.Text + "' ";
                SqlCommand comando = new SqlCommand(query, conexion);
                SqlDataReader lectordata;
                lectordata = comando.ExecuteReader();
                Boolean ex = lectordata.Read();
                conexion.Close();
                if (ex)
                {
                    conexion.Open();
                    string priv = "select codigoPriv from Usuario where loginU ='" + txt_user.Text + "' and passwordU = '" + txt_pass.Text + "' and codigoPriv = 'a'";
                    SqlCommand comand = new SqlCommand(priv, conexion);
                    SqlDataReader dt;
                    dt = comand.ExecuteReader();
                    Boolean x = dt.Read();
                    conexion.Close();


                    var fecha = DateTime.Now;
                    var Date = fecha.Date.ToString("yyyy-MM-dd");
                    string hora = DateTime.Now.ToString("hh:mm:ss tt");


                    MessageBox.Show(" >>>>   bienvenido    " +
                        "fecha de inicio " + Date +
                        " hora de inico  " + hora + " <<<<");

                    Interfazadm adm = new Interfazadm(x);
                    adm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Datos incorrectos", "ERROR");
                }

            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            };

        }

        private void button2_Click(object sender, EventArgs e) => Application.Exit();

    }
}
