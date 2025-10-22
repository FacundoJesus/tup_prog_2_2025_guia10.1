using Ejercicio4.Models;

namespace Ejercicio4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Estadistica estadistica = new Estadistica();

        private void Form1_Load(object sender, EventArgs e)
        {
            cb1erEvento.Items.AddRange(estadistica.ListaEventos().ToArray());
            cb2doEvento.Items.AddRange(estadistica.ListaEventos().ToArray());
        }

        private void btnMostrarNodos_Click(object sender, EventArgs e)
        {
            lsbResultado.Items.Clear();
            foreach (Evento evento in estadistica.ListaEventos())
            {
                lsbResultado.Items.Add(evento);
            }
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            Evento evento1 = cb1erEvento.SelectedItem as Evento;
            Evento evento2 = cb2doEvento.SelectedItem as Evento;

            lsbResultado.Items.Clear();
            foreach (Evento evento in estadistica.ListaEventos(evento1, evento2))
            {
                lsbResultado.Items.Add(evento);
            }
            lbResultado.Text = estadistica.ProbabilidadEvento2DadoEvento1(evento1, evento2).ToString("0.00");
        }
    }
    
}
