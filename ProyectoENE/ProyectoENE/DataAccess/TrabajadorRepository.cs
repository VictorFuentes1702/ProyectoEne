using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoENE.Entities.Models;
using ProyectoENE.DataAccess;

namespace ProyectoENE.DataAccess
{
    public class TrabajadorRepository
    {
        public static TrabajadorRepository instancia;
        //Lista que guarda los trabajadores y desde la que
        //alimentaremos y consultaremo
        //los datos desde distintos formularios
        private List<Trabajador> listaTrabajadores = new List<Trabajador>();

        private TrabajadorRepository() { }
        public static TrabajadorRepository GetInstancia()
        {
            if (instancia == null)
            {
                instancia = new TrabajadorRepository();
            }
            return instancia;
        }


        //Metodo para guardar un trabajador
        //Hasta aqui enviaremos los datos desde el formulario cuando guardemos
        //un trabajador
        public void GuardarTrabajador(Trabajador trabajador)
        {
            listaTrabajadores.Add(trabajador);
        }

        // Método para obtener todos los trabajadores
        //Cuando necesitemos saber un trabajador o varios,
        //Usamos este metodo
        public List<Trabajador> ObtenerTodosTrabajadores()
        {
            return listaTrabajadores;
        }

        //buscar un trabajador por un criterio de busqueda(RUT)
        public Trabajador ObtenerTrabajadorPorRut(string ParametroRut)
        {
            return listaTrabajadores.Find(t => t.Rut == ParametroRut);
        }
        public bool EditarTrabajador(Trabajador otrabajador)
        {

            Trabajador trabajdor = ObtenerTrabajadorPorRut(otrabajador.Rut);
            if (trabajdor != null)
            {
                trabajdor.Nombre = otrabajador.Nombre;
                trabajdor.Apellido = otrabajador.Apellido;
                trabajdor.direccion = otrabajador.direccion;
                trabajdor.telefono = otrabajador.telefono;
                trabajdor.valorHora = otrabajador.valorHora;
                trabajdor.valorExtra = otrabajador.valorExtra;

                return true;
            }
            return false;

        }

        public bool EliminarTrabajador(Trabajador oTrabajador) {


            Trabajador trabajdor = ObtenerTrabajadorPorRut(oTrabajador.Rut);

            if (trabajdor != null)
            {
                instancia.listaTrabajadores.Remove(trabajdor);
                
                return true;
            }
            return false;
        }
    }
}
