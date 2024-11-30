using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoENE.Entities.View;
using ProyectoENE.DataAccess;
using ProyectoENE.Entities.Models;
using ProyectoENE.BusinessLogic;

namespace ProyectoENE
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_ingresar_Click(object sender, EventArgs e)
        {
          

            UsuarioService usuarioService = new UsuarioService();
            string user = txt_Rut.Text;
            string pass = txt_Pass.Text;



            try
            {

                Usuario usuarioInstancia = usuarioService.ObtenerUsuarioPorUser(user);

                if (usuarioInstancia != null)
                {

                    string nombreUsuario = usuarioInstancia.User;
                    string clave = usuarioInstancia.Clave;
                    string tipo = usuarioInstancia.TipoUsuario;

                    if (nombreUsuario == user && pass == clave)
                    {
                        
                        if (tipo == "Administrador")
                        {
                            
                            VistaAdmin f = new VistaAdmin();
                            f.Show();
                            this.Hide();
                        }
                        else if (tipo == "Usuario")
                        {
                           
                            ViewAgregarSueldos f = new ViewAgregarSueldos();
                            f.Show();
                            this.Hide();
                        }
                    }
                    else
                    {
                        MessageBox.Show("El usuario o clave no son correctos");
                    }
                }
                else {
                    MessageBox.Show("Usuario No Existe");
                    txt_Pass.Clear();
                    txt_Rut.Clear();
                }
               

            }
            catch (Exception ex)
            {
                {
                    MessageBox.Show("Error al consultar usuario " + ex);

                }

            }


        }
    }
}
