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
    public partial class compra : Form
    {
        public compra()
        {
            InitializeComponent();
            itemTextBox.Text = "Item";
            productoTextBox.Text = "Producto";
            precioTextBox.Text = "Precio";
            cantidadTextBox.Text = "Stock";
            txt_cant.Text = "Cantidad";
        }
        string[,] ListaVenta = new string[200, 7];
        int Fila = 0;

        private void itemTextBox_Enter_1(object sender, EventArgs e)
        {
            if (itemTextBox.Text == "Item")
            {
                itemTextBox.Text = "";
                itemTextBox.ForeColor = Color.Violet;
                panel6.BackColor = Color.Violet;
            }
        }

        private void itemTextBox_Leave(object sender, EventArgs e)
        {
            if (itemTextBox.Text == "")
            {
                itemTextBox.Text = "Item";
                itemTextBox.ForeColor = Color.WhiteSmoke;
                panel6.BackColor = Color.WhiteSmoke;

            }
        }

        private void productoTextBox_Enter(object sender, EventArgs e)
        {
            if (productoTextBox.Text == "Producto")
            {
                productoTextBox.Text = "";
                productoTextBox.ForeColor = Color.Violet;
                panel7.BackColor = Color.Violet;
            }
        }

        private void productoTextBox_Leave(object sender, EventArgs e)
        {
            if (productoTextBox.Text == "")
            {
                productoTextBox.Text = "Producto";
                productoTextBox.ForeColor = Color.WhiteSmoke;
                panel7.BackColor = Color.WhiteSmoke;

            }
        }

        private void cantidadTextBox_Enter(object sender, EventArgs e)
        {
            if (cantidadTextBox.Text == "Stock")
            {
                cantidadTextBox.Text = "";
                cantidadTextBox.ForeColor = Color.Violet;
                panel8.BackColor = Color.Violet;
            }
        }

        private void cantidadTextBox_Leave(object sender, EventArgs e)
        {
            if (cantidadTextBox.Text == "")
            {
                cantidadTextBox.Text = "Stock";
                cantidadTextBox.ForeColor = Color.WhiteSmoke;
                panel8.BackColor = Color.WhiteSmoke;

            }
        }

        private void precioTextBox_Enter(object sender, EventArgs e)
        {
            if (precioTextBox.Text == "Precio")
            {
                precioTextBox.Text = "";
                precioTextBox.ForeColor = Color.Violet;
                panel9.BackColor = Color.Violet;
            }
        }

        private void precioTextBox_Leave(object sender, EventArgs e)
        {
            if (precioTextBox.Text == "")
            {
                precioTextBox.Text = "Precio";
                precioTextBox.ForeColor = Color.WhiteSmoke;
                panel9.BackColor = Color.WhiteSmoke;

            }
        }

        private void txt_cant_Enter(object sender, EventArgs e)
        {
            if (txt_cant.Text == "Cantidad")
            {
                txt_cant.Text = "";
                txt_cant.ForeColor = Color.Violet;
                panel16.BackColor = Color.Violet;
            }
        }

        private void txt_cant_Leave(object sender, EventArgs e)
        {
            if (txt_cant.Text == "")
            {
                txt_cant.Text = "Cantidad";
                txt_cant.ForeColor = Color.WhiteSmoke;
                panel16.BackColor = Color.WhiteSmoke;

            }
        }
        

      



        private void btn_cargalist_Click(object sender, EventArgs e)
        {
            
            try
            {
                if (itemTextBox.Text != "" && productoTextBox.Text != "" && precioTextBox.Text != "" && cantidadTextBox.Text != ""&&txt_cant.Text!="")
                {
                    ListaVenta[Fila, 0] = itemTextBox.Text;
                    ListaVenta[Fila, 1] = productoTextBox.Text;
                    ListaVenta[Fila, 2] = precioTextBox.Text;
                    ListaVenta[Fila, 3] = cantidadTextBox.Text;
                    ListaVenta[Fila, 4] = txt_cant.Text;
                    ListaVenta[Fila, 5] = (float.Parse(precioTextBox.Text) * float.Parse(txt_cant.Text)).ToString();

                    dgvLista.Rows.Add(ListaVenta[Fila, 0], ListaVenta[Fila, 1], ListaVenta[Fila, 2], ListaVenta[Fila, 3], ListaVenta[Fila, 4], ListaVenta[Fila, 5]);

                    Fila++;
                   
                }
            }
            catch
            {


            }
           
            CostoApagar();
            itemTextBox.Text = "Item";
            productoTextBox.Text = "Producto";
            precioTextBox.Text = "Precio";
            cantidadTextBox.Text = "Stock";
            txt_cant.Text = "Cantidad";
        }
        public void CostoApagar()
        {
            float CostoTotal = 0;
            int Conteo = 0;

            Conteo = dgvLista.RowCount;

            for (int i = 0; i < Conteo; i++)
            {
                CostoTotal += float.Parse(dgvLista.Rows[i].Cells[4].Value.ToString());


            }
            lblCostoApagar.Text = CostoTotal.ToString();

            label8.ForeColor = Color.Turquoise; label9.ForeColor = Color.Turquoise; label12.ForeColor = Color.Turquoise; label13.ForeColor = Color.Turquoise;
            lblCostoApagar.ForeColor = Color.Turquoise; lblDevolucion.ForeColor = Color.Turquoise;
            panel10.BackColor=Color.Turquoise;panel11.BackColor=Color.Turquoise;
            try
            {

               

            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }


        }

        private void txt_efectivo_TextChanged(object sender, EventArgs e)
        {
            try
            {
                lblDevolucion.Text = (float.Parse(txt_efectivo.Text) - float.Parse(lblCostoApagar.Text)).ToString();
            }
            catch
            {

                lblDevolucion.Text = "0.00";
            }
        }

        private void txt_vender_Click(object sender, EventArgs e)
        {
            
            clasefuncion.CreaTicket Ticket1 = new clasefuncion.CreaTicket();

            Ticket1.TextoCentro("Empresa Darknees "); //imprime una linea de descripcion
            Ticket1.TextoCentro("**********************************");

            Ticket1.TextoIzquierda("Nombre: "+txt_nombre.Text);
            Ticket1.TextoIzquierda("NIT: "+txt_nit.Text);
            Ticket1.TextoIzquierda("Celular: "+txt_cel.Text);
            Ticket1.TextoIzquierda("");
            Ticket1.TextoCentro("Factura de Venta"); //imprime una linea de descripcion
            Ticket1.TextoIzquierda("No Fac: 000");
            Ticket1.TextoIzquierda("Fecha:" + DateTime.Now.ToShortDateString() + " Hora:" + DateTime.Now.ToShortTimeString());
            Ticket1.TextoIzquierda("Le Atendio: xxxx ");///////////////////////////////////
            Ticket1.TextoIzquierda("");
            clasefuncion.CreaTicket.LineasGuion();

            clasefuncion.CreaTicket.EncabezadoVenta();
            clasefuncion.CreaTicket.LineasGuion();
            foreach (DataGridViewRow r in dgvLista.Rows)
            { //                        Nombre del articulo                Precio                                   Cantidad                                SubTotal 


                Ticket1.AgregaArticulo(r.Cells[1].Value.ToString(), double.Parse(r.Cells[3].Value.ToString()), int.Parse(r.Cells[2].Value.ToString()), double.Parse(r.Cells[4].Value.ToString())); //imprime una linea de descripcion
            }
            //Ticket1.AgregaArticulo(txtNombre.Text,double.Parse (txtPrecio.Text),int.Parse (txtcantidad.Text),double.Parse( "123"));

            clasefuncion.CreaTicket.LineasGuion();
            Ticket1.AgregaTotales("Sub-Total", double.Parse(lblCostoApagar.Text)); // imprime linea con total
            Ticket1.AgregaTotales("Menos Descuento", double.Parse("0")); // imprime linea con total
            Ticket1.AgregaTotales("Mas ITBIS", double.Parse("0")); // imprime linea con total
            Ticket1.TextoIzquierda(" ");
            Ticket1.AgregaTotales("Total", double.Parse(lblCostoApagar.Text)); // imprime linea con total
            Ticket1.TextoIzquierda(" ");
            Ticket1.AgregaTotales("Efectivo Entregado:", double.Parse(txt_efectivo.Text));
            Ticket1.AgregaTotales("Efectivo Devuelto:", double.Parse(lblDevolucion.Text));


            // Ticket1.LineasTotales(); // imprime linea 

            Ticket1.TextoIzquierda(" ");
            Ticket1.TextoCentro("**********************************");
            Ticket1.TextoCentro("*     Gracias por la compra    *");

            Ticket1.TextoCentro("**********************************");
            Ticket1.TextoIzquierda(" ");
            string impresora = "Imprent Microsoft x 1"; //mpueden usar variable
            Ticket1.ImprimirTiket(impresora);
            //hasta aqui el codigo de imprimir


            Fila = 0;
            while (dgvLista.RowCount > 0)//limpia el dgv
            { dgvLista.Rows.Remove(dgvLista.CurrentRow); }
            //LBLIDnuevaFACTURA.Text = ClaseFunciones.ClsFunciones.IDNUEVAFACTURA().ToString();
            itemTextBox.Text = "Item";
            productoTextBox.Text = "Producto";
            precioTextBox.Text= "Precio";
            cantidadTextBox.Text = "Stock";
            txt_cant.Text = "Cantidad";
            txt_nombre.Text = "Nombre";
            txt_nit.Text = "NIT";
            txt_cel.Text = "Celular";
            txt_efectivo.Text = "Efectivo";
            lblCostoApagar.Text = lblDevolucion.Text = "0.00";
        }

        private void ventas_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'proyecto_finalDataSet.Inventario' Puede moverla o quitarla según sea necesario.
            this.inventarioTableAdapter.Fill(this.proyecto_finalDataSet.Inventario);
            itemTextBox.Text = "Item";
            productoTextBox.Text = "Producto";
            precioTextBox.Text = "Precio";
            cantidadTextBox.Text = "Stock";
            txt_cant.Text = "Cantidad";
            label8.ForeColor = Color.WhiteSmoke; label9.ForeColor = Color.WhiteSmoke; label12.ForeColor = Color.WhiteSmoke; label13.ForeColor = Color.WhiteSmoke;
            lblCostoApagar.ForeColor = Color.WhiteSmoke; lblDevolucion.ForeColor = Color.WhiteSmoke;
            panel10.BackColor = Color.WhiteSmoke; panel11.BackColor = Color.WhiteSmoke;
        }

        private void inventarioBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.inventarioBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.proyecto_finalDataSet);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            productouser prod = new productouser();
            prod.Show();
            panel4.Enabled = true;
        }

        private void txt_nombre_Enter(object sender, EventArgs e)
        {
           
        }

        private void txt_nombre_Leave(object sender, EventArgs e)
        {

        }

       


    }
}

