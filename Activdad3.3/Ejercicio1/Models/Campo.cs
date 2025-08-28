using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1.Models
{
    public class Campo:IComparable
    {
        public string Identificado { get; set; }
        public double Superficie { get; set; }


        public Campo(string id, double sup) 
        
        {
            this.Identificado = id;
            this.Superficie = sup;
        }

        public int CompareTo(object otro)
        {
            Campo otroCampo = otro as Campo;
           if (otroCampo != null)
            {
                return Identificado.CompareTo(otroCampo.Identificado);
            }
            return 1;
        }
    }
}
