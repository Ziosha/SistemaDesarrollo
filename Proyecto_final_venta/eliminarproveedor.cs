﻿using System;
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
    public partial class btn_eliminar : Form
    {
        static string conexionstr = "server = DARK-AHSOIZ\\SQLEXPRESS ; database = DataBase_DS ; integrated security = true";
        SqlConnection conexion = new SqlConnection(conexionstr);
        public btn_eliminar()
        {
            InitializeComponent();
            conexion.Open();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string cadena = "Delete from Producto where codProveedor = '" + elimina.Text + "'Delete from Proveedor where codProveedor = '" + elimina.Text + "'";
            SqlCommand comando = new SqlCommand(cadena, conexion);
            SqlDataAdapter data = new SqlDataAdapter(comando);
            DataTable tabla = new DataTable();
            data.Fill(tabla);
            Close();
            MessageBox.Show("se realizo la eliminacion correctamente");

        }
    }
}
