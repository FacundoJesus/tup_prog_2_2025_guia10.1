using Ejercicio2.Models;

namespace Ejercicio2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        CentroDeAtencion centro = new CentroDeAtencion();

        private void btnRegistrarReclamo_Click(object sender, EventArgs e)
        {
            string nombre = tbNombre.Text;
            string motivo = tbMotivo.Text;

            Reclamo reclamo = centro.RecibirReclamo(nombre, motivo);

            lsbReclamos.Items.Add(reclamo);

            #region Limpio Campos
            tbNombre.Clear();
            tbMotivo.Clear();
            #endregion
        }

        private void btnCrearOrdenTrabajo_Click(object sender, EventArgs e)
        {
            OrdenReparacion orden = centro.ResolverReclamo();

            lsbReclamos.Items.Remove(orden.Reclamo);
            lsbOrdenesAEjecutar.Items.Add(orden);
        }

        private void btnEjecutarOrdenTrabajo_Click(object sender, EventArgs e)
        {
            OrdenReparacion orden = centro.EjecutarOrdenDeTrabajo();
            orden.Solucionado = true;
            lsbOrdenesAEjecutar.Items.Remove(orden);

            MessageBox.Show("Orden ejecutada!");
        }
    }
}
