using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3.Models
{
    public class CentralTaxis
    {
        private Queue<Movil> movilesDisponibles = new Queue<Movil>();
        private LinkedList<Movil> movilesOcupados = new LinkedList<Movil>();

        private Queue<Pedido> pedidos = new Queue<Pedido>();
        
        public int CantidadMovilesDisponibles { get { return movilesDisponibles.Count; } }

        public CentralTaxis()
        {
            #region Inicio la Empresa con 10 vehiculos
            for(int i = 1;i < 11;i++)
            {
                movilesDisponibles.Enqueue(new Movil(i));
            }
            #endregion
        }

        public Movil VerDisponible(int idx)
        {
            Movil movilDisponible = null;
            if(idx >= 0 && idx < CantidadMovilesDisponibles) {
                movilDisponible = movilesDisponibles.ToArray()[idx];
            }
            return movilDisponible;
        }

        public Pedido RecibirSolicitud(string telefono, string direccion)
        {
            Pedido nuevoPedido = new Pedido(telefono,direccion);
            pedidos.Enqueue(nuevoPedido);
            return nuevoPedido;
        }

        public Movil AsignarCoche()
        {
            if (movilesDisponibles.Count > 0 && pedidos.Count > 0)
            {
                Movil disponible = movilesDisponibles.Dequeue();
                Pedido pedido = pedidos.Dequeue();

                disponible.Pasajero = pedido;

                movilesOcupados.AddLast(disponible);
                return disponible;
            }
            return null;
        }

        public Movil LiberarVehiculo(int numero)
        {
            Movil movilLibre = null;

            LinkedListNode<Movil> nodo = movilesOcupados.First;
            while (nodo != null && movilLibre == null)
            {
                if (nodo.Value.Numero == numero)
                {
                    movilLibre = nodo.Value;
                }
                nodo = nodo.Next;
            }

            if (movilLibre != null)
            {
                movilLibre.Pasajero = null;
                movilesDisponibles.Enqueue(movilLibre);
                movilesOcupados.Remove(movilLibre);
            }

            return movilLibre;
        }

    }
}
