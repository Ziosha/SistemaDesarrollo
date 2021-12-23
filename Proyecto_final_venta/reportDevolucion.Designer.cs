namespace Proyecto_final_venta
{
    partial class reportDevolucion
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
            this.dvg_re = new System.Windows.Forms.DataGridView();
            this.btn_repot = new System.Windows.Forms.Button();
            this.btn_dev = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dvg_re)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dvg_re
            // 
            this.dvg_re.BackgroundColor = System.Drawing.SystemColors.InactiveCaption;
            this.dvg_re.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvg_re.Location = new System.Drawing.Point(45, 89);
            this.dvg_re.Name = "dvg_re";
            this.dvg_re.RowHeadersWidth = 51;
            this.dvg_re.Size = new System.Drawing.Size(626, 253);
            this.dvg_re.TabIndex = 0;
            // 
            // btn_repot
            // 
            this.btn_repot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(53)))), ((int)(((byte)(73)))));
            this.btn_repot.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(159)))), ((int)(((byte)(127)))));
            this.btn_repot.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.btn_repot.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(118)))), ((int)(((byte)(126)))));
            this.btn_repot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_repot.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_repot.ForeColor = System.Drawing.Color.LightGray;
            this.btn_repot.Location = new System.Drawing.Point(45, 387);
            this.btn_repot.Name = "btn_repot";
            this.btn_repot.Size = new System.Drawing.Size(194, 35);
            this.btn_repot.TabIndex = 1;
            this.btn_repot.Text = "Reporte";
            this.btn_repot.UseVisualStyleBackColor = false;
            this.btn_repot.Click += new System.EventHandler(this.btn_repot_Click);
            // 
            // btn_dev
            // 
            this.btn_dev.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(53)))), ((int)(((byte)(73)))));
            this.btn_dev.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(159)))), ((int)(((byte)(127)))));
            this.btn_dev.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.btn_dev.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(118)))), ((int)(((byte)(126)))));
            this.btn_dev.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_dev.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_dev.ForeColor = System.Drawing.Color.LightGray;
            this.btn_dev.Location = new System.Drawing.Point(45, 458);
            this.btn_dev.Name = "btn_dev";
            this.btn_dev.Size = new System.Drawing.Size(194, 35);
            this.btn_dev.TabIndex = 2;
            this.btn_dev.Text = "Devolver";
            this.btn_dev.UseVisualStyleBackColor = false;
            this.btn_dev.Click += new System.EventHandler(this.btn_dev_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(182)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(718, 36);
            this.panel1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(249, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "REPORTE-DEVOLUCION";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // reportDevolucion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(57)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(718, 570);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_dev);
            this.Controls.Add(this.btn_repot);
            this.Controls.Add(this.dvg_re);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "reportDevolucion";
            this.Opacity = 0.9D;
            this.Text = "reportDevolucion";
            ((System.ComponentModel.ISupportInitialize)(this.dvg_re)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dvg_re;
        private System.Windows.Forms.Button btn_repot;
        private System.Windows.Forms.Button btn_dev;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
    }
}