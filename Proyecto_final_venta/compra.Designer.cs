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
            this.inventarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dgvLista = new System.Windows.Forms.DataGridView();
            this.btn_confirmar = new System.Windows.Forms.Button();
            this.btn_agre = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cb_cod = new System.Windows.Forms.ComboBox();
            this.btn_new = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_can = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_pag = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_pre = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_prod = new System.Windows.Forms.TextBox();
            this.btn_res = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.inventarioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLista)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // inventarioBindingSource
            // 
            this.inventarioBindingSource.DataMember = "Inventario";
            // 
            // dgvLista
            // 
            this.dgvLista.BackgroundColor = System.Drawing.SystemColors.InactiveCaption;
            this.dgvLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLista.Location = new System.Drawing.Point(38, 264);
            this.dgvLista.Name = "dgvLista";
            this.dgvLista.RowHeadersWidth = 51;
            this.dgvLista.Size = new System.Drawing.Size(651, 212);
            this.dgvLista.TabIndex = 0;
            // 
            // btn_confirmar
            // 
            this.btn_confirmar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(53)))), ((int)(((byte)(73)))));
            this.btn_confirmar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(159)))), ((int)(((byte)(127)))));
            this.btn_confirmar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.btn_confirmar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(118)))), ((int)(((byte)(126)))));
            this.btn_confirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_confirmar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_confirmar.ForeColor = System.Drawing.Color.LightGray;
            this.btn_confirmar.Location = new System.Drawing.Point(585, 501);
            this.btn_confirmar.Name = "btn_confirmar";
            this.btn_confirmar.Size = new System.Drawing.Size(104, 34);
            this.btn_confirmar.TabIndex = 1;
            this.btn_confirmar.Text = "Confirmar";
            this.btn_confirmar.UseVisualStyleBackColor = false;
            this.btn_confirmar.Visible = false;
            this.btn_confirmar.Click += new System.EventHandler(this.btn_confirmar_Click);
            // 
            // btn_agre
            // 
            this.btn_agre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(53)))), ((int)(((byte)(73)))));
            this.btn_agre.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(159)))), ((int)(((byte)(127)))));
            this.btn_agre.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.btn_agre.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(118)))), ((int)(((byte)(126)))));
            this.btn_agre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_agre.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_agre.ForeColor = System.Drawing.Color.LightGray;
            this.btn_agre.Location = new System.Drawing.Point(599, 182);
            this.btn_agre.Name = "btn_agre";
            this.btn_agre.Size = new System.Drawing.Size(90, 30);
            this.btn_agre.TabIndex = 2;
            this.btn_agre.Text = "Agregar";
            this.btn_agre.UseVisualStyleBackColor = false;
            this.btn_agre.Visible = false;
            this.btn_agre.Click += new System.EventHandler(this.btn_agre_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Silver;
            this.label1.Location = new System.Drawing.Point(34, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Seleccione el Codigo";
            // 
            // cb_cod
            // 
            this.cb_cod.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(53)))), ((int)(((byte)(73)))));
            this.cb_cod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_cod.Enabled = false;
            this.cb_cod.ForeColor = System.Drawing.Color.Silver;
            this.cb_cod.FormattingEnabled = true;
            this.cb_cod.Location = new System.Drawing.Point(38, 103);
            this.cb_cod.Name = "cb_cod";
            this.cb_cod.Size = new System.Drawing.Size(147, 21);
            this.cb_cod.TabIndex = 4;
            this.cb_cod.SelectedIndexChanged += new System.EventHandler(this.cb_cod_SelectedIndexChanged);
            // 
            // btn_new
            // 
            this.btn_new.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(53)))), ((int)(((byte)(73)))));
            this.btn_new.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(159)))), ((int)(((byte)(127)))));
            this.btn_new.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.btn_new.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(118)))), ((int)(((byte)(126)))));
            this.btn_new.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_new.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_new.ForeColor = System.Drawing.Color.LightGray;
            this.btn_new.Location = new System.Drawing.Point(599, 218);
            this.btn_new.Name = "btn_new";
            this.btn_new.Size = new System.Drawing.Size(90, 30);
            this.btn_new.TabIndex = 5;
            this.btn_new.Text = "Nuevo";
            this.btn_new.UseVisualStyleBackColor = false;
            this.btn_new.Click += new System.EventHandler(this.btn_new_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(53)))), ((int)(((byte)(73)))));
            this.btn_cancel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(159)))), ((int)(((byte)(127)))));
            this.btn_cancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.btn_cancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(118)))), ((int)(((byte)(126)))));
            this.btn_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancel.ForeColor = System.Drawing.Color.LightGray;
            this.btn_cancel.Location = new System.Drawing.Point(38, 503);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(98, 32);
            this.btn_cancel.TabIndex = 6;
            this.btn_cancel.Text = "Cancelar";
            this.btn_cancel.UseVisualStyleBackColor = false;
            this.btn_cancel.Visible = false;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Silver;
            this.label2.Location = new System.Drawing.Point(342, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Cantidad";
            // 
            // txt_can
            // 
            this.txt_can.BackColor = System.Drawing.Color.Silver;
            this.txt_can.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_can.Enabled = false;
            this.txt_can.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_can.ForeColor = System.Drawing.Color.Black;
            this.txt_can.Location = new System.Drawing.Point(344, 109);
            this.txt_can.Name = "txt_can";
            this.txt_can.Size = new System.Drawing.Size(99, 16);
            this.txt_can.TabIndex = 8;
            this.txt_can.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_can.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.txt_can.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_can_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Silver;
            this.label3.Location = new System.Drawing.Point(34, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Pago";
            // 
            // txt_pag
            // 
            this.txt_pag.BackColor = System.Drawing.Color.Silver;
            this.txt_pag.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_pag.Enabled = false;
            this.txt_pag.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_pag.ForeColor = System.Drawing.Color.Black;
            this.txt_pag.Location = new System.Drawing.Point(37, 164);
            this.txt_pag.Name = "txt_pag";
            this.txt_pag.Size = new System.Drawing.Size(99, 16);
            this.txt_pag.TabIndex = 10;
            this.txt_pag.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_pag.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_pag_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Silver;
            this.label4.Location = new System.Drawing.Point(207, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Precio Compra";
            // 
            // txt_pre
            // 
            this.txt_pre.BackColor = System.Drawing.Color.Silver;
            this.txt_pre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_pre.Enabled = false;
            this.txt_pre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_pre.ForeColor = System.Drawing.Color.Black;
            this.txt_pre.Location = new System.Drawing.Point(209, 164);
            this.txt_pre.Name = "txt_pre";
            this.txt_pre.Size = new System.Drawing.Size(99, 16);
            this.txt_pre.TabIndex = 12;
            this.txt_pre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_pre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_pre_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Silver;
            this.label6.Location = new System.Drawing.Point(207, 83);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 20);
            this.label6.TabIndex = 14;
            this.label6.Text = "Producto";
            // 
            // txt_prod
            // 
            this.txt_prod.BackColor = System.Drawing.Color.Silver;
            this.txt_prod.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_prod.Enabled = false;
            this.txt_prod.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_prod.ForeColor = System.Drawing.Color.Black;
            this.txt_prod.Location = new System.Drawing.Point(209, 108);
            this.txt_prod.Name = "txt_prod";
            this.txt_prod.Size = new System.Drawing.Size(99, 16);
            this.txt_prod.TabIndex = 15;
            this.txt_prod.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_res
            // 
            this.btn_res.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(53)))), ((int)(((byte)(73)))));
            this.btn_res.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(159)))), ((int)(((byte)(127)))));
            this.btn_res.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.btn_res.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(118)))), ((int)(((byte)(126)))));
            this.btn_res.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_res.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_res.ForeColor = System.Drawing.Color.LightGray;
            this.btn_res.Location = new System.Drawing.Point(599, 218);
            this.btn_res.Name = "btn_res";
            this.btn_res.Size = new System.Drawing.Size(90, 30);
            this.btn_res.TabIndex = 16;
            this.btn_res.Text = "refresh";
            this.btn_res.UseVisualStyleBackColor = false;
            this.btn_res.Visible = false;
            this.btn_res.Click += new System.EventHandler(this.btn_res_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(182)))));
            this.panel1.Controls.Add(this.label5);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(718, 36);
            this.panel1.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(315, 8);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 21);
            this.label5.TabIndex = 18;
            this.label5.Text = "COMPRA";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // compra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(57)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(718, 570);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_res);
            this.Controls.Add(this.txt_prod);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_pre);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_pag);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_can);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_new);
            this.Controls.Add(this.cb_cod);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_agre);
            this.Controls.Add(this.btn_confirmar);
            this.Controls.Add(this.dgvLista);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "compra";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ventas";
            this.Load += new System.EventHandler(this.compra_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.inventarioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLista)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource inventarioBindingSource;
        private System.Windows.Forms.DataGridView dgvLista;
        private System.Windows.Forms.Button btn_confirmar;
        private System.Windows.Forms.Button btn_agre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_cod;
        private System.Windows.Forms.Button btn_new;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_can;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_pag;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_pre;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_prod;
        private System.Windows.Forms.Button btn_res;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
    }
}