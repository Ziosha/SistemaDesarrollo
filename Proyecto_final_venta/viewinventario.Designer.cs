
namespace Proyecto_final_venta
{
    partial class viewinventario
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.reportemerca = new Proyecto_final_venta.reportemerca();
            this.ProductoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ProductoTableAdapter = new Proyecto_final_venta.reportemercaTableAdapters.ProductoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.reportemerca)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.ProductoBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Proyecto_final_venta.reportinventario.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // reportemerca
            // 
            this.reportemerca.DataSetName = "reportemerca";
            this.reportemerca.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ProductoBindingSource
            // 
            this.ProductoBindingSource.DataMember = "Producto";
            this.ProductoBindingSource.DataSource = this.reportemerca;
            // 
            // ProductoTableAdapter
            // 
            this.ProductoTableAdapter.ClearBeforeFill = true;
            // 
            // viewinventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "viewinventario";
            this.Text = "viewinventario";
            this.Load += new System.EventHandler(this.viewinventario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.reportemerca)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource ProductoBindingSource;
        private reportemerca reportemerca;
        private reportemercaTableAdapters.ProductoTableAdapter ProductoTableAdapter;
    }
}