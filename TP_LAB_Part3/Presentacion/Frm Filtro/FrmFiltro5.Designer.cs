namespace TP_LAB_Part3.Presentacion.Frm_Filtro
{
    partial class FrmFiltro5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmFiltro5));
            this.label1 = new System.Windows.Forms.Label();
            this.txt_anio = new System.Windows.Forms.TextBox();
            this.btn_Buscar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(386, 40);
            this.label1.TabIndex = 5;
            this.label1.Text = "Ingrese el año por el cual\r\nse comenzara a filtrar las ventas de autopartes\r\n";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_anio
            // 
            this.txt_anio.Location = new System.Drawing.Point(12, 52);
            this.txt_anio.Name = "txt_anio";
            this.txt_anio.Size = new System.Drawing.Size(382, 20);
            this.txt_anio.TabIndex = 4;
            // 
            // btn_Buscar
            // 
            this.btn_Buscar.FlatAppearance.BorderSize = 0;
            this.btn_Buscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Buscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Buscar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Buscar.Image = ((System.Drawing.Image)(resources.GetObject("btn_Buscar.Image")));
            this.btn_Buscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Buscar.Location = new System.Drawing.Point(127, 78);
            this.btn_Buscar.Name = "btn_Buscar";
            this.btn_Buscar.Size = new System.Drawing.Size(131, 62);
            this.btn_Buscar.TabIndex = 3;
            this.btn_Buscar.Text = "Buscar";
            this.btn_Buscar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Buscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Buscar.UseVisualStyleBackColor = true;
            this.btn_Buscar.Click += new System.EventHandler(this.btn_Buscar_Click);
            // 
            // FrmFiltro5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkRed;
            this.ClientSize = new System.Drawing.Size(406, 141);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_anio);
            this.Controls.Add(this.btn_Buscar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(422, 180);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(422, 180);
            this.Name = "FrmFiltro5";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Platinum";
            this.Load += new System.EventHandler(this.FrmFiltro5_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_anio;
        private System.Windows.Forms.Button btn_Buscar;
    }
}