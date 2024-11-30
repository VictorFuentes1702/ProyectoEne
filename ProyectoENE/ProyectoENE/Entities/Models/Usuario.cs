using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoENE.Entities.Models
{
    public class Usuario
    {
        private string user;
        private string clave;
        private string tipoUsuario;

        public string User { get => user; set => user = value; }
        public string Clave { get => clave; set => clave = value; }
        public string TipoUsuario { get => tipoUsuario; set => tipoUsuario = value; }
    }
}
