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
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window


    {



        public ObservableCollection<Produccion> Datos = new ObservableCollection<Produccion>();

        public MainWindow()
        {
            InitializeComponent();
            //Produccion serie1 = new Serie(); //polimorfismo 
            //((Serie)serie1).Temporada
            Serie serie1 = new Serie("terror", 3, "hola", "victor", "ujknjbhjnbjnb");
            Serie serie2 = new Serie("terror", 9999, "hola", "victor", "ujknjbhjnbjnb");
            Pelicula peli1 = new Pelicula("comedia", 1997, "la bella", "Di caprio", "una ecuela es atacada por un hada que se quiere hacer pasar por malefica");


            Datos.Add(serie1);
            Datos.Add(serie2);
            Datos.Add(peli1);



            //datos.Add(new Serie("3"));
            // datos.Add(new Serie (""));
            // datos.Add(new Produccion)




            lsttodo.ItemsSource = Datos;




        }

        private void Btneditar_Click(object sender, RoutedEventArgs e)
        {

           
            grid2.Children.Clear();

            btnletras1.Visibility = Visibility.Hidden;
            btnletras2.Visibility = Visibility.Hidden;
            btnordennum2.Visibility = Visibility.Hidden;
            btnordennum1.Visibility = Visibility.Hidden;

            grid2.Children.Add(new Agregar());
        }

        private void Lsttodo_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            /*if (lsttodo.SelectedIndex !=-1)
            {

            }
            lsttodo.Items.Refresh();*/
        }

        private void Btnguardarnuevo_Click(object sender, RoutedEventArgs e)
        {
            if (lsttodo.SelectedIndex != -1)
            {
                gridprincipal.Children.Clear();
                gridprincipal.Children.Add(new Agregar());
                // (((Agregar)(gridprincipal.Children)).txtaño.Text);
                //var hola= gridprincipal.Children.Add(new Agregar().txtaño.Text);


                ((Agregar)(gridprincipal.Children[0])).txtaño.Text = Datos[lsttodo.SelectedIndex].Titulo;

            }
            lsttodo.Items.Refresh();





        }

        private void Btnordennum1_Click(object sender, RoutedEventArgs e)
        {
            int gab, i, j;
            gab = Datos.Count / 2; //el numero de elementos entre dos


            while (gab > 0)
            {
                for (i = 0; i < Datos.Count; i++)
                {



                    //utilizar otra lista, y cuando se evaluen no se hace directo de la lista, si un valor/propiedad de la lsta.
                    if (gab + i < Datos.Count && Datos[i].Año > Datos[gab + i].Año)// un string no puede usar el <>
                    {
                        var temp = Datos[i];

                        Datos[i] = Datos[gab + i];

                        Datos[gab + i] = temp;//var, variable de tipo implicita

                    }


                }
                gab--; //restar uno 
            }
        }

        private void Btnletras1_Click(object sender, RoutedEventArgs e)
        {
            int gab, i, j;
            gab = Datos.Count / 2;

            while (gab < 0)
            {
                for (i = 0; i < Datos.Count; i++)
                {



                    //utilizar otra lista, y cuando se evaluen no se hace directo de la lista, si un valor/propiedad de la lsta.
                    if (gab + i > Datos.Count && Datos[i].Año > Datos[gab + i].Año)// un string no puede usar el <>
                    {
                        var temp = Datos[i];

                        Datos[i] = Datos[gab + i];

                        Datos[gab + i] = temp;//var, variable de tipo implicita

                    }


                }
                gab--; //restar uno 
            }

        }

        private void Lsttodo_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {
            if (lsttodo.SelectedIndex != -1)
            {
                grid2.Children.Clear();
                grid2.Children.Add(new visualizar());
                // (((Agregar)(gridprincipal.Children)).txtaño.Text);
                //var hola= gridprincipal.Children.Add(new Agregar().txtaño.Text);


                ((visualizar)(grid2.Children[0])).lbltitulo.Text = Datos[lsttodo.SelectedIndex].Titulo;
                ((visualizar)(grid2.Children[0])).lbldescripcion.Text = Datos[lsttodo.SelectedIndex].Sinopsis;
                ((visualizar)(grid2.Children[0])).lblproduccion.Text = Datos[lsttodo.SelectedIndex].Director;

                btnedicion.Visibility = Visibility.Visible;
                btncancelar_.Visibility = Visibility.Visible;
                btneditar.Visibility = Visibility.Visible;
            }
            lsttodo.Items.Refresh();

        }

        private void Btnedicion_Click(object sender, RoutedEventArgs e)
        {


            if (lsttodo.SelectedIndex != -1)
            {
                grid2.Children.Clear();
                grid2.Children.Add(new editar());
                // (((Agregar)(gridprincipal.Children)).txtaño.Text);
                //var hola= gridprincipal.Children.Add(new Agregar().txtaño.Text);


                ((editar)(grid2.Children[0])).txttitulo.Text = Datos[lsttodo.SelectedIndex].Titulo;
                ((editar)(grid2.Children[0])).txtdescripcion.Text = Datos[lsttodo.SelectedIndex].Sinopsis;
                ((editar)(grid2.Children[0])).txtproduccion.Text = Datos[lsttodo.SelectedIndex].Director;


            }
            lsttodo.Items.Refresh();


        }

        private void Btneliminar_Click(object sender, RoutedEventArgs e)


        {
            


            if (lsttodo.SelectedIndex != -1)
            {
               

                // (((Agregar)(gridprincipal.Children)).txtaño.Text);
                //var hola= gridprincipal.Children.Add(new Agregar().txtaño.Text);



                Datos[lsttodo.SelectedIndex].Titulo = ((editar)(grid2.Children[0])).txttitulo.Text;

                Datos[lsttodo.SelectedIndex].Año = ((editar)(grid2.Children[0])).txtaño.SelectionStart;
            }

        }

        private void Btnguardar_Click(object sender, RoutedEventArgs e)
        {

            //Datos.Add(new Serie((editar)(grid2.Children[0])));
            //Datos.Add(new Serie(Agregar)(grid2.Children[0])));


        }
    }
}
