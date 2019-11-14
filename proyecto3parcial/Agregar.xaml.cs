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
using System.Collections.ObjectModel;




namespace proyecto3parcial
{
    /// <summary>
    /// Lógica de interacción para Agregar.xaml
    /// </summary>
    public partial class Agregar : UserControl
    {
        

        public Agregar()
        {
            InitializeComponent();
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void Btnguardarnuevo_Click(object sender, RoutedEventArgs e)
        {
          


        }

        private void Rbpelicula_Checked(object sender, RoutedEventArgs e)
        {
            lbldirector.Visibility = Visibility.Visible;
            txtdirector.Visibility = Visibility.Visible;

            lblproducciones.Visibility = Visibility.Hidden;
            txttemporadas.Visibility = Visibility.Hidden;
            txtproduccion.Visibility = Visibility.Hidden;
            lbtemporadas_.Visibility = Visibility.Hidden;
        }

        private void Rbserie_Checked(object sender, RoutedEventArgs e)
        {
            lbldirector.Visibility = Visibility.Hidden;
            txtdirector.Visibility = Visibility.Hidden;

            lblproducciones.Visibility = Visibility.Visible;
            txttemporadas.Visibility = Visibility.Visible;
            txtproduccion.Visibility = Visibility.Visible;
            lbtemporadas_.Visibility = Visibility.Visible;
        }
    }
}
