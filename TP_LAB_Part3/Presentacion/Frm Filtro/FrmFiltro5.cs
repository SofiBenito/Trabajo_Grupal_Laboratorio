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
    public partial class FrmFiltro5 : Form
    {
        private static FrmFiltro5 instancia;
        private FrmFiltro5()
        {
            InitializeComponent();
        }

        public static FrmFiltro5 obtenerInstancia()
        {
            if (instancia == null || instancia.IsDisposed)
            {
                instancia = new FrmFiltro5();
            }
            return instancia;
        }

        private void FrmFiltro5_Load(object sender, EventArgs e)
        {

        }

        private void btn_Buscar_Click(object sender, EventArgs e)
        {
            if (txt_anio.Text != "")
            {
                if (int.Parse(txt_anio.Text) <= DateTime.UtcNow.Year)
                {
                    FrmMostrarConsulta5 oFrmConsulta5 = FrmMostrarConsulta5.obtenerInstancia();
                    oFrmConsulta5.Anio = int.Parse(txt_anio.Text);
                    this.Dispose();
                    oFrmConsulta5.Show();
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
    }
}
