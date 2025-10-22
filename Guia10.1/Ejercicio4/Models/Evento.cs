using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4.Models
{
    public class Evento:IComparable<Evento>
    {
        public string Nombre { get; set; }
        public double Probabilidad { get; set; }

        public Evento(string nombre, double probabilidad)
        {
            this.Nombre = nombre;
            this.Probabilidad = probabilidad;
        }

        public int CompareTo(Evento obj)
        {
            if(obj != null) return this.Nombre.CompareTo(obj.Nombre);
            return -1;

        }

        public override string ToString() {
            return $"Evento:{this.Nombre} - Probabilidad:{this.Probabilidad}";
        }
    }
}
