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
    public partial class ViewAgregarSueldos : Form
    {
        private TrabajadorService trabajadorService = new TrabajadorService();
        public ViewAgregarSueldos()
        {
            InitializeComponent();
            txt_horas.Enabled = false;
            txt_horas_extra.Enabled = false;
            cbo_afp.Enabled = false;
            cbo_salud.Enabled = false;
            btn_calcular.Enabled = false;
            btn_guardar.Enabled = false;
            

        }

        private void CargarRutEnCombobox()
        {
            //Obtenemos la lista de trabajadores desde la segunda capa
            List<Trabajador> trabajadores = trabajadorService.ObtenerTodosTrabajadores();

            //limpiar el combobox
            cbo_Rut.Items.Clear();

            //
            //cbo_rut.Items.Add("TODOS");
            foreach (var trabajador in trabajadores)
            {
                cbo_Rut.Items.Add(trabajador.Rut);
            }
        }
        private void CargarCbo() {

            cbo_afp.Items.Clear();
            cbo_salud.Items.Clear();
            cbo_afp.Items.Add("CUPRUM");
            cbo_afp.Items.Add("MODELO");
            cbo_afp.Items.Add("CAPITAL");
            cbo_afp.Items.Add("PROVIDA");
            cbo_afp.SelectedIndex = 0;

            cbo_salud.Items.Add("FONASA");
            cbo_salud.Items.Add("CONSALUD");
            cbo_salud.Items.Add("MASVIDA");
            cbo_salud.Items.Add("BANMEDICA");
            
            cbo_salud.SelectedIndex = 0;


        }

        private int calcularDescuentoAfp(int sueldo_Bruto, string afp) {
            int descuento = 0;

            switch (afp) {

                case "CUPRUM":
                     descuento = (sueldo_Bruto * 7) / 100;
                    break;
                case "MODELO":
                    descuento = (sueldo_Bruto * 9) / 100;
                    break;
                case "CAPITAL":
                    descuento = (sueldo_Bruto * 12) / 100;
                    break;
                case "PROVIDA":
                    descuento = (sueldo_Bruto * 13) / 100;
                    break;
                
            }

            return descuento;
        }
        private int calcularDescuentoSalud(int sueldo_Bruto, string Salud)
        {
            int descuento = 0;

            switch (Salud)
            {

                case "FONASA":
                    descuento = (sueldo_Bruto * 12) / 100;
                    break;
                case "CONSALUD":
                    descuento = (sueldo_Bruto * 13) / 100;
                    break;
                case "MASVIDA":
                    descuento = (sueldo_Bruto * 14) / 100;
                    break;
                case "BANMEDICA":
                    descuento = (sueldo_Bruto * 15) / 100;
                    break;

            }

            return descuento;
        }
        private void volverToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 fe = new Form1();
            fe.Show();
            this.Dispose();
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {

        }

        private void txt_horas_extra_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {

                e.Handled = true;
            }
        }

        private void txt_horas_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {

                e.Handled = true;
            }
        }

        private void cbo_afp_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cbo_salud_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cbo_Rut_SelectedIndexChanged(object sender, EventArgs e)
        {
            //cuando se seleccione un item del combobox lo rescatamos en la variable
            string rutSeleccionado = cbo_Rut.SelectedItem.ToString();

                

            Trabajador trabajador = trabajadorService.ObtenerTrabajadorPorRut(rutSeleccionado);

            if (trabajador != null)
            {
                trabajador.afp = cbo_afp.Text;
                trabajador.salud = cbo_salud.Text;

            }
            txt_horas.Enabled = true;
            txt_horas_extra.Enabled = true;
            cbo_afp.Enabled = true;
            cbo_salud.Enabled = true;
            btn_calcular.Enabled = true;
            btn_guardar.Enabled = true;
            cbo_Rut.Enabled = false;
            btn_guardar.Enabled = false;

        }

        private void ViewAgregarSueldos_Load(object sender, EventArgs e)
        {
            CargarRutEnCombobox();
            cbo_Rut.Focus();

        }

        private void btn_calcular_Click(object sender, EventArgs e)
        {
            

            if (cbo_Rut.SelectedItem.ToString() != null)
            {
                string rutSeleccionado = cbo_Rut.SelectedItem.ToString();
                Trabajador trabajador = trabajadorService.ObtenerTrabajadorPorRut(rutSeleccionado);
                if (cbo_afp.SelectedItem != null && cbo_salud.SelectedItem != null && txt_horas.Text != "" && txt_horas_extra.Text != "")
                {
                    trabajador.afp = cbo_afp.SelectedItem.ToString();
                    trabajador.salud = cbo_salud.SelectedItem.ToString();

                    int sueldo_horas = trabajador.valorHora * Int32.Parse(txt_horas.Text);
                    int sueldo_horas_extra = trabajador.valorExtra * Int32.Parse(txt_horas_extra.Text);
                    trabajador.sueldoBruto = sueldo_horas + sueldo_horas_extra;
                    txt_sueldo_Bruto.Text = trabajador.sueldoBruto.ToString();
                    int descuentos = calcularDescuentoAfp(trabajador.sueldoBruto, trabajador.afp) + calcularDescuentoSalud(trabajador.sueldoBruto, trabajador.salud);
                    trabajador.sueldoLiquido = trabajador.sueldoBruto - descuentos;
                    txt_sueldo_Liquido.Text = trabajador.sueldoLiquido.ToString();
                    trabajadorService.EditarTrabajador(trabajador);

                    MessageBox.Show("Calculado!!");
                    btn_calcular.Enabled = false;
                    btn_guardar.Enabled = true;
                    txt_horas.Enabled = false;
                    txt_horas_extra.Enabled = false;
                    cbo_afp.Enabled =  false;
                    cbo_salud.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Debe completar los campos, si no se registran horas debe ingresar nro 0");
                }


            }
            else {
                MessageBox.Show("Debe seleccionar el Rut de Trabajador");
            }
        }

        private void cbo_Rut_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void txt_sueldo_Bruto_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void txt_sueldo_Liquido_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_sueldo_Liquido_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            viewListarTrabajadores f = new viewListarTrabajadores();
            f.Show();
            this.Hide();
        }
        private void limpiar() {
            txt_horas.Clear();
            txt_horas_extra.Clear();
            txt_sueldo_Bruto.Clear();
            txt_sueldo_Liquido.Clear();
            cbo_afp.Items.Clear();
            cbo_salud.Items.Clear();
            cbo_Rut.Items.Clear();
            CargarRutEnCombobox();
            CargarCbo();

        
        }
        private void button3_Click(object sender, EventArgs e)
        {
            txt_horas.Enabled = false;
            txt_horas_extra.Enabled = false;
            cbo_afp.Enabled = false;
            cbo_salud.Enabled = false;
            btn_calcular.Enabled = false;
            btn_guardar.Enabled = false;
            cbo_Rut.Enabled = true;
            limpiar();
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            int bruto = Int32.Parse(txt_sueldo_Bruto.Text);
            int liquido = Int32.Parse(txt_sueldo_Liquido.Text);
            string rut = cbo_Rut.SelectedItem.ToString();
            Trabajador trabajador = trabajadorService.ObtenerTrabajadorPorRut(rut);


            trabajador.sueldoBruto = bruto;
            trabajador.sueldoLiquido = liquido;
            trabajadorService.EditarTrabajador(trabajador);

            MessageBox.Show("Se a Registrado el Sueldo");

        }

        private void btn_guardar_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
    }
}
