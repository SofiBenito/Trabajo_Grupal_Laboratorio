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
    public partial class FrmMostratConsulta3 : Form
    {
        private Helper oHelper = Helper.ObtenerInstancia();
        private static FrmMostratConsulta3 instancia;
        private FrmMostratConsulta3()
        {
            InitializeComponent();
        }

        public static FrmMostratConsulta3 ObtenerInstancia()
        {
            if(instancia == null)
            {
                instancia = new FrmMostratConsulta3();
            }

            return instancia;
        }

        private void Prueba_Load(object sender, EventArgs e)
        {

        }

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

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            int meses = int.Parse(txt_meses.Text)-1;

            if (txt_descripcion.Text != "")
            {
                if(int.Parse(txt_monto.Text) > 0)
                {
                    if(meses >= 0)
                    {
                        dgv_out.DataSource = null;
                        dgv_out.DataSource = oHelper.Consulta3("SP_Consulta3", txt_descripcion.Text, int.Parse(txt_monto.Text), meses);
                    }
                    else
                    {
                        MessageBox.Show("Ingrese una cantidad de meses valida");
                    }
                }
                else
                {
                    MessageBox.Show("Ingrese un monto mayor a 0");
                }
            }
            else
            {
                MessageBox.Show("Ingrese un nombre de Autoparte valida");
            }
        }
    }
}
