namespace Proyecto_final_venta
{
    partial class reportes
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
            this.dgv_resul = new System.Windows.Forms.DataGridView();
            this.re_comp = new System.Windows.Forms.Button();
            this.re_ven = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_resul)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_resul
            // 
            this.dgv_resul.AllowUserToAddRows = false;
            this.dgv_resul.AllowUserToDeleteRows = false;
            this.dgv_resul.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_resul.Location = new System.Drawing.Point(12, 25);
            this.dgv_resul.Name = "dgv_resul";
            this.dgv_resul.ReadOnly = true;
            this.dgv_resul.Size = new System.Drawing.Size(647, 305);
            this.dgv_resul.TabIndex = 0;
            // 
            // re_comp
            // 
            this.re_comp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.re_comp.ForeColor = System.Drawing.Color.Black;
            this.re_comp.Location = new System.Drawing.Point(68, 373);
            this.re_comp.Name = "re_comp";
            this.re_comp.Size = new System.Drawing.Size(191, 29);
            this.re_comp.TabIndex = 1;
            this.re_comp.Text = "Reporte Compra";
            this.re_comp.UseVisualStyleBackColor = true;
            this.re_comp.Click += new System.EventHandler(this.re_comp_Click);
            // 
            // re_ven
            // 
            this.re_ven.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.re_ven.ForeColor = System.Drawing.Color.Black;
            this.re_ven.Location = new System.Drawing.Point(362, 373);
            this.re_ven.Name = "re_ven";
            this.re_ven.Size = new System.Drawing.Size(191, 29);
            this.re_ven.TabIndex = 2;
            this.re_ven.Text = "Reporte Vencidos";
            this.re_ven.UseVisualStyleBackColor = true;
            this.re_ven.Click += new System.EventHandler(this.re_ven_Click);
            // 
            // reportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(692, 512);
            this.Controls.Add(this.re_ven);
            this.Controls.Add(this.re_comp);
            this.Controls.Add(this.dgv_resul);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "reportes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "reportes";
            this.Load += new System.EventHandler(this.reportes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_resul)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_resul;
        private System.Windows.Forms.Button re_comp;
        private System.Windows.Forms.Button re_ven;
    }
}