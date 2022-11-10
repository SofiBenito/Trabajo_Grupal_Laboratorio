using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TP_LAB_Part3.Presentacion.Frm_Reporte;
using TP_LAB_Part3.DataSet;

namespace TP_LAB_Part3
{
    public partial class FrmMostrarConsulta6 : Form
    {
        private static FrmMostrarConsulta6 instancia;
        public FrmMostrarConsulta6()
        {
            InitializeComponent();
        }

        #region Singleton
        public static FrmMostrarConsulta6 Obtener_Frm()
        {
            if (instancia == null || instancia.IsDisposed)
            {
                instancia = new FrmMostrarConsulta6();
            }

            return instancia;
        }
        #endregion

        public string Nombre;
        private void FrmMostrarConsulta6_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'automotriz3DataSet.consulta6' Puede moverla o quitarla según sea necesario.
            this.consulta6TableAdapter.Fill(this.automotriz3DataSet.consulta6, Nombre);
            // TODO: esta línea de código carga datos en la tabla 'automotriz3DataSet.consulta6' Puede moverla o quitarla según sea necesario.

            this.reportViewer1.RefreshReport();
        }
    }
}
