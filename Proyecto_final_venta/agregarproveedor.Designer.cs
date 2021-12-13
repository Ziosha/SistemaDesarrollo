namespace Proyecto_final_venta
{
    partial class agregarproveedor
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
            this.txt_codProv = new System.Windows.Forms.TextBox();
            this.txt_nom = new System.Windows.Forms.TextBox();
            this.txt_direc = new System.Windows.Forms.TextBox();
            this.txt_tel = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_codProv
            // 
            this.txt_codProv.Location = new System.Drawing.Point(62, 46);
            this.txt_codProv.Name = "txt_codProv";
            this.txt_codProv.Size = new System.Drawing.Size(100, 20);
            this.txt_codProv.TabIndex = 0;
            this.txt_codProv.Text = "Codigo Proveedor";
            // 
            // txt_nom
            // 
            this.txt_nom.Location = new System.Drawing.Point(62, 84);
            this.txt_nom.Name = "txt_nom";
            this.txt_nom.Size = new System.Drawing.Size(100, 20);
            this.txt_nom.TabIndex = 1;
            this.txt_nom.Text = "Nombre";
            // 
            // txt_direc
            // 
            this.txt_direc.Location = new System.Drawing.Point(62, 128);
            this.txt_direc.Name = "txt_direc";
            this.txt_direc.Size = new System.Drawing.Size(100, 20);
            this.txt_direc.TabIndex = 2;
            this.txt_direc.Text = "Direccion";
            // 
            // txt_tel
            // 
            this.txt_tel.Location = new System.Drawing.Point(62, 167);
            this.txt_tel.Name = "txt_tel";
            this.txt_tel.Size = new System.Drawing.Size(100, 20);
            this.txt_tel.TabIndex = 3;
            this.txt_tel.Text = "Telefono";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(74, 236);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Agregar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // agregarproveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(203, 294);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txt_tel);
            this.Controls.Add(this.txt_direc);
            this.Controls.Add(this.txt_nom);
            this.Controls.Add(this.txt_codProv);
            this.Name = "agregarproveedor";
            this.Text = "agregarproveedor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_codProv;
        private System.Windows.Forms.TextBox txt_nom;
        private System.Windows.Forms.TextBox txt_direc;
        private System.Windows.Forms.TextBox txt_tel;
        private System.Windows.Forms.Button button1;
    }
}