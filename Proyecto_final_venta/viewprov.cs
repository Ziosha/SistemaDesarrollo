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
    public partial class viewprov : Form
    {
        public viewprov()
        {
            InitializeComponent();
        }

        private void viewprov_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'reportemerca.reportprov' Puede moverla o quitarla según sea necesario.
            this.reportprovTableAdapter.Fill(this.reportemerca.reportprov);

            this.reportViewer1.RefreshReport();
        }
    }
}
