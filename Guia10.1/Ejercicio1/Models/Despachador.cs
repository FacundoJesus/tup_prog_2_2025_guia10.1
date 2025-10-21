using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1.Models
{
    public class Despachador
    {
        private Queue<Paquete> deposito = new Queue<Paquete>();
        private Repartidor camion;

        public Paquete RecibirCorrespondencia(int dni, string nombre, string direccion)
        {
            Paquete nuevoPaquete = new Paquete(dni, nombre, direccion);
            deposito.Enqueue(nuevoPaquete);
            return nuevoPaquete;
        }

        public Repartidor PrepararCamion(int capacidad)
        {
            camion = new Repartidor(capacidad);
            return camion;
        }

        public Paquete CargarPaqueteAlCamion()
        {
            Paquete paqueteSacadodelDeposito = null;
            if(camion.TieneCapacidadDisponible()==true && deposito.Count > 0)
            {
                paqueteSacadodelDeposito = deposito.Dequeue();
                camion.Cargar(paqueteSacadodelDeposito);
            }
            return paqueteSacadodelDeposito;
        }

    }
}
