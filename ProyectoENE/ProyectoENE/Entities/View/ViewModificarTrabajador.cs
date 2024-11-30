using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoENE.BusinessLogic;
using ProyectoENE.Entities.Models;

namespace ProyectoENE.Entities.View
{
    public partial class ViewModificarTrabajador : Form
    {
        private TrabajadorService trabajadorService = new TrabajadorService();

        public ViewModificarTrabajador()
        {
            InitializeComponent();
            List<Trabajador> oTrabajador = trabajadorService.ObtenerTodosTrabajadores();
            cargarTabla(oTrabajador);
        }

        public void Limpiar()
        {

            txt_Apellido.Clear();
            txt_Direccion.Clear();
            txt_nombre.Clear();
            txt_Rut.Clear();
            txt_Telefono.Clear();
            txt_Val_Hora.Clear();
            txt_Val_horaExtra.Clear();
            cbo_rut.Items.Clear();
        }
        public void cargarTabla(List<Trabajador> lista)
        {

            if (lista != null)
            {
                tbl_Trajabadores.DataSource = lista;
            }
            else
            {
                MessageBox.Show("No existen datos en la lista");
            }


        }
        private void CargarRutEnCombobox()
        {
            //Obtenemos la lista de trabajadores desde la segunda capa
            List<Trabajador> trabajadores = trabajadorService.ObtenerTodosTrabajadores();

            //limpiar el combobox
            cbo_rut.Items.Clear();

            //
            //cbo_rut.Items.Add("TODOS");
            foreach (var trabajador in trabajadores)
            {
                cbo_rut.Items.Add(trabajador.Rut);
            }
        }

        private void txt_Rut_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void ViewModificarTrabajador_Load(object sender, EventArgs e)
        {
            CargarRutEnCombobox();
        }



        private void cbo_rut_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cbo_rut_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            //cuando se seleccione un item del combobox lo rescatamos en la variable
            string rutSeleccionado = cbo_rut.SelectedItem.ToString();



            Trabajador trabajador = trabajadorService.ObtenerTrabajadorPorRut(rutSeleccionado);

            if (trabajador != null)
            {
                txt_Rut.Text = trabajador.Rut;
                txt_Apellido.Text = trabajador.Apellido;
                txt_nombre.Text = trabajador.Nombre;
                txt_Rut.Text = trabajador.Rut;
                txt_Telefono.Text = trabajador.telefono;
                txt_Direccion.Text = trabajador.direccion;
                txt_Val_Hora.Text = "" + trabajador.valorHora;
                txt_Val_horaExtra.Text = "" + trabajador.valorExtra;

            }


            if (rutSeleccionado == "TODOS")
            {
                List<Trabajador> oTrabajador = trabajadorService.ObtenerTodosTrabajadores();
                cargarTabla(oTrabajador);
            }
            else
            {
                Trabajador oTrabajador = trabajadorService.ObtenerTrabajadorPorRut(rutSeleccionado);
                //le pedimos a la 2da capa los detalles del trabajador

                /*
                string rutTrabajador = trabajador.Rut;
                string nombreTrabajador=trabajador.Nombre;
                string apellidoTrabajador = trabajador.Apellido;

                MessageBox.Show("Rut trabajador "+rutTrabajador+", Nombre trabajador "+nombreTrabajador+", Apellido trabajador "+apellidoTrabajador);
                */

                //ahora tenenmos los datos del trabajador en base al rut, 
                //Cargaremos esos datos en una tabla virtual
                if (trabajador != null)
                {
                    //creamos tabla temporal que será asiganda al datagridview
                    var tabla = new System.Data.DataTable();

                    //agregamos las columnas que necesitamos
                    tabla.Columns.Add("Rut");
                    tabla.Columns.Add("Nombre");
                    tabla.Columns.Add("Apellido");
                    tabla.Columns.Add("Telefono");
                    tabla.Columns.Add("Sueldo Bruto");
                    tabla.Columns.Add("Sueldo Liquido");
                    tabla.Columns.Add("Direccion");
                    tabla.Columns.Add("Valor Hora");
                    tabla.Columns.Add("Valor Hora Extra");
                    tabla.Columns.Add("AFP");
                    tabla.Columns.Add("Salud");

                    //Agregamos las filas con los resutlados
                    tabla.Rows.Add(trabajador.Rut,
                                    trabajador.Nombre,
                                    trabajador.Apellido,
                                    trabajador.telefono,
                                    trabajador.sueldoBruto,
                                    trabajador.sueldoLiquido,
                                    trabajador.direccion,
                                    trabajador.valorHora,
                                    trabajador.valorExtra,
                                    trabajador.afp,
                                    trabajador.salud);

                    //Le entregamos la tabla virtual al datagridview o grilla
                    tbl_Trajabadores.DataSource = tabla;
                }
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cbo_rut.SelectedItem != null)
            {

                Trabajador oTrabajador = new Trabajador();
                oTrabajador.Nombre = txt_nombre.Text;
                oTrabajador.Apellido = txt_Apellido.Text;
                oTrabajador.Rut = txt_Rut.Text;
                oTrabajador.direccion = txt_Direccion.Text;
                oTrabajador.telefono = txt_Telefono.Text;
                oTrabajador.valorHora = Int32.Parse(txt_Val_Hora.Text);
                oTrabajador.valorExtra = Int32.Parse(txt_Val_horaExtra.Text);

                try
                {
                    // Llamada a la capa de servicio para actualizar el trabajador
                    trabajadorService.EditarTrabajador(oTrabajador);
                    MessageBox.Show("Trabajador modificado exitosamente");

                    Limpiar();
                    // Actualizar la grilla
                    CargarRutEnCombobox();
                    List<Trabajador> trabajadores = trabajadorService.ObtenerTodosTrabajadores();

                    cargarTabla(trabajadores);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al modificar trabajador: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar rut");
            }

        }

        private void volverToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VistaAdmin f = new VistaAdmin();
            f.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (cbo_rut.SelectedItem != null)
            {

                string rut = cbo_rut.SelectedItem.ToString();
                Trabajador oTrabajador = new Trabajador();
                oTrabajador.Rut = rut;

                trabajadorService.EliminarTrabajador(oTrabajador);


                MessageBox.Show("Trabajador Eliminado");


                List<Trabajador> trabajadores = trabajadorService.ObtenerTodosTrabajadores();

                cargarTabla(trabajadores);

                Limpiar();
                CargarRutEnCombobox();
            }
            else
            {

                MessageBox.Show("Debe selecionar un rut");
            }

        }

        private void tbl_Trajabadores_SelectionChanged(object sender, EventArgs e)
        {

        }

        private void cerrarSesionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            this.Close();
        }

        private void tbl_Trajabadores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
