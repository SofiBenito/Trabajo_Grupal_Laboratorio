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

namespace TP_LAB_Part3.Presentacion
{
    public partial class Frm_Vehiculos : Form
    {
        private static Frm_Vehiculos instancia; //FORM CON SINGLETON
        private Helper oHelper = Helper.ObtenerInstancia();
        private Frm_Vehiculos()
        {
            InitializeComponent();
        }

        #region Singleton
        public static Frm_Vehiculos Obtener_Frm()
        {
            if (instancia == null || instancia.IsDisposed)
            {
                instancia = new Frm_Vehiculos();
            }

            return instancia;
        }
        #endregion

        #region Metodos
        public void CargarDGV(string sp)
        {
            DataTable tabla = new DataTable();
            tabla = oHelper.All_Productos(sp);

            dgv_out.DataSource = tabla;
        }
        #endregion

        #region LOAD-Frm_Vehiculos
        private void Frm_Vehiculos_Load(object sender, EventArgs e)
        {
            CargarDGV("SP_All_Vehiculos");
        }
        #endregion

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
