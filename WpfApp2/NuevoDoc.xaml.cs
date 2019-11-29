using System;
using System.Collections.Generic;
using System.IO;
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
using System.Windows.Shapes;

namespace WpfApp2
{
    /// <summary>
    /// Lógica de interacción para NuevoDoc.xaml
    /// </summary>
    public partial class NuevoDoc : Window
    {
        public NuevoDoc()
        {
            InitializeComponent();
        }

        private void GuardarButton_Click(object sender, RoutedEventArgs e)
        {
            Microsoft.Win32.SaveFileDialog saveFileDialog = new Microsoft.Win32.SaveFileDialog();
            saveFileDialog.Filter = "Archivos de texto|*.txt";

            if (saveFileDialog.ShowDialog() == true)
            {
                string rutaFichero = saveFileDialog.FileName;

                if (rutaFichero != "")
                    File.WriteAllText(rutaFichero, DocumentoTextBox.Text, Encoding.UTF8);


            }
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("¿Seguro que quieres cerrar?", "Cerrar", MessageBoxButton.YesNo, MessageBoxImage.Information);

            if (result == MessageBoxResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
