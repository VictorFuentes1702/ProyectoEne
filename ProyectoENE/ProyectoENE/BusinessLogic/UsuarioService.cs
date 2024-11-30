using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoENE.DataAccess;
using ProyectoENE.Entities.Models;

namespace ProyectoENE.BusinessLogic
{
    public class UsuarioService
    {
        private UsuarioRepository oUsuarioRepository = UsuarioRepository.ObtenerInstancia();

        public void AgregarUsuario(Usuario oUsuario)
        {
            if (string.IsNullOrEmpty(oUsuario.User) || string.IsNullOrEmpty(oUsuario.Clave) || string.IsNullOrEmpty(oUsuario.TipoUsuario))
            {
                throw new System.ArgumentException("Todos los campos deben estar llenos");
            }
            oUsuarioRepository.GuardarUsuario(oUsuario);
        }

        // obtener Usuarios
        public List<Usuario> ObtenerTodosUsuarios()
        {
            return oUsuarioRepository.ObtenerTodosUsuarios();
        }

        //llamamos al metodo que trae a un usuario segun su usuario
        public Usuario ObtenerUsuarioPorUser(string ParametroUser)
        {
            return oUsuarioRepository.ObtenerUsuarioPorUser(ParametroUser);
        }

    }
}
