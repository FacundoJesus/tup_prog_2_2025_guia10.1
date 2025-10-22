using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4.libEstructuras
{
    public class ArbolBinario<T> where T : IComparable<T>
    {
        public Nodo<T> Raiz { get; set; }

        public ArbolBinario() { }

        public void Agregar(T valor, Nodo<T> padre = null)
        {
            Nodo<T> nuevoNodo = new Nodo<T>(valor);
            if (padre == null)
            {
                Raiz = nuevoNodo;
            }
            else
            {
                Nodo<T> buscado = BuscarNodo(valor);
                if (buscado == null)
                    padre.Hijos.Add(nuevoNodo);
            }
        }

        public Nodo<T> BuscarNodo(T valor)
        {
            if (Raiz != null)
            {
                if (Raiz.Valor.CompareTo(valor) == 0) return Raiz;
            }

            return BuscarNodo(valor, Raiz);
        }

        private Nodo<T> BuscarNodo(T valor, Nodo<T> nodo)
        {
            if (nodo == null) return null;

            foreach (var hijo in nodo.Hijos)
            {
                if (hijo.Valor.CompareTo(valor) == 0) return hijo;

                BuscarNodo(valor, hijo);
            }

            return null;
        }

        public List<T> ListarNodos(Nodo<T> nodo = null, int nivel = 0)
        {
            List<T> lista = new List<T>();

            if (nodo == null) return lista;

            lista.Add(nodo.Valor);

            foreach (var hijo in nodo.Hijos)
            {
                lista.AddRange(ListarNodos(hijo, nivel + 1).ToArray());
            }

            return lista;
        }

        public List<T> ListarNodosRama(T desde, T hasta)
        {
            var nA = BuscarNodo(desde);
            List<T> rama = new List<T>();

            ListarNodosRama(nA, hasta, rama);

            return rama;
        }

        public void ListarNodosRama(Nodo<T> nodo, T hasta, List<T> lista)
        {
            if (nodo == null) return;

            lista.Add(nodo.Valor);

            if (nodo.Valor.Equals(hasta) || nodo.Hijos.Count == 0)
            {
                return;
            }

            foreach (var hijo in nodo.Hijos)
            {
                List<T> rama = new List<T>();
                ListarNodosRama(hijo, hasta, rama);

                int idx = rama.BinarySearch(hasta);
                if (idx >= 0)
                {
                    lista.AddRange(rama.ToArray());
                    return;
                }
                ;
            }
        }
    }
}
