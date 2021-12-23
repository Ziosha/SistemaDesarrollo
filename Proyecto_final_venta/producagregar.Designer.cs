namespace Proyecto_final_venta
{
    partial class producagregar
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
            this.txt_codProd = new System.Windows.Forms.TextBox();
            this.txt_codProv = new System.Windows.Forms.TextBox();
            this.txt_des = new System.Windows.Forms.TextBox();
            this.txt_precio = new System.Windows.Forms.TextBox();
            this.btn_agregar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txt_cant = new System.Windows.Forms.TextBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.txt_fech = new System.Windows.Forms.TextBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.txt_cantmin = new System.Windows.Forms.TextBox();
            this.panel8 = new System.Windows.Forms.Panel();
            this.exit = new System.Windows.Forms.Button();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_codProd
            // 
            this.txt_codProd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(53)))), ((int)(((byte)(73)))));
            this.txt_codProd.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_codProd.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_codProd.ForeColor = System.Drawing.Color.White;
            this.txt_codProd.Location = new System.Drawing.Point(34, 55);
            this.txt_codProd.Name = "txt_codProd";
            this.txt_codProd.Size = new System.Drawing.Size(229, 20);
            this.txt_codProd.TabIndex = 0;
            this.txt_codProd.Text = "Codigo Producto";
            this.txt_codProd.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.txt_codProd.Leave += new System.EventHandler(this.txt_item_Leave);
            // 
            // txt_codProv
            // 
            this.txt_codProv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(53)))), ((int)(((byte)(73)))));
            this.txt_codProv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_codProv.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_codProv.ForeColor = System.Drawing.Color.White;
            this.txt_codProv.Location = new System.Drawing.Point(34, 92);
            this.txt_codProv.Name = "txt_codProv";
            this.txt_codProv.Size = new System.Drawing.Size(229, 20);
            this.txt_codProv.TabIndex = 1;
            this.txt_codProv.Text = "Codigo Proveedor";
            this.txt_codProv.TextChanged += new System.EventHandler(this.txt_producto_TextChanged);
            this.txt_codProv.Enter += new System.EventHandler(this.txt_producto_Enter);
            this.txt_codProv.Leave += new System.EventHandler(this.txt_producto_Leave);
            // 
            // txt_des
            // 
            this.txt_des.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(53)))), ((int)(((byte)(73)))));
            this.txt_des.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_des.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_des.ForeColor = System.Drawing.Color.White;
            this.txt_des.Location = new System.Drawing.Point(34, 129);
            this.txt_des.Name = "txt_des";
            this.txt_des.Size = new System.Drawing.Size(229, 20);
            this.txt_des.TabIndex = 2;
            this.txt_des.Text = "Descripcion";
            this.txt_des.TextChanged += new System.EventHandler(this.txt_cantidad_TextChanged);
            this.txt_des.Enter += new System.EventHandler(this.txt_cantidad_Enter);
            this.txt_des.Leave += new System.EventHandler(this.txt_cantidad_Leave);
            // 
            // txt_precio
            // 
            this.txt_precio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(53)))), ((int)(((byte)(73)))));
            this.txt_precio.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_precio.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_precio.ForeColor = System.Drawing.Color.White;
            this.txt_precio.Location = new System.Drawing.Point(34, 167);
            this.txt_precio.Name = "txt_precio";
            this.txt_precio.Size = new System.Drawing.Size(229, 20);
            this.txt_precio.TabIndex = 3;
            this.txt_precio.Text = "Precio Compra";
            this.txt_precio.TextChanged += new System.EventHandler(this.txt_precio_TextChanged);
            this.txt_precio.Enter += new System.EventHandler(this.txt_precio_Enter);
            this.txt_precio.Leave += new System.EventHandler(this.txt_precio_Leave);
            // 
            // btn_agregar
            // 
            this.btn_agregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(53)))), ((int)(((byte)(73)))));
            this.btn_agregar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(159)))), ((int)(((byte)(127)))));
            this.btn_agregar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.btn_agregar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(118)))), ((int)(((byte)(126)))));
            this.btn_agregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_agregar.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_agregar.ForeColor = System.Drawing.Color.LightGray;
            this.btn_agregar.Location = new System.Drawing.Point(63, 366);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(160, 40);
            this.btn_agregar.TabIndex = 4;
            this.btn_agregar.Text = "Agregar";
            this.btn_agregar.UseVisualStyleBackColor = false;
            this.btn_agregar.Click += new System.EventHandler(this.btn_agregar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.ForeColor = System.Drawing.Color.GreenYellow;
            this.panel1.Location = new System.Drawing.Point(34, 83);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(229, 1);
            this.panel1.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.ForeColor = System.Drawing.Color.GreenYellow;
            this.panel2.Location = new System.Drawing.Point(34, 118);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(229, 1);
            this.panel2.TabIndex = 6;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.ForeColor = System.Drawing.Color.GreenYellow;
            this.panel3.Location = new System.Drawing.Point(34, 157);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(229, 1);
            this.panel3.TabIndex = 6;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.ForeColor = System.Drawing.Color.GreenYellow;
            this.panel4.Location = new System.Drawing.Point(34, 195);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(229, 1);
            this.panel4.TabIndex = 6;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel5.Controls.Add(this.exit);
            this.panel5.Controls.Add(this.label1);
            this.panel5.Controls.Add(this.button1);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(298, 30);
            this.panel5.TabIndex = 7;
            this.panel5.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel5_MouseMove);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(68, 6);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 21);
            this.label1.TabIndex = 9;
            this.label1.Text = "AGREGAR-PRODUCTO";
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::Proyecto_final_venta.Properties.Resources.close_azul___1511_;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(360, 1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(30, 30);
            this.button1.TabIndex = 8;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_cant
            // 
            this.txt_cant.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(53)))), ((int)(((byte)(73)))));
            this.txt_cant.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_cant.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cant.ForeColor = System.Drawing.Color.White;
            this.txt_cant.Location = new System.Drawing.Point(34, 204);
            this.txt_cant.Name = "txt_cant";
            this.txt_cant.Size = new System.Drawing.Size(229, 20);
            this.txt_cant.TabIndex = 8;
            this.txt_cant.Text = "Cantidad";
            this.txt_cant.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.White;
            this.panel6.ForeColor = System.Drawing.Color.GreenYellow;
            this.panel6.Location = new System.Drawing.Point(34, 232);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(229, 1);
            this.panel6.TabIndex = 9;
            // 
            // txt_fech
            // 
            this.txt_fech.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(53)))), ((int)(((byte)(73)))));
            this.txt_fech.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_fech.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_fech.ForeColor = System.Drawing.Color.White;
            this.txt_fech.Location = new System.Drawing.Point(34, 239);
            this.txt_fech.Name = "txt_fech";
            this.txt_fech.Size = new System.Drawing.Size(229, 20);
            this.txt_fech.TabIndex = 10;
            this.txt_fech.Text = "Fecha Vencimiento";
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.White;
            this.panel7.ForeColor = System.Drawing.Color.GreenYellow;
            this.panel7.Location = new System.Drawing.Point(34, 265);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(229, 1);
            this.panel7.TabIndex = 11;
            // 
            // txt_cantmin
            // 
            this.txt_cantmin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(53)))), ((int)(((byte)(73)))));
            this.txt_cantmin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_cantmin.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cantmin.ForeColor = System.Drawing.Color.White;
            this.txt_cantmin.Location = new System.Drawing.Point(34, 274);
            this.txt_cantmin.Name = "txt_cantmin";
            this.txt_cantmin.Size = new System.Drawing.Size(229, 20);
            this.txt_cantmin.TabIndex = 12;
            this.txt_cantmin.Text = "Cantidad Minima";
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.White;
            this.panel8.ForeColor = System.Drawing.Color.GreenYellow;
            this.panel8.Location = new System.Drawing.Point(34, 301);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(229, 1);
            this.panel8.TabIndex = 10;
            // 
            // exit
            // 
            this.exit.BackColor = System.Drawing.SystemColors.Highlight;
            this.exit.BackgroundImage = global::Proyecto_final_venta.Properties.Resources.close_azul___1511_;
            this.exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.exit.FlatAppearance.BorderSize = 0;
            this.exit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exit.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit.ForeColor = System.Drawing.Color.LightGray;
            this.exit.Location = new System.Drawing.Point(262, 3);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(33, 25);
            this.exit.TabIndex = 13;
            this.exit.UseVisualStyleBackColor = false;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // producagregar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(57)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(298, 418);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.txt_cantmin);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.txt_fech);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.txt_cant);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_agregar);
            this.Controls.Add(this.txt_precio);
            this.Controls.Add(this.txt_des);
            this.Controls.Add(this.txt_codProv);
            this.Controls.Add(this.txt_codProd);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "producagregar";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "producagregar";
            this.Load += new System.EventHandler(this.producagregar_Load);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_codProd;
        private System.Windows.Forms.TextBox txt_codProv;
        private System.Windows.Forms.TextBox txt_des;
        private System.Windows.Forms.TextBox txt_precio;
        private System.Windows.Forms.Button btn_agregar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txt_cant;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_fech;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.TextBox txt_cantmin;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Button exit;
    }
}