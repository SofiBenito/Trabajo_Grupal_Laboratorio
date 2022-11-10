namespace TP_LAB_Part3.Presentacion.Frm_Reporte
{
    partial class FrmMostrarConsulta5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMostrarConsulta5));
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SP_Consulta5BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.automotriz3DataSet_Consulta5 = new TP_LAB_Part3.DataSet.Automotriz3DataSet_Consulta5();
            this.sPConsulta5BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sP_Consulta5TableAdapter = new TP_LAB_Part3.DataSet.Automotriz3DataSet_Consulta5TableAdapters.SP_Consulta5TableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.SP_Consulta5BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.automotriz3DataSet_Consulta5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPConsulta5BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.SP_Consulta5BindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "TP_LAB_Part3.Reportes.Rpt_Consulta5.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(489, 702);
            this.reportViewer1.TabIndex = 0;
            // 
            // SP_Consulta5BindingSource
            // 
            this.SP_Consulta5BindingSource.DataMember = "SP_Consulta5";
            this.SP_Consulta5BindingSource.DataSource = this.automotriz3DataSet_Consulta5;
            // 
            // automotriz3DataSet_Consulta5
            // 
            this.automotriz3DataSet_Consulta5.DataSetName = "Automotriz3DataSet_Consulta5";
            this.automotriz3DataSet_Consulta5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sPConsulta5BindingSource
            // 
            this.sPConsulta5BindingSource.DataMember = "SP_Consulta5";
            this.sPConsulta5BindingSource.DataSource = this.automotriz3DataSet_Consulta5;
            // 
            // sP_Consulta5TableAdapter
            // 
            this.sP_Consulta5TableAdapter.ClearBeforeFill = true;
            // 
            // FrmMostrarConsulta5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkRed;
            this.ClientSize = new System.Drawing.Size(489, 702);
            this.Controls.Add(this.reportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmMostrarConsulta5";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Platinum";
            this.Load += new System.EventHandler(this.FrmMostrarConsulta5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SP_Consulta5BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.automotriz3DataSet_Consulta5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPConsulta5BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource SP_Consulta5BindingSource;
        private DataSet.Automotriz3DataSet_Consulta5 automotriz3DataSet_Consulta5;
        private System.Windows.Forms.BindingSource sPConsulta5BindingSource;
        private DataSet.Automotriz3DataSet_Consulta5TableAdapters.SP_Consulta5TableAdapter sP_Consulta5TableAdapter;
    }
}