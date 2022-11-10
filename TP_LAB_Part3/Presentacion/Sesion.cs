using Biblioteca_clases.Dominio.Sesiones;
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
    public partial class Sesion : Form
    {
        private List<Usuario> lst_sesiones = new List<Usuario>();
        private Helper oHelper = Helper.ObtenerInstancia(); //HELPER con SINGLETON

        public Sesion()
        {
            InitializeComponent();
        }

        #region LOAD-SESION
        private void Sesion_Load(object sender, EventArgs e)
        {
            DataTable tabla = new DataTable();

            tabla = oHelper.ObtenerUsuarios("SP_USUARIOS");

            foreach (DataRow fila in tabla.Rows)
            {
                Usuario oNewUsuario = new Usuario();

                oNewUsuario.pUsuario = fila["Usuario"].ToString();
                oNewUsuario.Contrasenia = fila["Contrasenia"].ToString();
                oNewUsuario.Tipo_Usuario = fila["Tipo_Usuario"].ToString();

                lst_sesiones.Add(oNewUsuario);
            }
        }
        #endregion

        #region Boton-Cancelar
        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Desea cancelar el inicio de sesión?", "Cancelar", MessageBoxButtons.YesNo,MessageBoxIcon.Question,MessageBoxDefaultButton.Button2);

            if(result == DialogResult.Yes)
            {
                this.Close();
            }

            //Form
            btn_aceptar.Focus();
        }
        #endregion

        #region Boton-Aceptar
        private void btn_aceptar_Click(object sender, EventArgs e)//NO TOQUEN NADA DE ESTO
        {
            bool flag_inicio = false;

            if (txt_usuario.Text != "" && txt_contra.Text != "")
            {
                foreach (Usuario oUsuario in lst_sesiones)
                {
                    if (txt_usuario.Text == oUsuario.pUsuario && txt_contra.Text == oUsuario.Contrasenia)
                    {
                        if(oUsuario.Tipo_Usuario == "Admin")
                        {
                            this.DialogResult = DialogResult.Abort;//Admin
                            flag_inicio = true;
                            break;
                        }
                        else if(oUsuario.Tipo_Usuario == "Vendedor")
                        {
                            this.DialogResult = DialogResult.Ignore;//Vendedor
                            flag_inicio = true;
                            break;
                        }
                        else if(oUsuario.Tipo_Usuario == "Gerente")
                        {
                            this.DialogResult = DialogResult.OK;//Gerente
                            flag_inicio = true;
                            break;
                        }
                        else
                        {
                            //Error
                            flag_inicio = false;
                        }
                    }
                    else
                    {
                        flag_inicio = false;
                    }
                }

                if(flag_inicio)
                {
                    MessageBox.Show("Inicio de Sesión exitoso!", "Inicio Sesión", MessageBoxButtons.OK, MessageBoxIcon.None, MessageBoxDefaultButton.Button2);
                }
                else
                {
                    MessageBox.Show("El usuario o la contraseña ingresada son incorrectas");
                }
            }
            else
            {
                MessageBox.Show("Ingrese un usuario y contraseña");
            }

            //Form
            txt_usuario.Focus();
        }
        #endregion

        #region Ocultar o mostrar Contraseña
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_mostrar.Checked)
            {
                txt_contra.PasswordChar = '\0';
            }
            else
            {
                txt_contra.PasswordChar = '*';
            }
        }
        #endregion
    }
}
