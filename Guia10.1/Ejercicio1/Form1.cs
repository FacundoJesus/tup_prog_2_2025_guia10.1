using Ejercicio1.Models;

namespace Ejercicio1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Despachador centroDespachos = new Despachador();
        Repartidor camion;
        private void btnRecibirCorrespondencia_Click(object sender, EventArgs e)
        {
            int dni = Convert.ToInt32(tbDNI.Text);
            string nombre = tbNombre.Text;
            string direccion = tbDireccion.Text;

            Paquete nuevoPaquete = centroDespachos.RecibirCorrespondencia(dni, nombre, direccion);


            lsbVerSectorCarga.Items.Add(nuevoPaquete);

            #region Limpio Campos
            tbDNI.Clear();
            tbNombre.Clear();
            tbDireccion.Clear();
            #endregion
        }

        private void btnPrepararCamion_Click(object sender, EventArgs e)
        {
            FormDatoCamion formCamion = new FormDatoCamion();
            if (formCamion.ShowDialog() == DialogResult.OK)
            {

                int capacidadCamion = Convert.ToInt32(formCamion.nudCapacidad.Value);
                camion = centroDespachos.PrepararCamion(capacidadCamion);

                lsbListadoAEntregar.Items.Clear();

                Paquete paquete = null;
                do
                {
                    paquete = centroDespachos.CargarPaqueteAlCamion();

                    if (paquete != null)
                    {
                        lsbVerSectorCarga.Items.Remove(paquete); //Quitamos el paquete de la lista de embarque.

                        lsbListadoAEntregar.Items.Add(paquete); //Agregamos el paquete a la lista de entregas.
                    }
                } while (paquete != null);


            }
        }

        private void btnIniciarReparto_Click(object sender, EventArgs e)
        {
            if (camion != null)
            {
                Paquete paquete = camion.Revisar();

                btnEntregarPaquete.Enabled = true;
                if (paquete != null)
                {
                    lbDNIEntrega.Text = Convert.ToString(paquete.DNIRemitente);
                    lbNombreEntrega.Text = paquete.NombreRemitente;
                    lbDireccionEntrega.Text = paquete.Direccion;

                    btnIniciarReparto.Enabled = false;
                }
            }
            else
            {
                MessageBox.Show("Debes Preparar el camión");
            }
        }

        private void btnEntregarPaquete_Click(object sender, EventArgs e)
        {
            Paquete paquete = camion.Descargar();

            lsbListadoAEntregar.Items.Remove(paquete);

            paquete = camion.Revisar();

            if(paquete != null) {
                lbDNIEntrega.Text = Convert.ToString(paquete.DNIRemitente);
                lbNombreEntrega.Text = paquete.NombreRemitente;
                lbDireccionEntrega.Text = paquete.Direccion;
            }
            else
            {
                lbDNIEntrega.Text = "".PadRight(10, ' ');
                lbNombreEntrega.Text = "".PadRight(10, ' ');
                lbDireccionEntrega.Text = "".PadRight(10, ' ');

                btnIniciarReparto.Enabled = true;
                btnEntregarPaquete.Enabled = false;
            }
        }
    }
}
