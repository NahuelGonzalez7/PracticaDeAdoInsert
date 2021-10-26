using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Models
{
    public class Especialidad
    {
        public int ID { get; set; }
        public string Nombre { get; set; }

        public Especialidad()
        {

        }
        public Especialidad(int iD, string nombre)
        {
            Nombre = nombre;
        }
    }
}
