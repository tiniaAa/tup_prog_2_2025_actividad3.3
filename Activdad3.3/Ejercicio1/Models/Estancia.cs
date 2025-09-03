using System;
using System.Collections;
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

        ArrayList puestos = new ArrayList();

        ArrayList Campos = new ArrayList();
        public Estancia(string nombre, string idCampo, double superficie  )
        {

            this.Nombre = nombre;
            this.Casco=new Casco();
            this.Casco.Administrador = "Sin asignar ";
            Puesto puesto = new Puesto();
            puestos.Add( puesto);
            puesto.Responsable = "Sin asignar ";


            Campo campo = new Campo(idCampo,superficie);
            Campos.Add(campo);


        }
        #region administrar campos 


        public Campo AgregarCampos(string identificador, double superficie )
        {
            Campo nuevo = new Campo(identificador, superficie);
            Campos.Add(nuevo);
            return nuevo;
        }
        public Campo VerCampo (int idx)
        {
            if (Campos!=null && idx>=0 && idx < Campos.Count)
            {
                return Campos[idx] as Campo;
            }
            return null;
        }
        public int VerCantidadDeCampos()
        {
            return Campos.Count;
        }

        #endregion

    }
}
