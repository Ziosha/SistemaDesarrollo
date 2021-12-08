namespace Proyecto_final_venta
{
    partial class compra
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label itemLabel;
            System.Windows.Forms.Label productoLabel;
            System.Windows.Forms.Label cantidadLabel;
            System.Windows.Forms.Label precioLabel;
            this.btn_cargalist = new System.Windows.Forms.Button();
            this.dgvLista = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel11 = new System.Windows.Forms.Panel();
            this.lblDevolucion = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.lblCostoApagar = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_efectivo = new System.Windows.Forms.TextBox();
            this.txt_vender = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txt_cant = new System.Windows.Forms.TextBox();
            this.inventarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.proyecto_finalDataSet = new Proyecto_final_venta.proyecto_finalDataSet();
            this.panel16 = new System.Windows.Forms.Panel();
            this.itemTextBox = new System.Windows.Forms.TextBox();
            this.productoTextBox = new System.Windows.Forms.TextBox();
            this.cantidadTextBox = new System.Windows.Forms.TextBox();
            this.precioTextBox = new System.Windows.Forms.TextBox();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel15 = new System.Windows.Forms.Panel();
            this.panel14 = new System.Windows.Forms.Panel();
            this.panel13 = new System.Windows.Forms.Panel();
            this.panel12 = new System.Windows.Forms.Panel();
            this.txt_cel = new System.Windows.Forms.TextBox();
            this.txt_nit = new System.Windows.Forms.TextBox();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.inventarioTableAdapter = new Proyecto_final_venta.proyecto_finalDataSetTableAdapters.InventarioTableAdapter();
            this.tableAdapterManager = new Proyecto_final_venta.proyecto_finalDataSetTableAdapters.TableAdapterManager();
            this.button1 = new System.Windows.Forms.Button();
            this.itemTextBox1 = new System.Windows.Forms.TextBox();
            this.productoTextBox1 = new System.Windows.Forms.TextBox();
            this.cantidadTextBox1 = new System.Windows.Forms.TextBox();
            this.precioTextBox1 = new System.Windows.Forms.TextBox();
            itemLabel = new System.Windows.Forms.Label();
            productoLabel = new System.Windows.Forms.Label();
            cantidadLabel = new System.Windows.Forms.Label();
            precioLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLista)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inventarioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proyecto_finalDataSet)).BeginInit();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_cargalist
            // 
            this.btn_cargalist.FlatAppearance.BorderSize = 0;
            this.btn_cargalist.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_cargalist.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cargalist.Font = new System.Drawing.Font("Minion Pro Med", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cargalist.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_cargalist.Location = new System.Drawing.Point(12, 281);
            this.btn_cargalist.Name = "btn_cargalist";
            this.btn_cargalist.Size = new System.Drawing.Size(254, 34);
            this.btn_cargalist.TabIndex = 11;
            this.btn_cargalist.Text = "Cargar a lista";
            this.btn_cargalist.UseVisualStyleBackColor = true;
            this.btn_cargalist.Click += new System.EventHandler(this.btn_cargalist_Click);
            // 
            // dgvLista
            // 
            this.dgvLista.AllowUserToAddRows = false;
            this.dgvLista.AllowUserToDeleteRows = false;
            this.dgvLista.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLista.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dgvLista.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvLista.Location = new System.Drawing.Point(281, 25);
            this.dgvLista.Name = "dgvLista";
            this.dgvLista.ReadOnly = true;
            this.dgvLista.RowHeadersVisible = false;
            this.dgvLista.Size = new System.Drawing.Size(400, 208);
            this.dgvLista.TabIndex = 12;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Item";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Producto";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Precio";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Cantidad";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Total";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DarkBlue;
            this.panel3.Controls.Add(this.panel11);
            this.panel3.Controls.Add(this.lblDevolucion);
            this.panel3.Controls.Add(this.label13);
            this.panel3.Controls.Add(this.label12);
            this.panel3.Location = new System.Drawing.Point(3, 108);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(272, 30);
            this.panel3.TabIndex = 26;
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.Color.AliceBlue;
            this.panel11.Location = new System.Drawing.Point(16, 23);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(243, 1);
            this.panel11.TabIndex = 37;
            // 
            // lblDevolucion
            // 
            this.lblDevolucion.AutoSize = true;
            this.lblDevolucion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDevolucion.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblDevolucion.Location = new System.Drawing.Point(130, 4);
            this.lblDevolucion.Name = "lblDevolucion";
            this.lblDevolucion.Size = new System.Drawing.Size(44, 20);
            this.lblDevolucion.TabIndex = 19;
            this.lblDevolucion.Text = "0.00";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Minion Pro Med", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label13.Location = new System.Drawing.Point(12, 2);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(91, 22);
            this.label13.TabIndex = 25;
            this.label13.Text = "Devolución:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label12.Location = new System.Drawing.Point(112, 4);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(19, 20);
            this.label12.TabIndex = 18;
            this.label12.Text = "$";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkBlue;
            this.panel2.Controls.Add(this.panel10);
            this.panel2.Controls.Add(this.lblCostoApagar);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Location = new System.Drawing.Point(3, 38);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(272, 29);
            this.panel2.TabIndex = 24;
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.AliceBlue;
            this.panel10.Location = new System.Drawing.Point(17, 23);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(243, 1);
            this.panel10.TabIndex = 36;
            // 
            // lblCostoApagar
            // 
            this.lblCostoApagar.AutoSize = true;
            this.lblCostoApagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCostoApagar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblCostoApagar.Location = new System.Drawing.Point(132, 5);
            this.lblCostoApagar.Name = "lblCostoApagar";
            this.lblCostoApagar.Size = new System.Drawing.Size(44, 20);
            this.lblCostoApagar.TabIndex = 19;
            this.lblCostoApagar.Text = "0.00";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label9.Location = new System.Drawing.Point(114, 5);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(19, 20);
            this.label9.TabIndex = 18;
            this.label9.Text = "$";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Minion Pro Med", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label8.Location = new System.Drawing.Point(12, 2);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 22);
            this.label8.TabIndex = 23;
            this.label8.Text = "Total apagar:";
            // 
            // txt_efectivo
            // 
            this.txt_efectivo.BackColor = System.Drawing.Color.DarkBlue;
            this.txt_efectivo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_efectivo.Font = new System.Drawing.Font("Minion Pro Med", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_efectivo.ForeColor = System.Drawing.Color.AliceBlue;
            this.txt_efectivo.Location = new System.Drawing.Point(33, 110);
            this.txt_efectivo.Name = "txt_efectivo";
            this.txt_efectivo.Size = new System.Drawing.Size(227, 22);
            this.txt_efectivo.TabIndex = 29;
            this.txt_efectivo.Text = "Efectivo";
            this.txt_efectivo.TextChanged += new System.EventHandler(this.txt_efectivo_TextChanged);
            // 
            // txt_vender
            // 
            this.txt_vender.BackColor = System.Drawing.Color.Transparent;
            this.txt_vender.FlatAppearance.BorderSize = 0;
            this.txt_vender.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txt_vender.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txt_vender.Font = new System.Drawing.Font("Minion Pro", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_vender.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.txt_vender.Location = new System.Drawing.Point(35, 142);
            this.txt_vender.Name = "txt_vender";
            this.txt_vender.Size = new System.Drawing.Size(242, 57);
            this.txt_vender.TabIndex = 27;
            this.txt_vender.Text = "Vender";
            this.txt_vender.UseVisualStyleBackColor = false;
            this.txt_vender.Click += new System.EventHandler(this.txt_vender_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(12, 322);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(302, 165);
            this.panel1.TabIndex = 30;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(itemLabel);
            this.panel4.Controls.Add(this.itemTextBox1);
            this.panel4.Controls.Add(productoLabel);
            this.panel4.Controls.Add(this.productoTextBox1);
            this.panel4.Controls.Add(cantidadLabel);
            this.panel4.Controls.Add(this.cantidadTextBox1);
            this.panel4.Controls.Add(precioLabel);
            this.panel4.Controls.Add(this.precioTextBox1);
            this.panel4.Controls.Add(this.txt_cant);
            this.panel4.Controls.Add(this.panel16);
            this.panel4.Controls.Add(this.itemTextBox);
            this.panel4.Controls.Add(this.productoTextBox);
            this.panel4.Controls.Add(this.cantidadTextBox);
            this.panel4.Controls.Add(this.precioTextBox);
            this.panel4.Controls.Add(this.panel9);
            this.panel4.Controls.Add(this.panel8);
            this.panel4.Controls.Add(this.panel7);
            this.panel4.Controls.Add(this.panel6);
            this.panel4.Enabled = false;
            this.panel4.Location = new System.Drawing.Point(15, 65);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(275, 297);
            this.panel4.TabIndex = 31;
            // 
            // txt_cant
            // 
            this.txt_cant.BackColor = System.Drawing.Color.DarkBlue;
            this.txt_cant.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_cant.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.inventarioBindingSource, "Precio", true));
            this.txt_cant.Font = new System.Drawing.Font("Minion Pro", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cant.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.txt_cant.Location = new System.Drawing.Point(21, 131);
            this.txt_cant.Name = "txt_cant";
            this.txt_cant.Size = new System.Drawing.Size(214, 22);
            this.txt_cant.TabIndex = 45;
            this.txt_cant.Text = "Cantidad";
            this.txt_cant.Enter += new System.EventHandler(this.txt_cant_Enter);
            this.txt_cant.Leave += new System.EventHandler(this.txt_cant_Leave);
            // 
            // inventarioBindingSource
            // 
            this.inventarioBindingSource.DataMember = "Inventario";
            this.inventarioBindingSource.DataSource = this.proyecto_finalDataSet;
            // 
            // proyecto_finalDataSet
            // 
            this.proyecto_finalDataSet.DataSetName = "proyecto_finalDataSet";
            this.proyecto_finalDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel16
            // 
            this.panel16.BackColor = System.Drawing.Color.AliceBlue;
            this.panel16.Location = new System.Drawing.Point(21, 155);
            this.panel16.Name = "panel16";
            this.panel16.Size = new System.Drawing.Size(213, 1);
            this.panel16.TabIndex = 44;
            // 
            // itemTextBox
            // 
            this.itemTextBox.BackColor = System.Drawing.Color.DarkBlue;
            this.itemTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.itemTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.inventarioBindingSource, "Item", true));
            this.itemTextBox.Enabled = false;
            this.itemTextBox.Font = new System.Drawing.Font("Minion Pro", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemTextBox.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.itemTextBox.Location = new System.Drawing.Point(19, 13);
            this.itemTextBox.Name = "itemTextBox";
            this.itemTextBox.Size = new System.Drawing.Size(214, 22);
            this.itemTextBox.TabIndex = 37;
            this.itemTextBox.Text = "Item";
            this.itemTextBox.Enter += new System.EventHandler(this.itemTextBox_Enter_1);
            this.itemTextBox.Leave += new System.EventHandler(this.itemTextBox_Leave);
            // 
            // productoTextBox
            // 
            this.productoTextBox.BackColor = System.Drawing.Color.DarkBlue;
            this.productoTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.productoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.inventarioBindingSource, "Producto", true));
            this.productoTextBox.Enabled = false;
            this.productoTextBox.Font = new System.Drawing.Font("Minion Pro", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productoTextBox.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.productoTextBox.Location = new System.Drawing.Point(19, 41);
            this.productoTextBox.Name = "productoTextBox";
            this.productoTextBox.Size = new System.Drawing.Size(214, 22);
            this.productoTextBox.TabIndex = 39;
            this.productoTextBox.Text = "Producto";
            this.productoTextBox.Enter += new System.EventHandler(this.productoTextBox_Enter);
            this.productoTextBox.Leave += new System.EventHandler(this.productoTextBox_Leave);
            // 
            // cantidadTextBox
            // 
            this.cantidadTextBox.BackColor = System.Drawing.Color.DarkBlue;
            this.cantidadTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cantidadTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.inventarioBindingSource, "Cantidad", true));
            this.cantidadTextBox.Enabled = false;
            this.cantidadTextBox.Font = new System.Drawing.Font("Minion Pro", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cantidadTextBox.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.cantidadTextBox.Location = new System.Drawing.Point(19, 70);
            this.cantidadTextBox.Name = "cantidadTextBox";
            this.cantidadTextBox.Size = new System.Drawing.Size(214, 22);
            this.cantidadTextBox.TabIndex = 41;
            this.cantidadTextBox.Text = "Stock";
            this.cantidadTextBox.Enter += new System.EventHandler(this.cantidadTextBox_Enter);
            this.cantidadTextBox.Leave += new System.EventHandler(this.cantidadTextBox_Leave);
            // 
            // precioTextBox
            // 
            this.precioTextBox.BackColor = System.Drawing.Color.DarkBlue;
            this.precioTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.precioTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.inventarioBindingSource, "Precio", true));
            this.precioTextBox.Enabled = false;
            this.precioTextBox.Font = new System.Drawing.Font("Minion Pro", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.precioTextBox.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.precioTextBox.Location = new System.Drawing.Point(20, 100);
            this.precioTextBox.Name = "precioTextBox";
            this.precioTextBox.Size = new System.Drawing.Size(214, 22);
            this.precioTextBox.TabIndex = 43;
            this.precioTextBox.Text = "Precio";
            this.precioTextBox.Enter += new System.EventHandler(this.precioTextBox_Enter);
            this.precioTextBox.Leave += new System.EventHandler(this.precioTextBox_Leave);
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.AliceBlue;
            this.panel9.Location = new System.Drawing.Point(20, 124);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(213, 1);
            this.panel9.TabIndex = 36;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.AliceBlue;
            this.panel8.Location = new System.Drawing.Point(20, 94);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(213, 1);
            this.panel8.TabIndex = 35;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.AliceBlue;
            this.panel7.Location = new System.Drawing.Point(20, 65);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(213, 1);
            this.panel7.TabIndex = 34;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.AliceBlue;
            this.panel6.Location = new System.Drawing.Point(20, 36);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(213, 1);
            this.panel6.TabIndex = 33;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.DarkBlue;
            this.panel5.Controls.Add(this.panel15);
            this.panel5.Controls.Add(this.panel14);
            this.panel5.Controls.Add(this.panel13);
            this.panel5.Controls.Add(this.panel12);
            this.panel5.Controls.Add(this.txt_cel);
            this.panel5.Controls.Add(this.txt_nit);
            this.panel5.Controls.Add(this.txt_nombre);
            this.panel5.Controls.Add(this.txt_efectivo);
            this.panel5.Controls.Add(this.txt_vender);
            this.panel5.ForeColor = System.Drawing.Color.AliceBlue;
            this.panel5.Location = new System.Drawing.Point(384, 283);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(297, 204);
            this.panel5.TabIndex = 32;
            // 
            // panel15
            // 
            this.panel15.BackColor = System.Drawing.Color.AliceBlue;
            this.panel15.Location = new System.Drawing.Point(35, 130);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(243, 1);
            this.panel15.TabIndex = 40;
            // 
            // panel14
            // 
            this.panel14.BackColor = System.Drawing.Color.AliceBlue;
            this.panel14.Location = new System.Drawing.Point(35, 97);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(243, 1);
            this.panel14.TabIndex = 39;
            // 
            // panel13
            // 
            this.panel13.BackColor = System.Drawing.Color.AliceBlue;
            this.panel13.Location = new System.Drawing.Point(34, 64);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(243, 1);
            this.panel13.TabIndex = 38;
            // 
            // panel12
            // 
            this.panel12.BackColor = System.Drawing.Color.AliceBlue;
            this.panel12.Location = new System.Drawing.Point(35, 32);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(243, 1);
            this.panel12.TabIndex = 37;
            // 
            // txt_cel
            // 
            this.txt_cel.BackColor = System.Drawing.Color.DarkBlue;
            this.txt_cel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_cel.Font = new System.Drawing.Font("Minion Pro Med", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cel.ForeColor = System.Drawing.Color.AliceBlue;
            this.txt_cel.Location = new System.Drawing.Point(33, 77);
            this.txt_cel.Name = "txt_cel";
            this.txt_cel.Size = new System.Drawing.Size(227, 21);
            this.txt_cel.TabIndex = 32;
            this.txt_cel.Text = "Celular";
            // 
            // txt_nit
            // 
            this.txt_nit.BackColor = System.Drawing.Color.DarkBlue;
            this.txt_nit.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_nit.Font = new System.Drawing.Font("Minion Pro Med", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nit.ForeColor = System.Drawing.Color.AliceBlue;
            this.txt_nit.Location = new System.Drawing.Point(33, 45);
            this.txt_nit.Name = "txt_nit";
            this.txt_nit.Size = new System.Drawing.Size(227, 21);
            this.txt_nit.TabIndex = 31;
            this.txt_nit.Text = "NIT";
            // 
            // txt_nombre
            // 
            this.txt_nombre.BackColor = System.Drawing.Color.DarkBlue;
            this.txt_nombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_nombre.Font = new System.Drawing.Font("Minion Pro Med", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nombre.ForeColor = System.Drawing.Color.AliceBlue;
            this.txt_nombre.Location = new System.Drawing.Point(33, 13);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(227, 21);
            this.txt_nombre.TabIndex = 30;
            this.txt_nombre.Text = "Nombre";
            this.txt_nombre.Enter += new System.EventHandler(this.txt_nombre_Enter);
            this.txt_nombre.Leave += new System.EventHandler(this.txt_nombre_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Minion Pro", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(480, 254);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 26);
            this.label1.TabIndex = 33;
            this.label1.Text = "Datos Factura";
            // 
            // inventarioTableAdapter
            // 
            this.inventarioTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.InventarioTableAdapter = this.inventarioTableAdapter;
            this.tableAdapterManager.InventariototalTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Proyecto_final_venta.proyecto_finalDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.usersTableAdapter = null;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Minion Pro Med", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(15, 25);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(254, 34);
            this.button1.TabIndex = 34;
            this.button1.Text = "Selecionar Item";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // itemLabel
            // 
            itemLabel.AutoSize = true;
            itemLabel.Location = new System.Drawing.Point(37, 175);
            itemLabel.Name = "itemLabel";
            itemLabel.Size = new System.Drawing.Size(30, 13);
            itemLabel.TabIndex = 45;
            itemLabel.Text = "Item:";
            // 
            // itemTextBox1
            // 
            this.itemTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.inventarioBindingSource, "Item", true));
            this.itemTextBox1.Location = new System.Drawing.Point(96, 172);
            this.itemTextBox1.Name = "itemTextBox1";
            this.itemTextBox1.Size = new System.Drawing.Size(100, 20);
            this.itemTextBox1.TabIndex = 46;
            // 
            // productoLabel
            // 
            productoLabel.AutoSize = true;
            productoLabel.Location = new System.Drawing.Point(37, 201);
            productoLabel.Name = "productoLabel";
            productoLabel.Size = new System.Drawing.Size(53, 13);
            productoLabel.TabIndex = 47;
            productoLabel.Text = "Producto:";
            // 
            // productoTextBox1
            // 
            this.productoTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.inventarioBindingSource, "Producto", true));
            this.productoTextBox1.Location = new System.Drawing.Point(96, 198);
            this.productoTextBox1.Name = "productoTextBox1";
            this.productoTextBox1.Size = new System.Drawing.Size(100, 20);
            this.productoTextBox1.TabIndex = 48;
            // 
            // cantidadLabel
            // 
            cantidadLabel.AutoSize = true;
            cantidadLabel.Location = new System.Drawing.Point(37, 227);
            cantidadLabel.Name = "cantidadLabel";
            cantidadLabel.Size = new System.Drawing.Size(52, 13);
            cantidadLabel.TabIndex = 49;
            cantidadLabel.Text = "Cantidad:";
            // 
            // cantidadTextBox1
            // 
            this.cantidadTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.inventarioBindingSource, "Cantidad", true));
            this.cantidadTextBox1.Location = new System.Drawing.Point(96, 224);
            this.cantidadTextBox1.Name = "cantidadTextBox1";
            this.cantidadTextBox1.Size = new System.Drawing.Size(100, 20);
            this.cantidadTextBox1.TabIndex = 50;
            // 
            // precioLabel
            // 
            precioLabel.AutoSize = true;
            precioLabel.Location = new System.Drawing.Point(37, 253);
            precioLabel.Name = "precioLabel";
            precioLabel.Size = new System.Drawing.Size(40, 13);
            precioLabel.TabIndex = 51;
            precioLabel.Text = "Precio:";
            // 
            // precioTextBox1
            // 
            this.precioTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.inventarioBindingSource, "Precio", true));
            this.precioTextBox1.Location = new System.Drawing.Point(96, 250);
            this.precioTextBox1.Name = "precioTextBox1";
            this.precioTextBox1.Size = new System.Drawing.Size(100, 20);
            this.precioTextBox1.TabIndex = 52;
            // 
            // ventas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkBlue;
            this.ClientSize = new System.Drawing.Size(693, 499);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvLista);
            this.Controls.Add(this.btn_cargalist);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ventas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ventas";
            this.Load += new System.EventHandler(this.ventas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLista)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inventarioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proyecto_finalDataSet)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_cargalist;
        private System.Windows.Forms.DataGridView dgvLista;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblDevolucion;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblCostoApagar;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_efectivo;
        private System.Windows.Forms.Button txt_vender;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox txt_cel;
        private System.Windows.Forms.TextBox txt_nit;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.Panel panel15;
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Label label1;
        private proyecto_finalDataSet proyecto_finalDataSet;
        private System.Windows.Forms.BindingSource inventarioBindingSource;
        private proyecto_finalDataSetTableAdapters.InventarioTableAdapter inventarioTableAdapter;
        private proyecto_finalDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox itemTextBox;
        private System.Windows.Forms.TextBox productoTextBox;
        private System.Windows.Forms.TextBox cantidadTextBox;
        private System.Windows.Forms.TextBox precioTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txt_cant;
        private System.Windows.Forms.Panel panel16;
        private System.Windows.Forms.TextBox itemTextBox1;
        private System.Windows.Forms.TextBox productoTextBox1;
        private System.Windows.Forms.TextBox cantidadTextBox1;
        private System.Windows.Forms.TextBox precioTextBox1;
    }
}