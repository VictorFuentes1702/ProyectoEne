using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoENE.Entities.View
{
    public partial class VistaAdmin : Form
    {
        public VistaAdmin()
        {
            InitializeComponent();
        }

        private void opcionesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void añadirToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void VistaAdmin_Load(object sender, EventArgs e)
        {

        }

        private void usuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewAgregarUsuario f = new ViewAgregarUsuario();
            f.Show();
            this.Hide();
        }

        private void trabajadorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            viewAgregarTrabajador f = new viewAgregarTrabajador();
            f.Show();
            this.Hide();
        }

        private void listarTrabajadoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            viewListarTrabajadores f = new viewListarTrabajadores();
            f.Show();
            this.Hide();
        }

        private void trabajadorToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ViewModificarTrabajador f = new ViewModificarTrabajador();
            f.Show();
            this.Hide();
        }

        private void sueldoTrabajadorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewAgregarSueldos f = new ViewAgregarSueldos();
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
