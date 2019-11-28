using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp2
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        private int alto;

        public int Alto
        {
            get { return alto; }
            set { alto = value; }
        }

        private int ancho;

        public int Ancho
        {
            get { return ancho; }
            set { ancho = value; }
        }


        NuevoDoc nuevoDoc;
        Configuracion ventanaConfig;

        public MainWindow()
        {
            InitializeComponent();
            alto = 500;
            ancho = 500;
        }

        private void NuevoDocumentoButton_Click(object sender, RoutedEventArgs e)
        {
            nuevoDoc = new NuevoDoc();
            nuevoDoc.Owner = this;
            nuevoDoc.Title = "Documento " + this.OwnedWindows.Count;
            nuevoDoc.Width = ancho;
            nuevoDoc.Height = alto;
            nuevoDoc.Show();
        }

        private void ConfiguracionButton_Click(object sender, RoutedEventArgs e)
        {
            ventanaConfig = new Configuracion();

            ventanaConfig.Owner = this;
            if (nuevoDoc != null)
            {
                ventanaConfig.AnchoTextBox.Text = nuevoDoc.Width.ToString();
                ventanaConfig.AltoTextBox.Text = nuevoDoc.Height.ToString();
            }
            else {

                ventanaConfig.AnchoTextBox.Text = "500";
                ventanaConfig.AltoTextBox.Text = "500";
            }
            ventanaConfig.ShowDialog();
        }
    }
}
