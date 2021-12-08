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
    public partial class Productos : Form
    {
        public Productos()
        {
            InitializeComponent();
        }

        private void inventarioBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.inventarioBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.proyecto_finalDataSet);

        }

        private void Productos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'proyecto_finalDataSet.Inventario' Puede moverla o quitarla según sea necesario.
            //this.inventarioTableAdapter.Fill(this.proyecto_finalDataSet.Inventario);

           /* string datas = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\HP 245\Documents\Visual Studio 2013\Projects\c#\Proyecto_final_venta\Proyecto_final_venta\proyecto_final.accdb";
            OleDbConnection conex = new OleDbConnection(datas);
            conex.Open();

            string sql = "Select* From Inventario";
            OleDbDataAdapter adap = new OleDbDataAdapter(sql, datas);
            DataSet ds = new DataSet();
            adap.Fill(ds, "Inventario");
            dgresult.DataSource = ds.Tables["Inventario"];
            dgresult.ReadOnly = true;*/
        }
         private void btn_refrescar_Click(object sender, EventArgs e)
        {
            
        
        }
        private void btn_agregar_Click(object sender, EventArgs e)
        {
            producagregar agregar = new producagregar();

            agregar.Show();
        }
        

    }
}
