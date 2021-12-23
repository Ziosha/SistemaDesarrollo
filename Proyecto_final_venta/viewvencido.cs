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
    public partial class viewvencido : Form
    {
        public viewvencido()
        {
            InitializeComponent();
        }

        private void viewvencido_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'reportemerca.reportven' Puede moverla o quitarla según sea necesario.
            this.reportvenTableAdapter.Fill(this.reportemerca.reportven);

            this.reportViewer1.RefreshReport();
        }
    }
}
