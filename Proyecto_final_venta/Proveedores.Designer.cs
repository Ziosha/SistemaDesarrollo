namespace Proyecto_final_venta
{
    partial class Proveedores
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
            this.dgresul1 = new System.Windows.Forms.DataGridView();
            this.btn_cons = new System.Windows.Forms.Button();
            this.btn_eli = new System.Windows.Forms.Button();
            this.btn_agre = new System.Windows.Forms.Button();
            this.btn_act = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgresul1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgresul1
            // 
            this.dgresul1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgresul1.Location = new System.Drawing.Point(17, 12);
            this.dgresul1.Name = "dgresul1";
            this.dgresul1.Size = new System.Drawing.Size(433, 295);
            this.dgresul1.TabIndex = 0;
            // 
            // btn_cons
            // 
            this.btn_cons.FlatAppearance.BorderSize = 0;
            this.btn_cons.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_cons.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cons.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cons.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_cons.Location = new System.Drawing.Point(17, 366);
            this.btn_cons.Name = "btn_cons";
            this.btn_cons.Size = new System.Drawing.Size(211, 33);
            this.btn_cons.TabIndex = 1;
            this.btn_cons.Text = "Consultar";
            this.btn_cons.UseVisualStyleBackColor = true;
            this.btn_cons.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_eli
            // 
            this.btn_eli.FlatAppearance.BorderSize = 0;
            this.btn_eli.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_eli.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_eli.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_eli.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_eli.Location = new System.Drawing.Point(239, 327);
            this.btn_eli.Name = "btn_eli";
            this.btn_eli.Size = new System.Drawing.Size(211, 33);
            this.btn_eli.TabIndex = 2;
            this.btn_eli.Text = "Eliminar";
            this.btn_eli.UseVisualStyleBackColor = true;
            this.btn_eli.Click += new System.EventHandler(this.btn_eli_Click);
            // 
            // btn_agre
            // 
            this.btn_agre.FlatAppearance.BorderSize = 0;
            this.btn_agre.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_agre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_agre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_agre.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_agre.Location = new System.Drawing.Point(239, 366);
            this.btn_agre.Name = "btn_agre";
            this.btn_agre.Size = new System.Drawing.Size(211, 33);
            this.btn_agre.TabIndex = 3;
            this.btn_agre.Text = "Agregar";
            this.btn_agre.UseVisualStyleBackColor = true;
            this.btn_agre.Click += new System.EventHandler(this.btn_agre_Click);
            // 
            // btn_act
            // 
            this.btn_act.FlatAppearance.BorderSize = 0;
            this.btn_act.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_act.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_act.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_act.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_act.Location = new System.Drawing.Point(17, 327);
            this.btn_act.Name = "btn_act";
            this.btn_act.Size = new System.Drawing.Size(211, 33);
            this.btn_act.TabIndex = 4;
            this.btn_act.Text = "Actualizar";
            this.btn_act.UseVisualStyleBackColor = true;
            // 
            // Proveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Firebrick;
            this.ClientSize = new System.Drawing.Size(498, 461);
            this.Controls.Add(this.btn_act);
            this.Controls.Add(this.btn_agre);
            this.Controls.Add(this.btn_eli);
            this.Controls.Add(this.btn_cons);
            this.Controls.Add(this.dgresul1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Proveedores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "usuarios";
            this.Load += new System.EventHandler(this.usuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgresul1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgresul1;
        private System.Windows.Forms.Button btn_cons;
        private System.Windows.Forms.Button btn_eli;
        private System.Windows.Forms.Button btn_agre;
        private System.Windows.Forms.Button btn_act;
    }
}