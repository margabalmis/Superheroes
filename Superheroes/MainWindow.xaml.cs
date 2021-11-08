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

namespace Superheroes
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int numeroSuperheroe = 0;
        List<Superheroe> superLista;
        public MainWindow()
        {
            InitializeComponent();
            superLista = Superheroe.GetSamples();

            principalDockPanel.DataContext = superLista[numeroSuperheroe];

        }

        private void Siguiente(object sender, RoutedEventArgs e)
        {
            Button boton = (Button)sender;
            

            if (boton.Tag.Equals("siguiente") && (numeroSuperheroe<2))
            {
                numeroSuperheroe++;
                numeroImagenTextBlock.Text = (numeroSuperheroe+1) +"/3";
                principalDockPanel.DataContext = superLista[numeroSuperheroe];
            }
            else if(boton.Tag.Equals("atras") && (numeroSuperheroe > 0))
            {
                numeroSuperheroe--;
                numeroImagenTextBlock.Text = (numeroSuperheroe + 1)+ "/3";
                principalDockPanel.DataContext = superLista[numeroSuperheroe];
            }
                
        }
    }
}
