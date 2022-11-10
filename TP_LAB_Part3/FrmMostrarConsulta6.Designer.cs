namespace TP_LAB_Part3
{
    partial class FrmMostrarConsulta6
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
            this.automotriz3DataSet = new TP_LAB_Part3.Automotriz3DataSet();
            this.consulta6BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.consulta6TableAdapter = new TP_LAB_Part3.Automotriz3DataSetTableAdapters.consulta6TableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.automotriz3DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.consulta6BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.consulta6BindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "TP_LAB_Part3.Report2.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // automotriz3DataSet
            // 
            this.automotriz3DataSet.DataSetName = "Automotriz3DataSet";
            this.automotriz3DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // consulta6BindingSource
            // 
            this.consulta6BindingSource.DataMember = "consulta6";
            this.consulta6BindingSource.DataSource = this.automotriz3DataSet;
            // 
            // consulta6TableAdapter
            // 
            this.consulta6TableAdapter.ClearBeforeFill = true;
            // 
            // FrmMostrarConsulta6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FrmMostrarConsulta6";
            this.Text = "FrmMostrarConsulta6";
            this.Load += new System.EventHandler(this.FrmMostrarConsulta6_Load);
            ((System.ComponentModel.ISupportInitialize)(this.automotriz3DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.consulta6BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource consulta6BindingSource;
        private Automotriz3DataSet automotriz3DataSet;
        private Automotriz3DataSetTableAdapters.consulta6TableAdapter consulta6TableAdapter;
    }
}