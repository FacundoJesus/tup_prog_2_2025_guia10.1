using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2.Models
{
    public class CentroDeAtencion
    {
        private Queue<Reclamo> reclamosPendientes = new Queue<Reclamo>();
        private Queue<OrdenReparacion> trabajosPendientes = new Queue<OrdenReparacion> ();

        private int numeroReclamoGen = 1;

        public Reclamo RecibirReclamo(string nombrePersona, string motivo)
        {
            Reclamo reclamoRecibido = new Reclamo(numeroReclamoGen++,nombrePersona,motivo);

            reclamosPendientes.Enqueue(reclamoRecibido);

            return reclamoRecibido;
        }

        public OrdenReparacion ResolverReclamo()
        {
            OrdenReparacion orden= null;

            if(reclamosPendientes.Count > 0) {

                Reclamo reclamo = reclamosPendientes.Dequeue(); //Saco el reclamo de reclamos pendientes.

                orden = new OrdenReparacion(reclamo); // Creo la orden

                trabajosPendientes.Enqueue(orden); //Lo encolo a trabajos pendientes

                return orden;
            }

            return orden;
        }

        public OrdenReparacion EjecutarOrdenDeTrabajo()
        {
            OrdenReparacion orden = null;
            if(trabajosPendientes.Count > 0)
            {
                orden = trabajosPendientes.Dequeue();
            }
            return orden;
        }

    }
}
