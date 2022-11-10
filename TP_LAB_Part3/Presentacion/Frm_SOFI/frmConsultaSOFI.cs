using Biblioteca_clases.Dominio.Facturas_Ordenes.T_Detalles;
using Biblioteca_clases.Dominio.Productos;
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
    public partial class frmConsultaSOFI : Form
    {
        private static frmConsultaSOFI Instancia;
        private frmConsultaSOFI()
        {
            InitializeComponent();
        }

        private void ocultarColumnasAutoParte()
        {
            dataGridView1.Columns["Codigo AutoParte"].Visible=false;
            dataGridView1.Columns["stock_minimo"].Visible = false;
            dataGridView1.Columns["CodigoCliente"].Visible = false;
            dataGridView1.Columns["CodigoVendedor"].Visible = false;
        }

       
        private void ocultarColumnasAuto()
        {
            dataGridView1.Columns["Codigo Vehiculo"].Visible = false;
            dataGridView1.Columns["CodigoCliente"].Visible = false;
            dataGridView1.Columns["CodigoVendedor"].Visible = false;
        }

        private void frmConsultaSOFI_Load(object sender, EventArgs e)
        {
           
                cboCampo.Items.Add("Número Factura");
                cboCampo.Items.Add("Descripción");
                cboCampo.Items.Add("Stock");
                cboCampo.Items.Add("Cliente");
                cboCampo.Items.Add("Precio Unitario");
            
        }

        private void cargarGrilla()
        {
            Consulta_Negocio negocio = new Consulta_Negocio();
            try
            {
                DataTable dataTable = negocio.grilla();
                dataGridView1.DataSource = dataTable;
                ocultarColumnasAutoParte();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }
        private void cargarGrillaAuto()
        {
            Consulta_Negocio_Vehiculo negocio = new Consulta_Negocio_Vehiculo();
            try
            {
                DataTable dataTable = negocio.grilla();
                dataGridView1.DataSource = dataTable;
                ocultarColumnasAuto();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }
        private void btnFiltro_Click(object sender, EventArgs e)
        {
            Consulta_Negocio negocio = new Consulta_Negocio();
            Consulta_Negocio_Vehiculo vehiculo = new Consulta_Negocio_Vehiculo();
            try
            {
                if (validarFiltro())
                    return;

                string campo = cboCampo.SelectedItem.ToString();
                string criterio = cboCriterio.SelectedItem.ToString();
                string filtro = txtFiltroAvanzado.Text;
                if(rbtAutoParte.Checked==true)
                {
                    dataGridView1.DataSource = negocio.filtrar(campo, criterio, filtro);
                }
                else
                {
                    dataGridView1.DataSource=vehiculo.filtrar(campo, criterio, filtro);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private bool validarFiltro()
        {
            if (cboCampo.SelectedIndex < 0)
            {
                MessageBox.Show("Por favor, seleccione el campo para filtrar.");
                return true;
            }
            if (cboCriterio.SelectedIndex < 0)
            {
                MessageBox.Show("Por favor, seleccione el criterio para filtrar.");
                return true;
            }
            if (cboCampo.SelectedItem.ToString() == "Número")
            {
                if (string.IsNullOrEmpty(txtFiltroAvanzado.Text))
                {
                    MessageBox.Show("Debes cargar el filtro para numéricos...");
                    return true;
                }
                if (!(soloNumeros(txtFiltroAvanzado.Text)))
                {
                    MessageBox.Show("Solo nros para filtrar por un campo numérico...");
                    return true;
                }

            }

            return false;
        }

        private bool soloNumeros(string cadena)
        {
            foreach (char caracter in cadena)
            {
                if (!(char.IsNumber(caracter)))
                    return false;
            }
            return true;
        }

       
        private void cboCampo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string opcion = cboCampo.SelectedItem.ToString();
            if (opcion == "Número Factura" || opcion== "Stock" || opcion== "Precio Unitario")
            {
                cboCriterio.Items.Clear();
                cboCriterio.Items.Add("Mayor a");
                cboCriterio.Items.Add("Menor a");
                cboCriterio.Items.Add("Igual a");
            }
            else
            {
                cboCriterio.Items.Clear();
                cboCriterio.Items.Add("Comienza con");
                cboCriterio.Items.Add("Termina con");
                cboCriterio.Items.Add("Contiene");
            }
        }

       
        private void LimpiarGrilla()
        {
            if(!rbtAutoParte.Checked && !rbtVehiculo.Checked)
            {
                dataGridView1.DataSource = null;
            }
        }
      
        private void rbtAutoParte_CheckedChanged(object sender, EventArgs e)
        {
            cargarGrilla();
            LimpiarGrilla();
        }

        private void rbtVehiculo_CheckedChanged(object sender, EventArgs e)
        {
            cargarGrillaAuto();
            LimpiarGrilla();
        }

        public static frmConsultaSOFI ObtenerInstancia()
        {
            if(Instancia == null || Instancia.IsDisposed)
            {
                Instancia = new frmConsultaSOFI();
            }

            return Instancia;
        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Desea cerrar la ventana?", "", MessageBoxButtons.YesNo,MessageBoxIcon.Question,MessageBoxDefaultButton.Button2);

            if (result == DialogResult.Yes)
            {
                Dispose();
            }

            //Form
            btn_cerrar.Focus();
        }
    }
}
