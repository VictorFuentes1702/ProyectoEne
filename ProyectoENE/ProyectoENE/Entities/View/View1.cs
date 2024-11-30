using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoENE.Entities.Models;
using ProyectoENE.BusinessLogic;
using ProyectoENE.DataAccess;

namespace ProyectoENE.Entities.View
{
    public partial class View1 : Form
    {
        private UsuarioService oUsuarioService = new UsuarioService();
        public View1()
        {
            InitializeComponent();
        }
        private void Limpiar()
        {
            txt_User.Clear();
            txt_Pass.Clear();
            cbo_Tipo.SelectedIndex = 0;
        }
        private void btn_agregar_Click(object sender, EventArgs e)
        {
            Usuario oUsuario = new Usuario
            {
                User = txt_User.Text,
                TipoUsuario = cbo_Tipo.Text,
                Clave = txt_Pass.Text

            };

            try
            {
                // Llamamos a la 2da Capa que es la que comunica con la 3ra capa
                // para entregar el objeto trabajador


                //Limpiar (Se puede Crear metodo)
                //Limpiar();

                //actualizar Cbo

                if (oUsuarioService.ObtenerUsuarioPorUser(oUsuario.User) == null)
                {
                    oUsuarioService.AgregarUsuario(oUsuario);
                    //ListaUsuario.ObtenerUsuario().datosUsuarios.Add(oUsuario);
                    MessageBox.Show("Usuario Agregado Correctamente");
                    Limpiar();
                }
                else
                {
                    MessageBox.Show("Usuario ya existe");
                }





            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void volverToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 fe = new Form1();
            fe.Show();
            this.Hide();
        }

        private void cbo_Tipo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
