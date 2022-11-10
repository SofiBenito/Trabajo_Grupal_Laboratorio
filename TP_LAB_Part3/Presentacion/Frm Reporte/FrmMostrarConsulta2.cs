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
    public partial class FrmMostrarConsulta2 : Form
    {
        private static FrmMostrarConsulta2 instancia;
        private FrmMostrarConsulta2()
        {
            InitializeComponent();
        }

        public int Anio;

        public static FrmMostrarConsulta2 obtenerInstancia()
        {
            if (instancia == null || instancia.IsDisposed)
            {
                instancia = new FrmMostrarConsulta2();
            }
            return instancia;
        }

        private void Platinum_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'automotriz3DataSet_Consulta2.SP_Consulta2' Puede moverla o quitarla según sea necesario.
            this.sP_Consulta2TableAdapter.Fill(this.automotriz3DataSet_Consulta2.SP_Consulta2, Anio);

            this.reportViewer1.RefreshReport();
        }
    }
}
