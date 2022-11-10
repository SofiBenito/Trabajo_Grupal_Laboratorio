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
    public partial class FrmMostrarConsulta6 : Form
    {
        public FrmMostrarConsulta6()
        {
            InitializeComponent();
        }

        public string Nombre;
        private void FrmMostrarConsulta6_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'automotriz3DataSet.consulta6' Puede moverla o quitarla según sea necesario.
            this.consulta6TableAdapter.Fill(this.automotriz3DataSet.consulta6, Nombre);

            this.reportViewer1.RefreshReport();
        }
    }
}
