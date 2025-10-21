using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1.Models
{
    public class Repartidor
    {
        public int Capacidad { get; private set; }
        public int Ocupacion {
        get {
                return entregas.Count;
            }
        }

        private Stack<Paquete> entregas = new Stack<Paquete>();

        public Repartidor(int capacidad)
        {
            this.Capacidad = capacidad;
        }

        public Paquete Revisar() {
            Paquete paquete = null;
            if(entregas.Count > 0) {
                paquete = entregas.Peek();
            }
            return paquete;
        }

        public void Cargar(Paquete paqueteACargar) {
            if(TieneCapacidadDisponible()==true)
            {
                entregas.Push(paqueteACargar);
            }
        }

        public Paquete Descargar()
        {
            Paquete paqueteADescargar = null;
            if(this.Ocupacion > 0)
            {
                paqueteADescargar = entregas.Peek();
            }
            return paqueteADescargar;
        }

        public bool TieneCapacidadDisponible()
        {
            if((this.Capacidad -  this.Ocupacion) > 0) return true;
            return false;
        }

    }

}
