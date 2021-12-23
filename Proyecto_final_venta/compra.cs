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
    public partial class compra : Form
    {
        static string conexionstr = "server = DARK-AHSOIZ\\SQLEXPRESS ; database = DataBase_DS ; integrated security = true";
        SqlConnection conexion = new SqlConnection(conexionstr);

        public compra()
        {
            InitializeComponent();
            conexion.Open();
        }

        private void compra_Load(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            cb_cod.Enabled = true;
            txt_can.Enabled = true;
            txt_pag.Enabled = true;
            txt_pre.Enabled = true;
            btn_new.Enabled = false;
            btn_agre.Visible = true;


            var fecha = DateTime.Now;
            var Date = fecha.Date.ToString("yyyy-MM-dd");
            conexion.Close();
            conexion.Open();
            string query = "DROP TABLE IF EXISTS dbo.temporal create table temporal (cod int primary key identity not null,codigoUsuario varchar(20),codProducto varchar(20),fechaCompra date,horaCompra time,totalArticulos int,pago float,cantidad int,precioCompra float)";
            SqlCommand comand = new SqlCommand(query, conexion);
            SqlDataReader dt;
            dt = comand.ExecuteReader();
            conexion.Close();
        }

        private void btn_agre_Click(object sender, EventArgs e)
        {
           
            if(txt_pag.Text =="" || cb_cod.Text == "" || txt_can.Text == "" || txt_pre.Text == "")
            {
                MessageBox.Show("Campos vacios , llenelos porfavor");
            }
            else
            {
                btn_confirmar.Visible = true;
                btn_cancel.Visible = true;
                btn_res.Visible = true;
                var fecha = DateTime.Now;
                var Date = fecha.Date.ToString("yyyy-MM-dd");
                string hora = DateTime.Now.ToString("hh:mm:ss tt");

                conexion.Open();
                string query = "insert into temporal(codigoUsuario,codProducto,fechaCompra,horaCompra,totalArticulos,pago,cantidad,precioCompra) values  " +
                    "('US-01','" + cb_cod.Text + "','" + Date + "','" + hora + "',1, " + txt_pag.Text + "," + txt_can.Text + "," + txt_pre.Text + ")";
                SqlCommand comand = new SqlCommand(query, conexion);
                SqlDataAdapter data = new SqlDataAdapter(comand);
                DataTable dt = new DataTable();
                _ = data.Fill(dt);
                dgvLista.DataSource = dt;

                conexion.Close();

                cb_cod.Text = "";
                txt_can.Text = "";
                txt_pag.Text = "";
                txt_pre.Text = "";
            }

           

            


        }

        private void btn_confirmar_Click(object sender, EventArgs e)
        {
            cb_cod.Text = "";
            txt_can.Text = "";
            txt_pag.Text = "";
            txt_pre.Text = "";
            cb_cod.Enabled = false;
            txt_can.Enabled = false;
            txt_pag.Enabled = false;
            txt_pre.Enabled = false;
            btn_new.Enabled = true;
            btn_agre.Visible = false;
            btn_confirmar.Visible = false;
            btn_cancel.Visible = false;
            btn_res.Visible = false;

            conexion.Open();
            string query1 = "insert into Compra (codigoUsuario,codProducto,fechaCompra,horaCompra,totalArticulos,pago,cantidad,precioCompra) select  "+
               "codigoUsuario, codProducto, fechaCompra, horaCompra, totalArticulos, pago, cantidad, precioCompra from temporal";
            SqlCommand comand1 = new SqlCommand(query1, conexion);
            SqlDataReader dt1;
            dt1 = comand1.ExecuteReader();
            conexion.Close();


            conexion.Open();
            string query = "drop table temporal";
            SqlCommand comand = new SqlCommand(query, conexion);
            SqlDataReader dt;
            dt = comand.ExecuteReader();
            conexion.Close();



            MessageBox.Show("Guardado", "Compra guardada", MessageBoxButtons.OK);
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            cb_cod.Text = "";
            txt_can.Text = "";
            txt_pag.Text = "";
            txt_pre.Text = "";
            cb_cod.Enabled = false;
            txt_can.Enabled = false;
            txt_pag.Enabled = false;
            txt_pre.Enabled = false;
            btn_new.Enabled = true;
            btn_agre.Visible = false;
            btn_confirmar.Visible = false;
            btn_cancel.Visible = false;
            btn_res.Visible=false;

            conexion.Open();
            string query = "drop table temporal";
            SqlCommand comand = new SqlCommand(query, conexion);
            SqlDataReader dt;
            dt = comand.ExecuteReader();
            conexion.Close();
            dgvLista.Refresh();

            MessageBox.Show("Cancelado","Compra cancelada",MessageBoxButtons.OK,MessageBoxIcon.Warning);
        }

        private void cb_cod_SelectedIndexChanged(object sender, EventArgs e)
        {
            conexion.Open();
            string query = "select descripcionProducto from Producto where codProducto = '" + cb_cod.Text + "' ";
            SqlCommand comand = new SqlCommand(query, conexion);
            SqlDataReader dt;
            dt = comand.ExecuteReader();
            if (dt.Read())
            {
                txt_prod.Text = dt["descripcionProducto"].ToString();
            }

            conexion.Close();
        }

        private void btn_res_Click(object sender, EventArgs e)
        {
            
                string query = "select * from temporal";
                SqlCommand comando = new SqlCommand(query, conexion);
                SqlDataAdapter data = new SqlDataAdapter(comando);
                DataTable dt = new DataTable();
                data.Fill(dt);
                dgvLista.DataSource = dt;
            


            
        }

        private void txt_can_KeyPress(object sender, KeyPressEventArgs e)
        {
            if((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo Numeros", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txt_pag_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo Numeros", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txt_pre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo Numeros", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void compra_Load_1(object sender, EventArgs e)
        {
            string query = "select codProducto from Producto";
            SqlCommand comand = new SqlCommand(query, conexion);
            SqlDataReader dt;
            dt = comand.ExecuteReader();
            while (dt.Read())
            {
                cb_cod.Items.Add(dt["codProducto"].ToString());
            }
            conexion.Close();
        }
    }
}

