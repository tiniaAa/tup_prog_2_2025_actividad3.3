using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1.Models
{
    public abstract class Actividad
    {
        public int Periodo { get; set; }
        public string Descripcion { get; set; }
        abstract public double CalcularProduccion();

        abstract public double CalcularRendimiento();


        protected List <Parcela> lotesAsignados = new List <Parcela> ();

        public Actividad (int periodo, string descripcion, Parcela parcela ) 
        {
            this.Periodo = periodo;
            this.Descripcion = descripcion;



        }


    }
}
