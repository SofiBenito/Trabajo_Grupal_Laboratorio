using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TP_LAB_Part3.Negocio;

namespace TP_LAB_Part3.Presentacion.Consutas_DGV
{
    public partial class Frm_MostrarConsulta4 : Form
    {
        private Helper oHelper = Helper.ObtenerInstancia();
        private static Frm_MostrarConsulta4 instancia;
        private Frm_MostrarConsulta4()
        {
            InitializeComponent();
        }

        public static Frm_MostrarConsulta4 ObtenerInstancia()
        {
            if(instancia == null || instancia.IsDisposed)
            {
                instancia = new Frm_MostrarConsulta4();
            }

            return instancia;
        }

        private void CargarDGV()
        {
            DataTable tabla = new DataTable();

            tabla = oHelper.Consulta1("SP_Consulta4");

            dgv_out.DataSource = tabla;
        }

        private void Frm_MostrarConsulta4_Load(object sender, EventArgs e)
        {
            CargarDGV();
        }

        #region Boton-Cerrar
        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Desea cerrar la ventana?", "Cerrar", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);


            if (result == DialogResult.Yes)
            {
                Dispose();
            }

            //Form
            btn_cerrar.Focus();
        }
        #endregion
    }
}
