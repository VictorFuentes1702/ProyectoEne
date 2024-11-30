using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoENE.DataAccess;
using ProyectoENE.Entities.Models;

namespace ProyectoENE.BusinessLogic
{
    public class TrabajadorService
    {
        private  TrabajadorRepository trabajadorRepository = TrabajadorRepository.GetInstancia();

        public void  AgregarTrabajador(Trabajador trabajador)
        {

            if(string.IsNullOrEmpty(trabajador.Rut)||
                string.IsNullOrEmpty(trabajador.Nombre)||
                string.IsNullOrEmpty(trabajador.Apellido) ||
                string.IsNullOrEmpty(trabajador.direccion)|| 
                string.IsNullOrEmpty(trabajador.telefono)
                )
                {
                throw new System.ArgumentException("Todos los campos deben tener valores");
            }
            trabajadorRepository.GuardarTrabajador(trabajador);
        }
        //obtener los trabajados
        public List<Trabajador> ObtenerTodosTrabajadores()
        {
            return trabajadorRepository.ObtenerTodosTrabajadores();
        }

        //llamamos al metodo que trae a un trabajdor segun su rut
        public Trabajador ObtenerTrabajadorPorRut(string ParametroRut)
        {
            return trabajadorRepository.ObtenerTrabajadorPorRut(ParametroRut);
        }

        //editar trabajador
        public void EditarTrabajador(Trabajador oTrabajador)
        {
            trabajadorRepository.EditarTrabajador(oTrabajador);
        }

        public void EliminarTrabajador(Trabajador oTrabajador) {

            trabajadorRepository.EliminarTrabajador(oTrabajador);
        }

       
    }
}
