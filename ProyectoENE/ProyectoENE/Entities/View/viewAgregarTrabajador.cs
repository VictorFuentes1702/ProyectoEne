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

namespace ProyectoENE.Entities.View
{
    public partial class viewAgregarTrabajador : Form
    {

        private TrabajadorService oTrabajadorService = new TrabajadorService();
        public viewAgregarTrabajador()
        {
            InitializeComponent();
        }

        public void Limpiar() {

            txt_Apellido.Clear();
            txt_Direccion.Clear();
            txt_nombre.Clear();
            txt_Rut.Clear();
            txt_Telefono.Clear();
            txt_Val_Hora.Clear();
            txt_Val_horaExtra.Clear();

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txt_Val_Hora_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar)) {

                e.Handled = true;
            }
        }

        private void txt_Val_horaExtra_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {

                e.Handled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            
            string hora = "0";
            string horaExtra = "0";

            if (txt_Val_Hora.Text != "")
            {

                hora = txt_Val_Hora.Text; 

            }
            if (txt_Val_horaExtra.Text != "")
            {
                horaExtra = txt_Val_horaExtra.Text;
            }
            
            Trabajador oTrabajador = new Trabajador {
                Rut = txt_Rut.Text,
                Nombre = txt_nombre.Text,
                Apellido = txt_Apellido.Text,
                direccion = txt_Direccion.Text,
                telefono = txt_Telefono.Text,
                valorExtra = Int32.Parse(horaExtra),
                valorHora = Int32.Parse(hora)

            };

            try
            {
                // Llamamos a la 2da Capa que es la que comunica con la 3ra capa
                // para entregar el objeto trabajador


                


                oTrabajadorService.ObtenerTrabajadorPorRut(oTrabajador.Rut);
                if (oTrabajadorService.ObtenerTrabajadorPorRut(oTrabajador.Rut) == null)
                {

                    oTrabajadorService.AgregarTrabajador(oTrabajador);
                    MessageBox.Show("Trabajador Agregado Correctamente");

                    Limpiar();

                }
                else {
                    MessageBox.Show("Trabajador ya Existe");
                    txt_Rut.Text = "";
                }


               


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void txt_nombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {

                e.Handled = true;
            }
        }

        private void txt_Apellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {

                e.Handled = true;
            }
        }

        private void volverToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VistaAdmin f = new VistaAdmin();
            f.Show();
            this.Hide();
        }

        private void cerrarSesionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            this.Close();
        }
    }
}
