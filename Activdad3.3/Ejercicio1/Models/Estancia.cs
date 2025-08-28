using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1.Models
{
    internal class Estancia
    {
        public string Nombre { get; set; }
        public Casco Casco { get; set; }

        public Estancia(string nombre, string idCampo, double sup )
        {

        }
    }
}
