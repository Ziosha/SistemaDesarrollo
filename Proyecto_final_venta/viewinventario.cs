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
    public partial class viewinventario : Form
    {
        public viewinventario()
        {
            InitializeComponent();
        }

        private void viewinventario_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'reportemerca.Producto' Puede moverla o quitarla según sea necesario.
            this.ProductoTableAdapter.Fill(this.reportemerca.Producto);

            this.reportViewer1.RefreshReport();
        }
    }
}
