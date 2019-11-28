﻿using System;
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
using System.Windows.Shapes;

namespace WpfApp2
{
    /// <summary>
    /// Lógica de interacción para Configuracion.xaml
    /// </summary>
    public partial class Configuracion : Window
    {
        public Configuracion()
        {
            InitializeComponent();
        }

        private void AceptarButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void CancelarButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            (this.Owner as MainWindow).Alto = int.Parse(AltoTextBox.Text);
            (this.Owner as MainWindow).Ancho = int.Parse(AnchoTextBox.Text);
        }
    }
}
