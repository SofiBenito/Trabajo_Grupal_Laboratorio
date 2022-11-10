namespace TP_LAB_Part3.Presentacion.Frm_Reporte
{
    partial class FrmMostrarConsulta10
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMostrarConsulta10));
            this.SP_Consulta10BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.automotriz3DataSet_Consulta10 = new TP_LAB_Part3.DataSet.Automotriz3DataSet_Consulta10();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.automotriz3DataSetConsulta10BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.automotriz3DataSetConsulta10BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.sPConsulta10BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sP_Consulta10TableAdapter = new TP_LAB_Part3.DataSet.Automotriz3DataSet_Consulta10TableAdapters.SP_Consulta10TableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.SP_Consulta10BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.automotriz3DataSet_Consulta10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.automotriz3DataSetConsulta10BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.automotriz3DataSetConsulta10BindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPConsulta10BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // SP_Consulta10BindingSource
            // 
            this.SP_Consulta10BindingSource.DataMember = "SP_Consulta10";
            this.SP_Consulta10BindingSource.DataSource = this.automotriz3DataSet_Consulta10;
            // 
            // automotriz3DataSet_Consulta10
            // 
            this.automotriz3DataSet_Consulta10.DataSetName = "Automotriz3DataSet_Consulta10";
            this.automotriz3DataSet_Consulta10.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.SP_Consulta10BindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "TP_LAB_Part3.Reportes.Report3.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(698, 546);
            this.reportViewer1.TabIndex = 0;
            // 
            // automotriz3DataSetConsulta10BindingSource
            // 
            this.automotriz3DataSetConsulta10BindingSource.DataSource = this.automotriz3DataSet_Consulta10;
            this.automotriz3DataSetConsulta10BindingSource.Position = 0;
            // 
            // automotriz3DataSetConsulta10BindingSource1
            // 
            this.automotriz3DataSetConsulta10BindingSource1.DataSource = this.automotriz3DataSet_Consulta10;
            this.automotriz3DataSetConsulta10BindingSource1.Position = 0;
            // 
            // sPConsulta10BindingSource
            // 
            this.sPConsulta10BindingSource.DataMember = "SP_Consulta10";
            this.sPConsulta10BindingSource.DataSource = this.automotriz3DataSet_Consulta10;
            // 
            // sP_Consulta10TableAdapter
            // 
            this.sP_Consulta10TableAdapter.ClearBeforeFill = true;
            // 
            // FrmMostrarConsulta10
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 546);
            this.Controls.Add(this.reportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmMostrarConsulta10";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Platinum";
            this.Load += new System.EventHandler(this.FrmMostrarConsulta10_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SP_Consulta10BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.automotriz3DataSet_Consulta10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.automotriz3DataSetConsulta10BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.automotriz3DataSetConsulta10BindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPConsulta10BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource automotriz3DataSetConsulta10BindingSource;
        private DataSet.Automotriz3DataSet_Consulta10 automotriz3DataSet_Consulta10;
        private System.Windows.Forms.BindingSource SP_Consulta10BindingSource;
        private System.Windows.Forms.BindingSource automotriz3DataSetConsulta10BindingSource1;
        private System.Windows.Forms.BindingSource sPConsulta10BindingSource;
        private DataSet.Automotriz3DataSet_Consulta10TableAdapters.SP_Consulta10TableAdapter sP_Consulta10TableAdapter;
    }
}