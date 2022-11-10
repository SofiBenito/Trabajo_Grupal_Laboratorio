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

namespace TP_LAB_Part3.Presentacion.Frm_Filtro
{
    public partial class FrmFiltro2 : Form
    {
        private static FrmFiltro2 instancia;
        private FrmFiltro2()
        {
            InitializeComponent();
        }
        public static FrmFiltro2 obtenerInstancia()
        {
            if (instancia == null || instancia.IsDisposed)
            {
                instancia = new FrmFiltro2();
            }
            return instancia;
        }

        private void btn_Buscar_Click(object sender, EventArgs e)
        {
            if (txt_anio.Text != "")
            {
                if (int.Parse(txt_anio.Text) <= DateTime.UtcNow.Year)
                {
                    FrmMostrarConsulta2 oFrmConsulta2 = FrmMostrarConsulta2.obtenerInstancia();
                    oFrmConsulta2.Anio = int.Parse(txt_anio.Text);
                    this.Dispose();
                    oFrmConsulta2.Show();
                }
                else
                {
                    MessageBox.Show("Debe ingresar un año no mayor al actual");
                }
            }
            else
            {
                MessageBox.Show("Debe ingresar un año valido");
            }

            txt_anio.Focus();
        }

        private void txt_anio_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
