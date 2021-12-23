namespace Proyecto_final_venta
{
    partial class devolucion
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
            this.txt_cod = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_des = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lbl = new System.Windows.Forms.Label();
            this.txt_pre = new System.Windows.Forms.TextBox();
            this.cb_name = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.cb_cant = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_cod
            // 
            this.txt_cod.BackColor = System.Drawing.Color.Silver;
            this.txt_cod.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_cod.Enabled = false;
            this.txt_cod.Location = new System.Drawing.Point(49, 133);
            this.txt_cod.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txt_cod.Name = "txt_cod";
            this.txt_cod.Size = new System.Drawing.Size(180, 18);
            this.txt_cod.TabIndex = 0;
            this.txt_cod.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_cod.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Silver;
            this.label1.Location = new System.Drawing.Point(49, 107);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Codigo de prodcuto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Silver;
            this.label2.Location = new System.Drawing.Point(45, 176);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cantidad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Silver;
            this.label3.Location = new System.Drawing.Point(46, 335);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(166, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Descripcion del daño";
            // 
            // txt_des
            // 
            this.txt_des.BackColor = System.Drawing.Color.Silver;
            this.txt_des.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_des.Location = new System.Drawing.Point(49, 361);
            this.txt_des.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txt_des.Name = "txt_des";
            this.txt_des.Size = new System.Drawing.Size(421, 18);
            this.txt_des.TabIndex = 5;
            this.txt_des.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(53)))), ((int)(((byte)(73)))));
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(159)))), ((int)(((byte)(127)))));
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(118)))), ((int)(((byte)(126)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.LightGray;
            this.button1.Location = new System.Drawing.Point(241, 435);
            this.button1.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(225, 54);
            this.button1.TabIndex = 6;
            this.button1.Text = "Devolver";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl.ForeColor = System.Drawing.Color.Silver;
            this.lbl.Location = new System.Drawing.Point(49, 255);
            this.lbl.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(56, 20);
            this.lbl.TabIndex = 9;
            this.lbl.Text = "Precio";
            // 
            // txt_pre
            // 
            this.txt_pre.BackColor = System.Drawing.Color.Silver;
            this.txt_pre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_pre.Location = new System.Drawing.Point(53, 281);
            this.txt_pre.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txt_pre.Name = "txt_pre";
            this.txt_pre.Size = new System.Drawing.Size(180, 18);
            this.txt_pre.TabIndex = 10;
            this.txt_pre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_pre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_pre_KeyPress);
            // 
            // cb_name
            // 
            this.cb_name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(53)))), ((int)(((byte)(73)))));
            this.cb_name.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_name.FormattingEnabled = true;
            this.cb_name.Location = new System.Drawing.Point(316, 127);
            this.cb_name.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.cb_name.Name = "cb_name";
            this.cb_name.Size = new System.Drawing.Size(365, 27);
            this.cb_name.TabIndex = 11;
            this.cb_name.SelectedIndexChanged += new System.EventHandler(this.cb_name_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Silver;
            this.label4.Location = new System.Drawing.Point(312, 101);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(171, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Seleccion el producto";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(182)))));
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(718, 44);
            this.panel1.TabIndex = 13;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.BackgroundImage = global::Proyecto_final_venta.Properties.Resources.close_azul___1511_;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(688, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(27, 30);
            this.button2.TabIndex = 14;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(296, 9);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 21);
            this.label5.TabIndex = 14;
            this.label5.Text = "DEVOLUCION";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cb_cant
            // 
            this.cb_cant.FormattingEnabled = true;
            this.cb_cant.Location = new System.Drawing.Point(47, 204);
            this.cb_cant.Name = "cb_cant";
            this.cb_cant.Size = new System.Drawing.Size(192, 27);
            this.cb_cant.TabIndex = 14;
            // 
            // devolucion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(57)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(718, 570);
            this.Controls.Add(this.cb_cant);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cb_name);
            this.Controls.Add(this.txt_pre);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txt_des);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_cod);
            this.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Silver;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "devolucion";
            this.Opacity = 0.9D;
            this.Text = "devolucion";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_cod;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_des;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.TextBox txt_pre;
        private System.Windows.Forms.ComboBox cb_name;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox cb_cant;
    }
}