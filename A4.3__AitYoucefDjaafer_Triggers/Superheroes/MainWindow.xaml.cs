using Superheroes.Services;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Superheroes
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<Superheroe> lista;
        private int indiceActual = 0;
        public Superheroe PersonajeActual { get; set; }

        public MainWindow()
        {
            InitializeComponent();
            lista = DataService.GetSamples();
            ActualizarVista();
        }

        private void ClickSiguiente(object sender, RoutedEventArgs e)
        {
            if (indiceActual < lista.Count - 1)
            {
                indiceActual++;
                ActualizarVista();
            }
        }

        private void ClickAnterior(object sender, RoutedEventArgs e)
        {
            if (indiceActual > 0)
            {
                indiceActual--;
                ActualizarVista();
            }
        }

        private void ActualizarVista()
        {
            PersonajeActual = lista[indiceActual];
            DataContext = PersonajeActual;
            ContadorTextBlock.Text = $"{indiceActual + 1}/{lista.Count}";
        }
    }
}