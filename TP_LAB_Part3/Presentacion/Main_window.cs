using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TP_LAB_Part3.Presentacion;
using TP_LAB_Part3.Presentacion.Consutas_DGV;
using TP_LAB_Part3.Presentacion.Enums;
using TP_LAB_Part3.Presentacion.Frm_Filtro;
using TP_LAB_Part3.Presentacion.Frm_Reporte;

namespace TP_LAB_Part3
{
    public partial class Main_window : Form
    {
        private DialogResult tipo_sesion;
        private bool flag_sesion = false; //Bandera SI o NO esta la sesión iniciada
        private Enum_Camino Camino = Enum_Camino.Camino_inicio; //Bandera para botones: SI o NO son visibles

        public Main_window()
        {
            InitializeComponent();
            pictureBox1.Visible = true;
            pictureBox1.Anchor = AnchorStyles.None;
        }

        #region Habilitar-Componentes-Botones
        public void Habilitar_BotonesConsulta(DialogResult Tipo, Enum_Botones Boton_Tipo)
        {

            btnAutopartes.Visible = false;
            btnVista.Visible = false;
            btnVehiculo.Visible = false;
            btnPromoClientes.Visible = false;
            btnPromCobros.Visible = false;
            btnAutopartes_Vendidas.Visible = false;
            btnFactura.Visible = false;
            btnVendedoresDes.Visible = false;
            btnOrPedido.Visible = false;

            pictureBox1.Visible = true;
            lbl_platinum.Visible = true;

            //Boton de Ver Productos
            if ((Tipo == DialogResult.Abort || Tipo == DialogResult.OK || Tipo == DialogResult.Ignore) && Boton_Tipo == Enum_Botones.VerProductoBoton) //admin, gerente, vendedor
            {
                btnAutopartes.Visible = true;
                btnVista.Visible = true;
                btnVehiculo.Visible = true;

                //Fondo
                pictureBox1.Visible = false;
                lbl_platinum.Visible = false;

                Camino = Enum_Camino.Camino_BotonVisible;
            }
            //Boton Informes
            else if((Tipo == DialogResult.Abort || Tipo == DialogResult.OK) && Boton_Tipo == Enum_Botones.VerInformesBoton)//admin, gerente
            {
                //Fondo
                btnAutopartes_Vendidas.Visible = true;
                btnFactura.Visible = true;
                btnVendedoresDes.Visible = true;
                btnOrPedido.Visible = true;

                //Fondo
                pictureBox1.Visible = false;
                lbl_platinum.Visible = false;

                Camino = Enum_Camino.Camino_BotonVisible;
            }
            //Botones de Relevamientos
            else if ((Tipo == DialogResult.Abort || Tipo == DialogResult.OK) && Boton_Tipo == Enum_Botones.VerRelevamientosBoton)//admin, gerente
            {
                btnPromoClientes.Visible = true;
                btnPromCobros.Visible = true;

                //Fondo
                pictureBox1.Visible = false;
                lbl_platinum.Visible = false;

                Camino = Enum_Camino.Camino_BotonVisible;
            }
            else if (Boton_Tipo == Enum_Botones.EsconderBotones)
            {
                Camino = Enum_Camino.Camino_Dejatodoigual;
            }
            else
            {
                //Error
                Camino = Enum_Camino.Camino_Dejatodoigual;
            }

        }
        #endregion

        #region Habilitar-Componentes-Sesión
        //Habilitar componentes NO visibles, depediendo de cual sea del inicio de sesión
        public void Habilitar(DialogResult tipo)//Se utiliza el DialogResult como un enum para saber que tipo de usuario entra
        {
            if (DialogResult.Abort == tipo)//Admin
            {
                //Boton sesión
                btnSesion.Text = "Cerrar Sesión";

                //Botones NavBar
                btnProductos.Visible = true;
                btnEstrategicas.Visible = true;
                btnInformes.Visible = true;

                //Ver productos
                btnAutopartes.Visible = false;
                btnVehiculo.Visible = false;
                btnVista.Visible = false;

                //Informes
                btnFactura.Visible = false;
                btnOrPedido.Visible = false;
                btnVendedoresDes.Visible = false;
                btnAutopartes_Vendidas.Visible = false;

                //Estrategicas
                btnPromCobros.Visible = false;
                btnPromoClientes.Visible = false;

                pictureBox1.Visible = true;
                lbl_platinum.Visible = true;


                flag_sesion = true;
            }
            else if (DialogResult.Ignore == tipo)//Vendedor
            {
                //Boton sesión
                btnSesion.Text = "Cerrar Sesión";

                //Botones NavBar
                btnProductos.Visible = true;

                //Ver productos
                btnAutopartes.Visible = false;
                btnVehiculo.Visible = false;
                btnVista.Visible = false;

                //Informes
                btnFactura.Visible = false;
                btnOrPedido.Visible = false;
                btnVendedoresDes.Visible = false;
                btnAutopartes_Vendidas.Visible = false;

                //Estrategicas
                btnPromCobros.Visible = false;
                btnPromoClientes.Visible = false;

                pictureBox1.Visible = true;
                lbl_platinum.Visible = true;

                flag_sesion = true;
            }
            else if (DialogResult.OK == tipo)//Gerente
            {
                //Boton sesión
                btnSesion.Text = "Cerrar Sesión";

                //Botones NavBar
                btnProductos.Visible = true;
                btnEstrategicas.Visible = true;
                btnInformes.Visible = true;

                //Ver productos
                btnAutopartes.Visible = false;
                btnVehiculo.Visible = false;
                btnVista.Visible = false;

                //Informes
                btnFactura.Visible = false;
                btnOrPedido.Visible = false;
                btnVendedoresDes.Visible = false;
                btnAutopartes_Vendidas.Visible = false;

                //Estrategicas
                btnPromCobros.Visible = false;
                btnPromoClientes.Visible = false;

                pictureBox1.Visible = true;
                lbl_platinum.Visible = true;

                //Estrategicas
                flag_sesion = true;
            }
            else if (DialogResult.Yes == tipo)//Volver como inicio
            {
                //Boton sesión
                btnSesion.Text = "Iniciar Sesión";

                //Botones NavBar
                btnProductos.Visible = false;
                btnEstrategicas.Visible = false;
                btnInformes.Visible = false;

                //Ver productos
                btnAutopartes.Visible = false;
                btnVehiculo.Visible = false;
                btnVista.Visible = false;

                //Informes
                btnFactura.Visible = false;
                btnOrPedido.Visible = false;
                btnVendedoresDes.Visible = false;
                btnAutopartes_Vendidas.Visible = false;

                //Estrategicas
                btnPromCobros.Visible = false;
                btnPromoClientes.Visible = false;

                pictureBox1.Visible = true;
                lbl_platinum.Visible = true;

                flag_sesion = false;
            }
            else
            {
                flag_sesion = false;
            }
        }
        #endregion

        #region LOAD-MAIN-WINDOW
        private void Main_window_Load(object sender, EventArgs e)
        {

        }
        #endregion

        #region Inicio de Sesión Boton
        private void btnSesion_Click(object sender, EventArgs e)
        {
            if (flag_sesion == false)//No inicio sesion
            {
                Sesion oSesion = new Sesion();

                tipo_sesion = oSesion.ShowDialog();

                Habilitar(tipo_sesion);

                //Form
                btnSesion.Focus();
            }
            else if (flag_sesion == true)//Si inicio sesion
            {
                DialogResult result = MessageBox.Show("¿Desea cerrar la sesión?", "Cerrar Sesión", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

                if (result == DialogResult.Yes)
                {
                    Habilitar(result);
                }

                //Form
                btnSesion.Focus();
            }
            else
            {
                //error
            }
        }
        #endregion

        #region Salir-del-programa
        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Desea cerrar la aplicación?", "Salir", MessageBoxButtons.YesNo,MessageBoxIcon.Question,MessageBoxDefaultButton.Button2);

            if (result == DialogResult.Yes)
            {
                this.Close();
            }

            //Form
            btnSesion.Focus();
        }
        #endregion

        #region Ver-Productos
        private void btnProductos_Click(object sender, EventArgs e)
        {
            if (Camino == Enum_Camino.Camino_inicio)
            {
                Habilitar_BotonesConsulta(tipo_sesion, Enum_Botones.VerProductoBoton);
            }
            else if (Camino == Enum_Camino.Camino_BotonVisible)
            {
                Habilitar_BotonesConsulta(tipo_sesion, Enum_Botones.VerProductoBoton);
            }
            else
            {
                Habilitar_BotonesConsulta(tipo_sesion, Enum_Botones.EsconderBotones);
            }
        }
        #endregion

        #region VerProductos-Botones
        private void btnVehiculo_Click(object sender, EventArgs e)
        {
            Frm_Vehiculos oFrm_vehiculos = Frm_Vehiculos.Obtener_Frm();
            //oFrm_vehiculos.MdiParent = this; ????????????????
            oFrm_vehiculos.Show();
        }
        private void btnAutopartes_Click(object sender, EventArgs e)
        {
            Frm_Autopartes oFrm_autopartes = Frm_Autopartes.Obtener_Frm();
            //oFrm_autopartes.MdiParent = this; ?????????????
            oFrm_autopartes.Show();
        }
        private void btnVista_Click(object sender, EventArgs e)
        {
            Frm_Vista oFrm_Vista = Frm_Vista.Obtener_Frm();
            //oFrm_Vista.MdiParent = this; ?????????????
            oFrm_Vista.Show();
        }
        #endregion

        #region Informes
        private void btnInformes_Click(object sender, EventArgs e)
        {
            if (Camino == Enum_Camino.Camino_inicio)
            {
                Habilitar_BotonesConsulta(tipo_sesion, Enum_Botones.VerInformesBoton);
            }
            else if (Camino == Enum_Camino.Camino_BotonVisible)
            {
                Habilitar_BotonesConsulta(tipo_sesion, Enum_Botones.VerInformesBoton);
            }
            else
            {
                Habilitar_BotonesConsulta(tipo_sesion, Enum_Botones.EsconderBotones);
            }
        }
        #endregion

        #region Relevamientos-Botones
        //Falta conectar con la base de datos
        private void btnPromoClientes_Click(object sender, EventArgs e)
        {
            FrmMostratConsulta3 oFrmConsulta3 = FrmMostratConsulta3.ObtenerInstancia();
            oFrmConsulta3.Show();
        }

        private void btnPromCobros_Click(object sender, EventArgs e)
        {
            FrmFiltro6 oFrmConsulta6 = FrmFiltro6.obtenerInstancia();
            oFrmConsulta6.Show();
        }
        #endregion

        #region Relevamientos
        private void btnEstrategicas_Click(object sender, EventArgs e)
        {
            if (Camino == Enum_Camino.Camino_inicio)
            {
                Habilitar_BotonesConsulta(tipo_sesion, Enum_Botones.VerRelevamientosBoton);
            }
            else if(Camino == Enum_Camino.Camino_BotonVisible)
            {
                Habilitar_BotonesConsulta(tipo_sesion, Enum_Botones.VerRelevamientosBoton);
            }
            else
            {
                Habilitar_BotonesConsulta(tipo_sesion, Enum_Botones.EsconderBotones);
            }
        }
        #endregion

        #region Informes-Botones

        private void btnFactura_Click(object sender, EventArgs e)
        {
            frmConsultaSOFI Sofi = frmConsultaSOFI.ObtenerInstancia();
            Sofi.Show();
        }
        private void btnOrPedido_Click(object sender, EventArgs e)
        {
            FrmFiltro2 ofrmFiltro2 = FrmFiltro2.obtenerInstancia();
            ofrmFiltro2.Show();
        }
        private void btnVendedoresDes_Click(object sender, EventArgs e)
        {
            Frm_MostrarConsulta4 oFrm_Consulta4 = Frm_MostrarConsulta4.ObtenerInstancia();
            oFrm_Consulta4.Show();
        }

        private void btnAutopartes_Vendidas_Click(object sender, EventArgs e)
        {
            FrmFiltro5 oFrm_Consulta5 = FrmFiltro5.obtenerInstancia();
            oFrm_Consulta5.Show();
        }
        #endregion
    }
}
