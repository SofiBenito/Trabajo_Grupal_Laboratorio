using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP_LAB_Part3.Presentacion.Frm_Reporte
{
    public partial class FrmMostrarConsulta5 : Form
    {
        private static FrmMostrarConsulta5 instancia;
        private FrmMostrarConsulta5()
        {
            InitializeComponent();
        }

        public static FrmMostrarConsulta5 obtenerInstancia()
        {
            if (instancia == null || instancia.IsDisposed)
            {
                instancia = new FrmMostrarConsulta5();
            }
            return instancia;
        }

        public int Anio;

        private void FrmMostrarConsulta5_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'automotriz3DataSet_Consulta5.SP_Consulta5' Puede moverla o quitarla según sea necesario.
            this.sP_Consulta5TableAdapter.Fill(this.automotriz3DataSet_Consulta5.SP_Consulta5, Anio);

            this.reportViewer1.RefreshReport();
        }
    }
}
