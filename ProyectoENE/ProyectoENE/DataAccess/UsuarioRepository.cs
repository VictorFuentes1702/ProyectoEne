using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoENE.Entities.Models;

namespace ProyectoENE.DataAccess
{
   public class UsuarioRepository
    {
        private static UsuarioRepository Instancia; //Singleton
        private List<Usuario> listaUsuarios = new List<Usuario>();
        //Constuctor Privado para evitar que se instancien varios objetos
        private UsuarioRepository() { }

        // Método para obtener la única instancia de UsuarioRepository
        public static UsuarioRepository ObtenerInstancia() {

            if (Instancia == null) {
                Instancia = new UsuarioRepository();
            }
            return Instancia;
        }
        //Metodo para guardar un usuario
        //Hasta aqui enviaremos los datos desde el formulario cuando guardemos
        //un usuario
        public void GuardarUsuario(Usuario oUsuario)
        {

            listaUsuarios.Add(oUsuario);

        }
        //buscar un usuario por un criterio de busqueda(usuario)
        public Usuario ObtenerUsuarioPorUser(string ParametroUser)
        {

            return listaUsuarios.Find(t => t.User == ParametroUser);
        }
        // Método para obtener todos los usuarios
        //Cuando necesitemos saber un usuario o varios,
        //Usamos este metodo
        public List<Usuario> ObtenerTodosUsuarios()
        {

            return listaUsuarios;

        }
        public void EliminiarUsuario(Usuario oUsuario)
        {

            listaUsuarios.Remove(oUsuario);

        }

    }
}
