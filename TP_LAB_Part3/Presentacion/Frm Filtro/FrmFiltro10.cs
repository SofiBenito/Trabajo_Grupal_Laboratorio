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

namespace TP_LAB_Part3.Presentacion
{
    public partial class FrmFiltro10 : Form
    {

        private static FrmFiltro10 instancia = null;

        public static FrmFiltro10 obtenerInstancia()
        {
            if (instancia == null || instancia.IsDisposed)
            {
                instancia = new FrmFiltro10();
            }
            return instancia;
        }

        public FrmFiltro10()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtBuscar.Text != "")
            {
                FrmMostrarConsulta10 fmc10 = FrmMostrarConsulta10.Obtener_Frm();
                fmc10.Buscar = txtBuscar.Text;
                this.Dispose();
                fmc10.ShowDialog();
            }
            else
            {
                MessageBox.Show("Ingrese una letra o palabra por la cual se puedan filtrar los productos");
            }

            txtBuscar.Focus();
        }

    }
}
