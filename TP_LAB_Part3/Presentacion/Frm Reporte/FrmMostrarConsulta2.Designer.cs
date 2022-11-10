using TP_LAB_Part3.DataSet;

namespace TP_LAB_Part3.Presentacion.Frm_Reporte
{
    partial class FrmMostrarConsulta2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMostrarConsulta2));
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.automotriz3DataSet_Consulta2 = new TP_LAB_Part3.DataSet.Automotriz3DataSet_Consulta2();
            this.sPConsulta2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sP_Consulta2TableAdapter = new TP_LAB_Part3.DataSet.Automotriz3DataSet_Consulta2TableAdapters.SP_Consulta2TableAdapter();
            this.SP_Consulta2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.automotriz3DataSet_Consulta2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPConsulta2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SP_Consulta2BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.SP_Consulta2BindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "TP_LAB_Part3.Reportes.RptConsulta2.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(574, 402);
            this.reportViewer1.TabIndex = 0;
            // 
            // automotriz3DataSet_Consulta2
            // 
            this.automotriz3DataSet_Consulta2.DataSetName = "Automotriz3DataSet_Consulta2";
            this.automotriz3DataSet_Consulta2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sPConsulta2BindingSource
            // 
            this.sPConsulta2BindingSource.DataMember = "SP_Consulta2";
            this.sPConsulta2BindingSource.DataSource = this.automotriz3DataSet_Consulta2;
            // 
            // sP_Consulta2TableAdapter
            // 
            this.sP_Consulta2TableAdapter.ClearBeforeFill = true;
            // 
            // SP_Consulta2BindingSource
            // 
            this.SP_Consulta2BindingSource.DataMember = "SP_Consulta2";
            this.SP_Consulta2BindingSource.DataSource = this.automotriz3DataSet_Consulta2;
            // 
            // FrmMostrarConsulta2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 402);
            this.Controls.Add(this.reportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmMostrarConsulta2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Platinum";
            this.Load += new System.EventHandler(this.Platinum_Load);
            ((System.ComponentModel.ISupportInitialize)(this.automotriz3DataSet_Consulta2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPConsulta2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SP_Consulta2BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource SP_Consulta2BindingSource;
        private Automotriz3DataSet_Consulta2 automotriz3DataSet_Consulta2;
        private System.Windows.Forms.BindingSource sPConsulta2BindingSource;
        private DataSet.Automotriz3DataSet_Consulta2TableAdapters.SP_Consulta2TableAdapter sP_Consulta2TableAdapter;
    }
}