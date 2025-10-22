using Ejercicio3.Models;

namespace Ejercicio3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        CentralTaxis central = new CentralTaxis();

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < central.CantidadMovilesDisponibles; i++)
            {
                lsbDisponibles.Items.Add(central.VerDisponible(i));
            }

        }
        private void btnAtender_Click(object sender, EventArgs e)
        {
            string telefono = tbTelefono.Text;
            string direccion = tbDireccion.Text;

            Pedido nuevoPedido = central.RecibirSolicitud(telefono, direccion);

            lsbPedidosEntrantes.Items.Add(nuevoPedido);

            #region Limpio Campos
            tbTelefono.Clear();
            tbDireccion.Clear();
            #endregion
        }

        private void btnAsignarCoche_Click(object sender, EventArgs e)
        {
            Movil movil = central.AsignarCoche();
            if (movil != null)
            {
                lsbDisponibles.Items.Remove(movil);
                lsbPedidosEntrantes.Items.Remove(movil.Pasajero);

                lsbOcupado.Items.Add(movil);
            }
            else
            {
                MessageBox.Show("No hay móviles disponibles.");
            }
        }

        private void btnLiberarCoche_Click(object sender, EventArgs e)
        {
            int nroMovil = Convert.ToInt32(nudNroV.Value);

            Movil movil = central.LiberarVehiculo(nroMovil);

            if(movil != null)
            {
                lsbOcupado.Items.Remove(movil);
                lsbDisponibles.Items.Add(movil);
            }
            else
            {
                MessageBox.Show("Movil inexistente.");
            }
        }
    }
}
