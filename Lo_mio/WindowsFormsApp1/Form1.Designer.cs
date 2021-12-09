
namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.consulta = new System.Windows.Forms.TextBox();
            this.actuali = new System.Windows.Forms.Button();
            this.elimi = new System.Windows.Forms.Button();
            this.dirP = new System.Windows.Forms.TextBox();
            this.nomP = new System.Windows.Forms.TextBox();
            this.codP = new System.Windows.Forms.TextBox();
            this.actualiza = new System.Windows.Forms.TextBox();
            this.elimina = new System.Windows.Forms.TextBox();
            this.telP = new System.Windows.Forms.TextBox();
            this.consula = new System.Windows.Forms.Button();
            this.agrega = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(198, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(473, 207);
            this.dataGridView1.TabIndex = 0;
            // 
            // consulta
            // 
            this.consulta.Location = new System.Drawing.Point(119, 236);
            this.consulta.Name = "consulta";
            this.consulta.Size = new System.Drawing.Size(100, 20);
            this.consulta.TabIndex = 2;
            // 
            // actuali
            // 
            this.actuali.Location = new System.Drawing.Point(31, 291);
            this.actuali.Name = "actuali";
            this.actuali.Size = new System.Drawing.Size(82, 23);
            this.actuali.TabIndex = 4;
            this.actuali.Text = "ACTUALIZAR";
            this.actuali.UseVisualStyleBackColor = true;
            this.actuali.Click += new System.EventHandler(this.actuali_Click);
            // 
            // elimi
            // 
            this.elimi.Location = new System.Drawing.Point(31, 262);
            this.elimi.Name = "elimi";
            this.elimi.Size = new System.Drawing.Size(82, 23);
            this.elimi.TabIndex = 5;
            this.elimi.Text = "ELIMINAR";
            this.elimi.UseVisualStyleBackColor = true;
            this.elimi.Click += new System.EventHandler(this.elimi_Click);
            // 
            // dirP
            // 
            this.dirP.Location = new System.Drawing.Point(331, 329);
            this.dirP.Name = "dirP";
            this.dirP.Size = new System.Drawing.Size(100, 20);
            this.dirP.TabIndex = 6;
            // 
            // nomP
            // 
            this.nomP.Location = new System.Drawing.Point(225, 329);
            this.nomP.Name = "nomP";
            this.nomP.Size = new System.Drawing.Size(100, 20);
            this.nomP.TabIndex = 7;
            // 
            // codP
            // 
            this.codP.Location = new System.Drawing.Point(119, 329);
            this.codP.Name = "codP";
            this.codP.Size = new System.Drawing.Size(100, 20);
            this.codP.TabIndex = 8;
            // 
            // actualiza
            // 
            this.actualiza.Location = new System.Drawing.Point(119, 291);
            this.actualiza.Name = "actualiza";
            this.actualiza.Size = new System.Drawing.Size(100, 20);
            this.actualiza.TabIndex = 9;
            // 
            // elimina
            // 
            this.elimina.Location = new System.Drawing.Point(119, 265);
            this.elimina.Name = "elimina";
            this.elimina.Size = new System.Drawing.Size(100, 20);
            this.elimina.TabIndex = 10;
            // 
            // telP
            // 
            this.telP.Location = new System.Drawing.Point(437, 329);
            this.telP.Name = "telP";
            this.telP.Size = new System.Drawing.Size(100, 20);
            this.telP.TabIndex = 12;
            // 
            // consula
            // 
            this.consula.Location = new System.Drawing.Point(31, 236);
            this.consula.Name = "consula";
            this.consula.Size = new System.Drawing.Size(82, 23);
            this.consula.TabIndex = 13;
            this.consula.Text = "CONSULTAR";
            this.consula.UseVisualStyleBackColor = true;
            this.consula.Click += new System.EventHandler(this.consula_Click);
            // 
            // agrega
            // 
            this.agrega.Location = new System.Drawing.Point(31, 329);
            this.agrega.Name = "agrega";
            this.agrega.Size = new System.Drawing.Size(82, 23);
            this.agrega.TabIndex = 14;
            this.agrega.Text = "AGREGAR";
            this.agrega.UseVisualStyleBackColor = true;
            this.agrega.Click += new System.EventHandler(this.agrega_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(31, 37);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 34);
            this.button1.TabIndex = 15;
            this.button1.Text = "CONECTAR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 362);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.agrega);
            this.Controls.Add(this.consula);
            this.Controls.Add(this.telP);
            this.Controls.Add(this.elimina);
            this.Controls.Add(this.actualiza);
            this.Controls.Add(this.codP);
            this.Controls.Add(this.nomP);
            this.Controls.Add(this.dirP);
            this.Controls.Add(this.elimi);
            this.Controls.Add(this.actuali);
            this.Controls.Add(this.consulta);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = " ";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox consulta;
        private System.Windows.Forms.Button actuali;
        private System.Windows.Forms.Button elimi;
        private System.Windows.Forms.TextBox dirP;
        private System.Windows.Forms.TextBox nomP;
        private System.Windows.Forms.TextBox codP;
        private System.Windows.Forms.TextBox actualiza;
        private System.Windows.Forms.TextBox elimina;
        private System.Windows.Forms.TextBox telP;
        private System.Windows.Forms.Button consula;
        private System.Windows.Forms.Button agrega;
        private System.Windows.Forms.Button button1;
    }
}

