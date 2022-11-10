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
    public partial class FrmMostrarConsulta10 : Form
    {
        private static FrmMostrarConsulta10 instancia;

        private FrmMostrarConsulta10()
        {
            InitializeComponent();
        }
        public static FrmMostrarConsulta10 Obtener_Frm()
        {
            if (instancia == null || instancia.IsDisposed)
            {
                instancia = new FrmMostrarConsulta10();
            }

            return instancia;
        }

        public string Buscar;

        private void FrmMostrarConsulta10_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'automotriz3DataSet_Consulta10.SP_Consulta10' Puede moverla o quitarla según sea necesario.
            this.sP_Consulta10TableAdapter.Fill(this.automotriz3DataSet_Consulta10.SP_Consulta10, Buscar);

            this.reportViewer1.RefreshReport();
        }
    }
}
