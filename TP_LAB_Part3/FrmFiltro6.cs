using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP_LAB_Part3
{
    public partial class FrmFiltro6 : Form
    {
        private static FrmFiltro6 instancia = null;

        public static FrmFiltro6 obtenerInstancia()
        {
            if (instancia == null)
            {
                instancia = new FrmFiltro6();
            }
            return instancia;
        }

        public FrmFiltro6()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmMostrarConsulta6 fmc6 = new FrmMostrarConsulta6();
            fmc6.Nombre = txtNombre.Text;
            fmc6.ShowDialog();
        }
    }
}
