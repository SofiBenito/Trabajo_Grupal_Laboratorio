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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMostrarConsulta6));
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.consulta6BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.automotriz3DataSet = new TP_LAB_Part3.DataSet.Automotriz3DataSet();
            this.consulta6TableAdapter = new TP_LAB_Part3.DataSet.Automotriz3DataSetTableAdapters.consulta6TableAdapter();
            this.automotriz3DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.consulta6BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.automotriz3DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.automotriz3DataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.consulta6BindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "TP_LAB_Part3.Reportes.Report2.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(720, 664);
            this.reportViewer1.TabIndex = 0;
            // 
            // consulta6BindingSource
            // 
            this.consulta6BindingSource.DataMember = "consulta6";
            this.consulta6BindingSource.DataSource = this.automotriz3DataSet;
            // 
            // automotriz3DataSet
            // 
            this.automotriz3DataSet.DataSetName = "Automotriz3DataSet";
            this.automotriz3DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // consulta6TableAdapter
            // 
            this.consulta6TableAdapter.ClearBeforeFill = true;
            // 
            // automotriz3DataSetBindingSource
            // 
            this.automotriz3DataSetBindingSource.DataSource = this.automotriz3DataSet;
            this.automotriz3DataSetBindingSource.Position = 0;
            // 
            // FrmMostrarConsulta6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 664);
            this.Controls.Add(this.reportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmMostrarConsulta6";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Platinum";
            this.Load += new System.EventHandler(this.FrmMostrarConsulta6_Load);
            ((System.ComponentModel.ISupportInitialize)(this.consulta6BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.automotriz3DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.automotriz3DataSetBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource consulta6BindingSource;
        private DataSet.Automotriz3DataSet automotriz3DataSet;
        private DataSet.Automotriz3DataSetTableAdapters.consulta6TableAdapter consulta6TableAdapter;
        private System.Windows.Forms.BindingSource automotriz3DataSetBindingSource;
    }
}