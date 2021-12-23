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
    public partial class viewcompra : Form
    {
        public viewcompra()
        {
            InitializeComponent();
        }

        private void viewcompra_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'reportemerca.Compra' Puede moverla o quitarla según sea necesario.
            this.CompraTableAdapter.Fill(this.reportemerca.Compra);

            this.reportViewer1.RefreshReport();
        }
    }
}
