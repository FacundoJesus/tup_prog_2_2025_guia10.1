using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3.Models
{
    public class Movil : IComparable
    {
        public int Numero {  get; private set; }

        public Pedido Pasajero { get; set; }

        public Movil(int numero)
        {
            this.Numero = numero;
        }

        public int CompareTo(object obj)
        {
            Movil nuevoMovil = obj as Movil;
            if(nuevoMovil != null) {
                return this.Numero.CompareTo(nuevoMovil.Numero);
            }
            return -1;
        }

        public override string ToString() {
            return $"Movil Nro: {this.Numero}";
        }
    }
}
