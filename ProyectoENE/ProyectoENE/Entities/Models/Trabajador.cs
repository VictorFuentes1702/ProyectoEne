using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoENE.Entities.Models
{
    public class Trabajador
    {
        public string Rut { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string direccion { get; set; }
        public string telefono { get; set; }
        public int valorHora { get; set; }
        
        public int valorExtra { get; set; }
        public int sueldoBruto { get; set; }
        public int sueldoLiquido { get; set; }

        public string afp { get; set; }
        public string salud { get; set; }

    }
}
