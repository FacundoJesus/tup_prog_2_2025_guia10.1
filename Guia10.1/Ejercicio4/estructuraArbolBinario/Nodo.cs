using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4.libEstructuras
{
    public class Nodo<T>
    {
        public T Valor { get; set; }
        public List<Nodo<T>> Hijos { get; set; }

        public Nodo(T valor)
        {
            Valor = valor;
            Hijos = new List<Nodo<T>>();
        }
    }
}
