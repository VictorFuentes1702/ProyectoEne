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
    public partial class viewListarTrabajadores : Form
    {
        private TrabajadorService trabajadorService = new TrabajadorService();
        public viewListarTrabajadores()
        {
            InitializeComponent();
            
        }
        private void CargarRutEnCombobox()
        {
            //Obtenemos la lista de trabajadores desde la segunda capa
            List<Trabajador> trabajadores = trabajadorService.ObtenerTodosTrabajadores();

            //limpiar el combobox
            cmb_buscar.Items.Clear();

            //
            cmb_buscar.Items.Add("TODOS");
            foreach (var trabajador in trabajadores)
            {
                cmb_buscar.Items.Add(trabajador.Rut);
            }
        }
        private void tbl_Trajabadores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

    

        private void viewListarTrabajadores_Load(object sender, EventArgs e)
        {
            CargarRutEnCombobox();
        }

        private void cmb_buscar_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            //cuando se seleccione un item del combobox lo rescatamos en la variable
            string rutSeleccionado = cmb_buscar.SelectedItem.ToString();
            if (rutSeleccionado == "TODOS")
            {
                List<Trabajador> trabajador = trabajadorService.ObtenerTodosTrabajadores();
                tbl_Trajabadores.DataSource = trabajador;
            }
            else
            {
                Trabajador trabajador = trabajadorService.ObtenerTrabajadorPorRut(rutSeleccionado);
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

        private void trabajadorToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void usuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void listarTrabajadoresToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void volverToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ViewAgregarSueldos f = new ViewAgregarSueldos();
            f.Show();
            this.Hide();
        }

        private void cerrarSesionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            this.Hide();
        }
    }
}
