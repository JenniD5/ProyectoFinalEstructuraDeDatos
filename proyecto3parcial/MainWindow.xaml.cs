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
            Serie serie1 = new Serie("Aventura", 3, "hola", "victor", "ujknjbhjnbjnb", "1", 5, "serie");
            Serie serie2 = new Serie("Aventura", 3, "sferfe", "efrefref", "refref", "3", 4, "serie");
            Serie serie3 = new Serie("Aventura", 8, "sferfe", "efrefref", "refref", "2", 3, "serie");
            Serie seriebase = new Serie("Aventura", 9, "huji", "hifhighf", "bhhvbhf", "1", 0, "serie");
            //Pelicula peli1 = new Pelicula("comedia", 1997, "la bella", "Di caprio", "una ecuela es atacada por un hada que se quiere hacer pasar por malefica", 1, "pelicula");
            Pelicula peli2 = new Pelicula("Aventura", 9990, "la bella durmiente", "Victor", "njlkhjhlkjjhj", 1, "pelicula");

            Datos.Add(serie1);
            Datos.Add(serie2);
            Datos.Add(peli2);
            Datos.Add(serie3);
            Datos.Add(seriebase);





            //datos.Add(new Serie("3"));
            // datos.Add(new Serie (""));
            // datos.Add(new Produccion)




            lsttodo.ItemsSource = Datos;




        }

        private void Btneditar_Click(object sender, RoutedEventArgs e)
        {
            btncancelar_.Visibility = Visibility.Hidden;
            btneliminar.Visibility = Visibility.Hidden;
            btnguardar.Visibility = Visibility.Hidden;
            btnedicion.Visibility = Visibility.Hidden;


            _3estrellas.Visibility = Visibility.Hidden;
            _4estrellas.Visibility = Visibility.Hidden;
            _5estrellas.Visibility = Visibility.Hidden;
            btnnuevoagregar.Visibility = Visibility.Visible;
            btncancelarnuevo.Visibility = Visibility.Visible;
            grid2.Children.Clear();

            btnletras1.Visibility = Visibility.Hidden;
            btnletras2.Visibility = Visibility.Hidden;
            btnordennum2.Visibility = Visibility.Hidden;
            btnordennum1.Visibility = Visibility.Hidden;
            _4estrellas.Visibility = Visibility.Hidden;
            _5estrellas.Visibility = Visibility.Hidden;
            _3estrellas.Visibility = Visibility.Hidden;
            _2estrellas.Visibility = Visibility.Hidden;
            _1estrellas.Visibility = Visibility.Hidden;
            _0estrellas.Visibility = Visibility.Hidden;
            btneditar.Visibility = Visibility.Hidden;


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
            btnnuevoagregar.Visibility = Visibility.Hidden;
            if (lsttodo.SelectedIndex != -1)
            {
                grid2.Children.Clear();
                grid2.Children.Add(new Agregar());





            }
            lsttodo.Items.Refresh();





        }

        private void Btnordennum1_Click(object sender, RoutedEventArgs e)
        {
            btnedicion.Visibility = Visibility.Hidden;
            btncancelar_.Visibility = Visibility.Hidden;
            btneliminar.Visibility = Visibility.Hidden;
            btnguardar.Visibility = Visibility.Hidden;

            

            //btnnuevoagregar.Visibility = Visibility.Hidden;
            int gab, i;
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
            btnedicion.Visibility = Visibility.Hidden;
            btncancelar_.Visibility = Visibility.Hidden;
            btneliminar.Visibility = Visibility.Hidden;
            btnguardar.Visibility = Visibility.Hidden;

            btnletras1.Visibility = Visibility.Visible;
            btnletras2.Visibility = Visibility.Visible;
            btneditar.Visibility = Visibility.Visible;
            btnordennum1.Visibility = Visibility.Visible;
            btnordennum2.Visibility = Visibility.Visible;

        }

        private void Btnletras1_Click(object sender, RoutedEventArgs e)
        {
            _0estrellas.Visibility = Visibility.Hidden;
            _1estrellas.Visibility = Visibility.Hidden;
            _2estrellas.Visibility = Visibility.Hidden;
            _3estrellas.Visibility = Visibility.Hidden;
            _4estrellas.Visibility = Visibility.Hidden;
            _5estrellas.Visibility = Visibility.Hidden;

            bool intercambio = false;


            do
            {

                intercambio = false;
                for (int i = 0; i < Datos.Count - 1; i++) //i++ para modificar el valor de la i, peor solo se le quiere sumar 1
                {

                    if (string.Compare(Datos[i].Titulo, Datos[i + 1].Titulo) > 0)
                    {
                        var temp = Datos[i];
                        Datos[i] = Datos[i + 1];
                        Datos[i + 1] = temp;
                        intercambio = true;
                    }


                }

            } while (intercambio);

        }

        private void Lsttodo_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {
            btnletras1.Visibility = Visibility.Hidden;
            btnletras2.Visibility = Visibility.Hidden;
            btnordennum1.Visibility = Visibility.Hidden;
            btnordennum2.Visibility = Visibility.Hidden;
            btnnuevoagregar.Visibility = Visibility.Hidden;
            btneditar.Visibility = Visibility.Hidden;

            btnedicion.Visibility = Visibility.Visible;
            btncancelar_.Visibility = Visibility.Visible;
            btneliminar.Visibility = Visibility.Visible;
            btnguardar.Visibility = Visibility.Hidden;

            if (lsttodo.SelectedIndex != -1) //hacer lo mismo pero para el interfaz de pelicula, solo cambiar lo que dicen los elementos, los puros nombres. 
            {
                if (Datos[lsttodo.SelectedIndex].Tipo == "serie")
                {
                    grid2.Children.Clear();
                    grid2.Children.Add(new visualizar());

                    ((visualizar)(grid2.Children[0])).lbltipo.Text = Datos[lsttodo.SelectedIndex].Tipo;
                    ((visualizar)(grid2.Children[0])).lbltitulo.Text = Datos[lsttodo.SelectedIndex].Titulo;
                    ((visualizar)(grid2.Children[0])).lbldescripcion.Text = Datos[lsttodo.SelectedIndex].Sinopsis;
                    ((visualizar)(grid2.Children[0])).lblproduccion.Text = Datos[lsttodo.SelectedIndex].Director;
                    ((visualizar)(grid2.Children[0])).lbltemporadas.Text = Datos[lsttodo.SelectedIndex].Temporadas;
                    ((visualizar)(grid2.Children[0])).lblgenero.Text = Datos[lsttodo.SelectedIndex].Genero;
                    var año2 = Datos[lsttodo.SelectedIndex].Año.ToString();
                    ((visualizar)(grid2.Children[0])).lblaño.Text = año2;
                    btneditar.Visibility = Visibility.Hidden;


                    if (Datos[lsttodo.SelectedIndex].Rating == 5)
                    {
                        _0estrellas.Visibility = Visibility.Hidden;
                        _1estrellas.Visibility = Visibility.Hidden;
                        _5estrellas.Visibility = Visibility.Visible;
                        _4estrellas.Visibility = Visibility.Hidden;
                        _3estrellas.Visibility = Visibility.Hidden;
                        _2estrellas.Visibility = Visibility.Hidden;
                    }
                    if (Datos[lsttodo.SelectedIndex].Rating == 4)
                    {
                        _0estrellas.Visibility = Visibility.Hidden;
                        _1estrellas.Visibility = Visibility.Hidden;
                        _4estrellas.Visibility = Visibility.Visible;
                        _5estrellas.Visibility = Visibility.Hidden;
                        _3estrellas.Visibility = Visibility.Hidden;
                        _2estrellas.Visibility = Visibility.Hidden;
                    }
                    if (Datos[lsttodo.SelectedIndex].Rating == 3)
                    {
                        _0estrellas.Visibility = Visibility.Hidden;
                        _4estrellas.Visibility = Visibility.Hidden;
                        _5estrellas.Visibility = Visibility.Hidden;
                        _3estrellas.Visibility = Visibility.Visible;
                        _2estrellas.Visibility = Visibility.Hidden;
                        _1estrellas.Visibility = Visibility.Hidden;
                    }
                    if (Datos[lsttodo.SelectedIndex].Rating == 2)
                    {
                        _0estrellas.Visibility = Visibility.Hidden;
                        _1estrellas.Visibility = Visibility.Hidden;
                        _4estrellas.Visibility = Visibility.Hidden;
                        _5estrellas.Visibility = Visibility.Hidden;
                        _2estrellas.Visibility = Visibility.Visible;
                        _3estrellas.Visibility = Visibility.Hidden;
                    }
                    if (Datos[lsttodo.SelectedIndex].Rating == 1)
                    {
                        _0estrellas.Visibility = Visibility.Hidden;
                        _2estrellas.Visibility = Visibility.Hidden;
                        _4estrellas.Visibility = Visibility.Hidden;
                        _5estrellas.Visibility = Visibility.Hidden;
                        _1estrellas.Visibility = Visibility.Visible;
                        _3estrellas.Visibility = Visibility.Hidden;
                    }
                    if (Datos[lsttodo.SelectedIndex].Rating == 0)
                    {
                        _1estrellas.Visibility = Visibility.Hidden;
                        _2estrellas.Visibility = Visibility.Hidden;
                        _4estrellas.Visibility = Visibility.Hidden;
                        _5estrellas.Visibility = Visibility.Hidden;
                        _0estrellas.Visibility = Visibility.Visible;
                        _3estrellas.Visibility = Visibility.Hidden;
                    }




                }
            }
            lsttodo.Items.Refresh();


            if (lsttodo.SelectedIndex != -1)                    //gacer lo mismo pero para el interfaz de pelicula, solo cambiar lo que dicen los elementos, los puros nombres. 
            {
                if (Datos[lsttodo.SelectedIndex].Tipo == "pelicula")
                {
                    grid2.Children.Clear();
                    grid2.Children.Add(new verpeli());
                    ((verpeli)(grid2.Children[0])).lbltitulo.Text = Datos[lsttodo.SelectedIndex].Titulo;
                    ((verpeli)(grid2.Children[0])).lbltipo.Text = Datos[lsttodo.SelectedIndex].Tipo;
                    ((verpeli)(grid2.Children[0])).lbldescripcion.Text = Datos[lsttodo.SelectedIndex].Sinopsis;
                    ((verpeli)(grid2.Children[0])).lblproduccion.Text = Datos[lsttodo.SelectedIndex].Director;
                    ((verpeli)(grid2.Children[0])).lblgenero.Text = Datos[lsttodo.SelectedIndex].Genero;
                    var año2 = Datos[lsttodo.SelectedIndex].Año.ToString();
                    ((verpeli)(grid2.Children[0])).lblaño.Text = año2;
                    btneditar.Visibility = Visibility.Hidden;


                    if (Datos[lsttodo.SelectedIndex].Rating == 5)
                    {
                        _0estrellas.Visibility = Visibility.Hidden;
                        _3estrellas.Visibility = Visibility.Hidden;
                        _5estrellas.Visibility = Visibility.Visible;
                        _4estrellas.Visibility = Visibility.Hidden;
                        _2estrellas.Visibility = Visibility.Hidden;
                        _1estrellas.Visibility = Visibility.Hidden;
                    }
                    if (Datos[lsttodo.SelectedIndex].Rating == 4)
                    {
                        _0estrellas.Visibility = Visibility.Hidden;
                        _3estrellas.Visibility = Visibility.Hidden;
                        _4estrellas.Visibility = Visibility.Visible;
                        _5estrellas.Visibility = Visibility.Hidden;
                        _2estrellas.Visibility = Visibility.Hidden;
                        _1estrellas.Visibility = Visibility.Hidden;
                    }
                    if (Datos[lsttodo.SelectedIndex].Rating == 3)
                    {
                        _0estrellas.Visibility = Visibility.Hidden;
                        _3estrellas.Visibility = Visibility.Visible;
                        _4estrellas.Visibility = Visibility.Hidden;
                        _5estrellas.Visibility = Visibility.Hidden;
                        _2estrellas.Visibility = Visibility.Hidden;
                        _1estrellas.Visibility = Visibility.Hidden;
                    }
                    if (Datos[lsttodo.SelectedIndex].Rating == 2)
                    {
                        _0estrellas.Visibility = Visibility.Hidden;
                        _2estrellas.Visibility = Visibility.Visible;
                        _4estrellas.Visibility = Visibility.Hidden;
                        _5estrellas.Visibility = Visibility.Hidden;
                        _3estrellas.Visibility = Visibility.Hidden;
                        _1estrellas.Visibility = Visibility.Hidden;
                    }
                    if (Datos[lsttodo.SelectedIndex].Rating == 1)
                    {
                        _0estrellas.Visibility = Visibility.Hidden;
                        _1estrellas.Visibility = Visibility.Visible;
                        _2estrellas.Visibility = Visibility.Hidden;
                        _4estrellas.Visibility = Visibility.Hidden;
                        _5estrellas.Visibility = Visibility.Hidden;
                        _3estrellas.Visibility = Visibility.Hidden;
                    }
                    if (Datos[lsttodo.SelectedIndex].Rating == 0)
                    {
                        _1estrellas.Visibility = Visibility.Hidden;
                        _0estrellas.Visibility = Visibility.Visible;
                        _2estrellas.Visibility = Visibility.Hidden;
                        _4estrellas.Visibility = Visibility.Hidden;
                        _5estrellas.Visibility = Visibility.Hidden;
                        _3estrellas.Visibility = Visibility.Hidden;
                    }


                    btnedicion.Visibility = Visibility.Visible;
                    btncancelar_.Visibility = Visibility.Visible;
                    btneditar.Visibility = Visibility.Visible;
                    btnnuevoagregar.Visibility = Visibility.Hidden;
                    btneditar.Visibility = Visibility.Hidden;
                }
            }
            lsttodo.Items.Refresh();


        }

        private void Btnedicion_Click(object sender, RoutedEventArgs e)
        {


            if (lsttodo.SelectedIndex != -1)
            {
                if (Datos[lsttodo.SelectedIndex].Tipo == "serie")
                {

                    grid2.Children.Clear();
                    grid2.Children.Add(new editar());
                    // (((Agregar)(gridprincipal.Children)).txtaño.Text);
                    //var hola= gridprincipal.Children.Add(new Agregar().txtaño.Text);
                    /* Serie seri = Datos as Serie;
                     if(Datos == Pelicula)
                     {
                         grid2.Children.Clear();
                         grid2.Children.Add(new editar());
                     }*/
                    ((editar)(grid2.Children[0])).lblnombre.Text = Datos[lsttodo.SelectedIndex].Tipo;
                    ((editar)(grid2.Children[0])).txttitulo.Text = Datos[lsttodo.SelectedIndex].Titulo;
                    ((editar)(grid2.Children[0])).txtdescripcion.Text = Datos[lsttodo.SelectedIndex].Sinopsis;
                    ((editar)(grid2.Children[0])).txtproduccion.Text = Datos[lsttodo.SelectedIndex].Director;
                    ((editar)(grid2.Children[0])).lbtemporadas_.Text = Datos[lsttodo.SelectedIndex].Temporadas;
                    ((editar)(grid2.Children[0])).lbgenero.Text = Datos[lsttodo.SelectedIndex].Genero;
                    var rating = Datos[lsttodo.SelectedIndex].Rating.ToString();
                    ((editar)(grid2.Children[0])).rant.Text = rating;
                    var años = Datos[lsttodo.SelectedIndex].Año.ToString();
                    ((editar)(grid2.Children[0])).txtaño.Text = años;
                    _4estrellas.Visibility = Visibility.Hidden;
                    _5estrellas.Visibility = Visibility.Hidden;
                    _3estrellas.Visibility = Visibility.Hidden;
                    _2estrellas.Visibility = Visibility.Hidden;
                    _1estrellas.Visibility = Visibility.Hidden;
                    _0estrellas.Visibility = Visibility.Hidden;


                    btnnuevoagregar.Visibility = Visibility.Hidden;


                }
                lsttodo.Items.Refresh();

            

            if (Datos[lsttodo.SelectedIndex].Tipo == "pelicula")
            {

                grid2.Children.Clear();
                grid2.Children.Add(new editarpeli());
                // (((Agregar)(gridprincipal.Children)).txtaño.Text);
                //var hola= gridprincipal.Children.Add(new Agregar().txtaño.Text);
                /* Serie seri = Datos as Serie;
                 if(Datos == Pelicula)
                 {
                     grid2.Children.Clear();
                     grid2.Children.Add(new editar());
                 }*/
                ((editarpeli)(grid2.Children[0])).txttitulo.Text = Datos[lsttodo.SelectedIndex].Titulo;

                ((editarpeli)(grid2.Children[0])).lblnombre.Text = Datos[lsttodo.SelectedIndex].Tipo;
                ((editarpeli)(grid2.Children[0])).txtdescripcion.Text = Datos[lsttodo.SelectedIndex].Sinopsis;
                ((editarpeli)(grid2.Children[0])).txtproduccion.Text = Datos[lsttodo.SelectedIndex].Director;
                ((editarpeli)(grid2.Children[0])).lbgenero.Text = Datos[lsttodo.SelectedIndex].Genero;

                    var rating = Datos[lsttodo.SelectedIndex].Rating.ToString();
                ((editarpeli)(grid2.Children[0])).rant.Text = rating;
                var años = Datos[lsttodo.SelectedIndex].Año.ToString();
                ((editarpeli)(grid2.Children[0])).txtaño.Text = años;
                _4estrellas.Visibility = Visibility.Hidden;
                _5estrellas.Visibility = Visibility.Hidden;
                _3estrellas.Visibility = Visibility.Hidden;
                _2estrellas.Visibility = Visibility.Hidden;
                _1estrellas.Visibility = Visibility.Hidden;
                _0estrellas.Visibility = Visibility.Hidden;

                    btnnuevoagregar.Visibility = Visibility.Hidden;


            }
            lsttodo.Items.Refresh();

            btnedicion.Visibility = Visibility.Hidden;
            btnguardar.Visibility = Visibility.Visible;
            btncancelar_.Visibility = Visibility.Visible;
            btneliminar.Visibility = Visibility.Visible;
        }
    }
        

        private void Btneliminar_Click(object sender, RoutedEventArgs e)


        {



            if (lsttodo.SelectedIndex != -1)
            {


                // (((Agregar)(gridprincipal.Children)).txtaño.Text);
                //var hola= gridprincipal.Children.Add(new Agregar().txtaño.Text);


                Datos.RemoveAt(lsttodo.SelectedIndex);
                _4estrellas.Visibility = Visibility.Hidden;
                _5estrellas.Visibility = Visibility.Hidden;
                _3estrellas.Visibility = Visibility.Hidden;
                _2estrellas.Visibility = Visibility.Hidden;
                _1estrellas.Visibility = Visibility.Hidden;
                _0estrellas.Visibility = Visibility.Hidden;
                btnnuevoagregar.Visibility = Visibility.Hidden;
                //Datos[lsttodo.SelectedIndex].Año = ((editar)(grid2.Children[0])).txtaño.SelectionStart;
            }

            grid2.Children.Clear();
            btnedicion.Visibility = Visibility.Hidden;
          
            btnguardar.Visibility = Visibility.Hidden;
            btncancelar_.Visibility = Visibility.Hidden;
            btneditar.Visibility = Visibility.Visible;
            btnletras1.Visibility = Visibility.Visible;
            btnletras2.Visibility = Visibility.Visible;
            btnordennum1.Visibility = Visibility.Visible;
            btnordennum2.Visibility = Visibility.Visible;
            btneliminar.Visibility = Visibility.Hidden;


        }

        private void Btnguardar_Click(object sender, RoutedEventArgs e)
        {
            //grid2.Children.Clear();
            btncancelar_.Visibility = Visibility.Hidden;
            btnedicion.Visibility = Visibility.Hidden;
            btneditar.Visibility = Visibility.Visible;
            btneliminar.Visibility = Visibility.Hidden;
           
            btnnuevoagregar.Visibility = Visibility.Hidden;
            btnletras1.Visibility = Visibility.Visible;
            btnletras2.Visibility = Visibility.Visible;
            btnordennum1.Visibility = Visibility.Visible;
            btnordennum2.Visibility = Visibility.Visible;

            if (Datos[lsttodo.SelectedIndex].Tipo == "serie")
            {
               
                grid2.Children.Add(new editar());

                if (string.IsNullOrEmpty((((editar)(grid2.Children[0])).txttitulo.Text)))
                {
                    txtdesaparecer.Visibility = Visibility.Visible;
                    btnnuevoagregar.Visibility = Visibility.Visible;
                    btnordennum1.Visibility = Visibility.Hidden;
                    btnordennum2.Visibility = Visibility.Hidden;
                    btnletras1.Visibility = Visibility.Hidden;
                    btnletras2.Visibility = Visibility.Hidden;
                    btneditar.Visibility = Visibility.Hidden;
                    btnguardar.Visibility = Visibility.Visible;
                    btncancelar_.Visibility = Visibility.Visible;
                    btneliminar.Visibility = Visibility.Visible;
                    btnnuevoagregar.Visibility = Visibility.Hidden;
                    grid2.Children.Clear();
                    grid2.Children.Add(new editar());
                    ((editar)(grid2.Children[0])).lblnombre.Text = Datos[lsttodo.SelectedIndex].Tipo;
                    ((editar)(grid2.Children[0])).txttitulo.Text = "";
                    ((editar)(grid2.Children[0])).txtdescripcion.Text = Datos[lsttodo.SelectedIndex].Sinopsis;
                    ((editar)(grid2.Children[0])).txtproduccion.Text = Datos[lsttodo.SelectedIndex].Director;
                    ((editar)(grid2.Children[0])).lbtemporadas_.Text = Datos[lsttodo.SelectedIndex].Temporadas;
                    ((editar)(grid2.Children[0])).lbgenero.Text = Datos[lsttodo.SelectedIndex].Genero;
                    var rating = Datos[lsttodo.SelectedIndex].Rating.ToString();
                    ((editar)(grid2.Children[0])).rant.Text = rating;
                    var años = Datos[lsttodo.SelectedIndex].Año.ToString();
                    ((editar)(grid2.Children[0])).txtaño.Text = años;
                    


                    return;
                }
                
                else if (string.IsNullOrEmpty((((editar)(grid2.Children[0])).txtproduccion.Text)))
                {
                    txtdesaparecer.Visibility = Visibility.Visible;
                    btnnuevoagregar.Visibility = Visibility.Visible;
                    btnordennum1.Visibility = Visibility.Hidden;
                    btnordennum2.Visibility = Visibility.Hidden;
                    btnletras1.Visibility = Visibility.Hidden;
                    btnletras2.Visibility = Visibility.Hidden;
                    btneditar.Visibility = Visibility.Hidden;
                    btnguardar.Visibility = Visibility.Visible;
                    btncancelar_.Visibility = Visibility.Visible;
                    btneliminar.Visibility = Visibility.Visible;
                    btnnuevoagregar.Visibility = Visibility.Hidden;
                    grid2.Children.Clear();
                    grid2.Children.Add(new editar());
                    ((editar)(grid2.Children[0])).lblnombre.Text = Datos[lsttodo.SelectedIndex].Tipo;
                    ((editar)(grid2.Children[0])).txttitulo.Text = Datos[lsttodo.SelectedIndex].Titulo;
                    ((editar)(grid2.Children[0])).txtdescripcion.Text = Datos[lsttodo.SelectedIndex].Sinopsis;
                    ((editar)(grid2.Children[0])).txtproduccion.Text = "";
                    ((editar)(grid2.Children[0])).lbtemporadas_.Text = Datos[lsttodo.SelectedIndex].Temporadas;
                    ((editar)(grid2.Children[0])).lbgenero.Text = Datos[lsttodo.SelectedIndex].Genero;
                    var rating = Datos[lsttodo.SelectedIndex].Rating.ToString();
                    ((editar)(grid2.Children[0])).rant.Text = rating;
                    var años = Datos[lsttodo.SelectedIndex].Año.ToString();
                    ((editar)(grid2.Children[0])).txtaño.Text = años;

                    return;
                }
                
                else if (string.IsNullOrEmpty((((editar)(grid2.Children[0])).txtdescripcion.Text)))
                {
                    txtdesaparecer.Visibility = Visibility.Visible;
                    btnnuevoagregar.Visibility = Visibility.Visible;
                    btnordennum1.Visibility = Visibility.Hidden;
                    btnordennum2.Visibility = Visibility.Hidden;
                    btnletras1.Visibility = Visibility.Hidden;
                    btnletras2.Visibility = Visibility.Hidden;
                    btneditar.Visibility = Visibility.Hidden;
                    btnguardar.Visibility = Visibility.Visible;
                    btncancelar_.Visibility = Visibility.Visible;
                    btneliminar.Visibility = Visibility.Visible;
                    btnnuevoagregar.Visibility = Visibility.Hidden;
                    grid2.Children.Clear();
                    grid2.Children.Add(new editar());
                    ((editar)(grid2.Children[0])).lblnombre.Text = Datos[lsttodo.SelectedIndex].Tipo;
                    ((editar)(grid2.Children[0])).txttitulo.Text = Datos[lsttodo.SelectedIndex].Titulo;
                    ((editar)(grid2.Children[0])).txtdescripcion.Text ="";
                    ((editar)(grid2.Children[0])).txtproduccion.Text = Datos[lsttodo.SelectedIndex].Director;
                    ((editar)(grid2.Children[0])).lbtemporadas_.Text = Datos[lsttodo.SelectedIndex].Temporadas;
                    ((editar)(grid2.Children[0])).lbgenero.Text = Datos[lsttodo.SelectedIndex].Genero;
                    var rating = Datos[lsttodo.SelectedIndex].Rating.ToString();
                    ((editar)(grid2.Children[0])).rant.Text = rating;
                    var años = Datos[lsttodo.SelectedIndex].Año.ToString();
                    ((editar)(grid2.Children[0])).txtaño.Text = años;
                    return;
                }
                
                else if (string.IsNullOrEmpty((((editar)(grid2.Children[0])).txtaño.Text)))
                {
                    txtdesaparecer.Visibility = Visibility.Visible;
                    btnnuevoagregar.Visibility = Visibility.Visible;
                    btnordennum1.Visibility = Visibility.Hidden;
                    btnordennum2.Visibility = Visibility.Hidden;
                    btnletras1.Visibility = Visibility.Hidden;
                    btnletras2.Visibility = Visibility.Hidden;
                    btneditar.Visibility = Visibility.Hidden;
                    btnguardar.Visibility = Visibility.Visible;
                    btncancelar_.Visibility = Visibility.Visible;
                    btneliminar.Visibility = Visibility.Visible;
                    btnnuevoagregar.Visibility = Visibility.Hidden;
                    grid2.Children.Clear();
                    grid2.Children.Add(new editar());
                    ((editar)(grid2.Children[0])).lblnombre.Text = Datos[lsttodo.SelectedIndex].Tipo;
                    ((editar)(grid2.Children[0])).txttitulo.Text = Datos[lsttodo.SelectedIndex].Titulo;
                    ((editar)(grid2.Children[0])).txtdescripcion.Text = Datos[lsttodo.SelectedIndex].Sinopsis;
                    ((editar)(grid2.Children[0])).txtproduccion.Text = Datos[lsttodo.SelectedIndex].Director;
                    ((editar)(grid2.Children[0])).lbtemporadas_.Text = Datos[lsttodo.SelectedIndex].Temporadas;
                    ((editar)(grid2.Children[0])).lbgenero.Text = Datos[lsttodo.SelectedIndex].Genero;
                    var rating = Datos[lsttodo.SelectedIndex].Rating.ToString();
                    ((editar)(grid2.Children[0])).rant.Text = rating;
                    var años = Datos[lsttodo.SelectedIndex].Año.ToString();
                    ((editar)(grid2.Children[0])).txtaño.Text = "";
                    return;
                }
                

                else {
                    Datos[lsttodo.SelectedIndex].Genero = ((editar)(grid2.Children[0])).lbgenero.Text;
                    Datos[lsttodo.SelectedIndex].Titulo = ((editar)(grid2.Children[0])).txttitulo.Text;
                    Datos[lsttodo.SelectedIndex].Director = ((editar)(grid2.Children[0])).txtproduccion.Text;
                    Datos[lsttodo.SelectedIndex].Temporadas = ((editar)(grid2.Children[0])).lbtemporadas_.Text;
                    
                    Datos[lsttodo.SelectedIndex].Sinopsis = ((editar)(grid2.Children[0])).txtdescripcion.Text;

                    var año23 = Datos[lsttodo.SelectedIndex].Año.ToString();
                    var año7 = Convert.ToInt32(((editar)(grid2.Children[0])).txtaño.Text);

                    Datos[lsttodo.SelectedIndex].Año = año7;
                    var rating2 = Convert.ToInt32(((editar)(grid2.Children[0])).rant.Text);
                    Datos[lsttodo.SelectedIndex].Rating = rating2;
                    _4estrellas.Visibility = Visibility.Hidden;
                    _5estrellas.Visibility = Visibility.Hidden;
                    _3estrellas.Visibility = Visibility.Hidden;
                    _2estrellas.Visibility = Visibility.Hidden;
                    _1estrellas.Visibility = Visibility.Hidden;
                    _0estrellas.Visibility = Visibility.Hidden;

                    btnnuevoagregar.Visibility = Visibility.Hidden;
                    grid2.Children.Clear();
                    btnguardar.Visibility = Visibility.Hidden;
                    txtdesaparecer.Visibility = Visibility.Hidden;
                }
            }

            else if (Datos[lsttodo.SelectedIndex].Tipo == "pelicula")
            {
                
                grid2.Children.Add(new editarpeli());




                if (string.IsNullOrEmpty((((editarpeli)(grid2.Children[0])).txttitulo.Text)))
                {
                    txtdesaparecer.Visibility = Visibility.Visible;
                    btnnuevoagregar.Visibility = Visibility.Visible;
                    btnordennum1.Visibility = Visibility.Hidden;
                    btnordennum2.Visibility = Visibility.Hidden;
                    btnletras1.Visibility = Visibility.Hidden;
                    btnletras2.Visibility = Visibility.Hidden;
                    btneditar.Visibility = Visibility.Hidden;
                    btnguardar.Visibility = Visibility.Visible;
                    btncancelar_.Visibility = Visibility.Visible;
                    btneliminar.Visibility = Visibility.Visible;
                    btnnuevoagregar.Visibility = Visibility.Hidden;
                    grid2.Children.Clear();
                    grid2.Children.Add(new editarpeli());

                    ((editarpeli)(grid2.Children[0])).txttitulo.Text = "" ;

                    ((editarpeli)(grid2.Children[0])).lblnombre.Text = Datos[lsttodo.SelectedIndex].Tipo;
                    ((editarpeli)(grid2.Children[0])).txtdescripcion.Text = Datos[lsttodo.SelectedIndex].Sinopsis;
                    ((editarpeli)(grid2.Children[0])).txtproduccion.Text = Datos[lsttodo.SelectedIndex].Director;
                    ((editarpeli)(grid2.Children[0])).lbgenero.Text = Datos[lsttodo.SelectedIndex].Genero;

                    var rating = Datos[lsttodo.SelectedIndex].Rating.ToString();
                    ((editarpeli)(grid2.Children[0])).rant.Text = rating;
                    var años = Datos[lsttodo.SelectedIndex].Año.ToString();
                    ((editarpeli)(grid2.Children[0])).txtaño.Text = años;



                    return;
                }

                else if (string.IsNullOrEmpty((((editarpeli)(grid2.Children[0])).txtproduccion.Text)))
                {
                    txtdesaparecer.Visibility = Visibility.Visible;
                    btnnuevoagregar.Visibility = Visibility.Visible;
                    btnordennum1.Visibility = Visibility.Hidden;
                    btnordennum2.Visibility = Visibility.Hidden;
                    btnletras1.Visibility = Visibility.Hidden;
                    btnletras2.Visibility = Visibility.Hidden;
                    btneditar.Visibility = Visibility.Hidden;
                    btnguardar.Visibility = Visibility.Visible;
                    btncancelar_.Visibility = Visibility.Visible;
                    btneliminar.Visibility = Visibility.Visible;
                    btnnuevoagregar.Visibility = Visibility.Hidden;
                    grid2.Children.Clear();
                    grid2.Children.Add(new editarpeli());

                    ((editarpeli)(grid2.Children[0])).txttitulo.Text = Datos[lsttodo.SelectedIndex].Titulo;

                    ((editarpeli)(grid2.Children[0])).lblnombre.Text = Datos[lsttodo.SelectedIndex].Tipo;
                    ((editarpeli)(grid2.Children[0])).txtdescripcion.Text = Datos[lsttodo.SelectedIndex].Sinopsis;
                    ((editarpeli)(grid2.Children[0])).txtproduccion.Text ="";
                    ((editarpeli)(grid2.Children[0])).lbgenero.Text = Datos[lsttodo.SelectedIndex].Genero;

                    var rating = Datos[lsttodo.SelectedIndex].Rating.ToString();
                    ((editarpeli)(grid2.Children[0])).rant.Text = rating;
                    var años = Datos[lsttodo.SelectedIndex].Año.ToString();
                    ((editarpeli)(grid2.Children[0])).txtaño.Text = años;

                    return;
                }

                else if (string.IsNullOrEmpty((((editarpeli)(grid2.Children[0])).txtdescripcion.Text)))
                {
                    txtdesaparecer.Visibility = Visibility.Visible;
                    btnnuevoagregar.Visibility = Visibility.Visible;
                    btnordennum1.Visibility = Visibility.Hidden;
                    btnordennum2.Visibility = Visibility.Hidden;
                    btnletras1.Visibility = Visibility.Hidden;
                    btnletras2.Visibility = Visibility.Hidden;
                    btneditar.Visibility = Visibility.Hidden;
                    btnguardar.Visibility = Visibility.Visible;
                    btncancelar_.Visibility = Visibility.Visible;
                    btneliminar.Visibility = Visibility.Visible;
                    btnnuevoagregar.Visibility = Visibility.Hidden;
                    grid2.Children.Clear();
                    grid2.Children.Add(new editarpeli());

                    ((editarpeli)(grid2.Children[0])).txttitulo.Text = Datos[lsttodo.SelectedIndex].Titulo;

                    ((editarpeli)(grid2.Children[0])).lblnombre.Text = Datos[lsttodo.SelectedIndex].Tipo;
                    ((editarpeli)(grid2.Children[0])).txtdescripcion.Text = "";
                    ((editarpeli)(grid2.Children[0])).txtproduccion.Text = Datos[lsttodo.SelectedIndex].Director;
                    ((editarpeli)(grid2.Children[0])).lbgenero.Text = Datos[lsttodo.SelectedIndex].Genero;

                    var rating = Datos[lsttodo.SelectedIndex].Rating.ToString();
                    ((editarpeli)(grid2.Children[0])).rant.Text = rating;
                    var años = Datos[lsttodo.SelectedIndex].Año.ToString();
                    ((editarpeli)(grid2.Children[0])).txtaño.Text = años;
                    return;
                }

                else if (string.IsNullOrEmpty((((editarpeli)(grid2.Children[0])).txtaño.Text)))
                {
                    txtdesaparecer.Visibility = Visibility.Visible;
                    btnnuevoagregar.Visibility = Visibility.Visible;
                    btnordennum1.Visibility = Visibility.Hidden;
                    btnordennum2.Visibility = Visibility.Hidden;
                    btnletras1.Visibility = Visibility.Hidden;
                    btnletras2.Visibility = Visibility.Hidden;
                    btneditar.Visibility = Visibility.Hidden;
                    btnguardar.Visibility = Visibility.Visible;
                    btncancelar_.Visibility = Visibility.Visible;
                    btneliminar.Visibility = Visibility.Visible;
                    btnnuevoagregar.Visibility = Visibility.Hidden;
                    grid2.Children.Clear();
                    grid2.Children.Add(new editarpeli());

                    ((editarpeli)(grid2.Children[0])).lbgenero.Text = Datos[lsttodo.SelectedIndex].Genero;
                    ((editarpeli)(grid2.Children[0])).txttitulo.Text = Datos[lsttodo.SelectedIndex].Titulo;

                    ((editarpeli)(grid2.Children[0])).lblnombre.Text = Datos[lsttodo.SelectedIndex].Tipo;
                    ((editarpeli)(grid2.Children[0])).txtdescripcion.Text = Datos[lsttodo.SelectedIndex].Sinopsis;
                    ((editarpeli)(grid2.Children[0])).txtproduccion.Text = Datos[lsttodo.SelectedIndex].Director;
                   

                    var rating = Datos[lsttodo.SelectedIndex].Rating.ToString();
                    ((editarpeli)(grid2.Children[0])).rant.Text = rating;
                    var años = Datos[lsttodo.SelectedIndex].Año.ToString();
                    ((editarpeli)(grid2.Children[0])).txtaño.Text = "";
                    return;
                }

                else
                {
                    Datos[lsttodo.SelectedIndex].Titulo = ((editarpeli)(grid2.Children[0])).txttitulo.Text;
                    Datos[lsttodo.SelectedIndex].Director = ((editarpeli)(grid2.Children[0])).txtproduccion.Text;

                    Datos[lsttodo.SelectedIndex].Genero = ((editarpeli)(grid2.Children[0])).lbgenero.Text;


                    var año23 = Datos[lsttodo.SelectedIndex].Año.ToString();
                    var año72 = Convert.ToInt32(((editarpeli)(grid2.Children[0])).txtaño.Text);

                    Datos[lsttodo.SelectedIndex].Año = año72;
                    var rating22 = Convert.ToInt32(((editarpeli)(grid2.Children[0])).rant.Text);
                    Datos[lsttodo.SelectedIndex].Rating = rating22;
                    _4estrellas.Visibility = Visibility.Hidden;
                    _5estrellas.Visibility = Visibility.Hidden;
                    _3estrellas.Visibility = Visibility.Hidden;
                    _2estrellas.Visibility = Visibility.Hidden;
                    _1estrellas.Visibility = Visibility.Hidden;
                    _0estrellas.Visibility = Visibility.Hidden;

                    btnnuevoagregar.Visibility = Visibility.Hidden;
                    
                    grid2.Children.Clear();
                    btnguardar.Visibility = Visibility.Hidden;
                    txtdesaparecer.Visibility = Visibility.Hidden;

                }

            }

            /*if (string.IsNullOrEmpty(((editarpeli)(grid2.Children[0])).txtaño.Text))
            {

                txtdesaparecer.Visibility = Visibility.Visible;

                return;

            }*/

          

          



        }

        private void Btnletras2_Click(object sender, RoutedEventArgs e)
        //var i = Datos.Count();
        {
            /*int i = Datos.Count;
             var dat = Datos[i].Titulo;
             var temo = Convert.ToString(dat);*/

            //Datos.OrderBy(a => a.Titulo);
            //Datos = new ObservableCollection<Produccion>(Datos.OrderByDescending(i => i.Titulo));
            // dat.OrderByDescending(a => a);
            //Datos = new ObservableCollection<Produccion>(Datos.OrderBy(a => a.Titulo));
            //Datos.OrderBy(graph

            bool intercambio = false;

            
            do
            {

                intercambio = false;
                for (int i = 0; i < Datos.Count - 1; i++) //i++ para modificar el valor de la i, peor solo se le quiere sumar 1
                {

                    if (string.Compare(Datos[i].Titulo, Datos[i+1].Titulo)<0)
                    {
                        var temp = Datos[i];
                        Datos[i] = Datos[i + 1];
                        Datos[i + 1] = temp;
                        intercambio = true;
                    }


                }

            } while (intercambio);





        }

        private void Btnordennum2_Click(object sender, RoutedEventArgs e)
        {
          

 

            bool intercambio = false;
            do
            {

                intercambio = false;
                for (int i = 0; i < Datos.Count - 1; i++) //i++ para modificar el valor de la i, peor solo se le quiere sumar 1
                {

                    if (Datos[i].Año < Datos[i + 1].Año)
                    {
                        var temp = Datos[i];
                        Datos[i] = Datos[i + 1];
                        Datos[i + 1] = temp;
                        intercambio = true;
                    }


                }

            } while (intercambio);
            btnedicion.Visibility = Visibility.Hidden;
            btncancelar_.Visibility = Visibility.Hidden;
            btneliminar.Visibility = Visibility.Hidden;
            btnguardar.Visibility = Visibility.Hidden;

            btnletras1.Visibility = Visibility.Visible;
            btnletras2.Visibility = Visibility.Visible;
            btneditar.Visibility = Visibility.Visible;
            btnordennum1.Visibility = Visibility.Visible;
            btnordennum2.Visibility = Visibility.Visible;

        }

        private void Btnnuevoagregar_Click(object sender, RoutedEventArgs e)
        {
            btnedicion.Visibility = Visibility.Hidden;
            btncancelar_.Visibility = Visibility.Hidden;
            btneliminar.Visibility = Visibility.Hidden;
            btnguardar.Visibility = Visibility.Hidden;

            _0estrellas.Visibility = Visibility.Hidden;
            _1estrellas.Visibility = Visibility.Hidden;
            _2estrellas.Visibility = Visibility.Hidden;
            _3estrellas.Visibility = Visibility.Hidden;
            _4estrellas.Visibility = Visibility.Hidden;
            _5estrellas.Visibility = Visibility.Hidden;

            btncancelar_.Visibility = Visibility.Hidden;
            btnedicion.Visibility = Visibility.Hidden;
            btneditar.Visibility = Visibility.Visible;
            btneliminar.Visibility = Visibility.Hidden;
            btnguardar.Visibility = Visibility.Hidden;
            btnnuevoagregar.Visibility = Visibility.Hidden;
            btnletras1.Visibility = Visibility.Visible;
            btnletras2.Visibility = Visibility.Visible;
            btnordennum1.Visibility = Visibility.Visible;
            btnordennum2.Visibility = Visibility.Visible;

            if ((((Agregar)(grid2.Children[0])).rbpelicula.IsChecked) == true && (((Agregar)(grid2.Children[0])).rbserie.IsChecked) == false)
            {
                if (string.IsNullOrEmpty((((Agregar)(grid2.Children[0])).txttitulo.Text)))
                {
                    txtdesaparecer.Visibility = Visibility.Visible;
                    btnnuevoagregar.Visibility = Visibility.Visible;
                    btnordennum1.Visibility = Visibility.Hidden;
                    btnordennum2.Visibility = Visibility.Hidden;
                    btnletras1.Visibility = Visibility.Hidden;
                    btnletras2.Visibility = Visibility.Hidden;
                    btneditar.Visibility = Visibility.Hidden;
                    return;
                }
                else if (string.IsNullOrEmpty((((Agregar)(grid2.Children[0])).lbgenero.Text)))
                {
                    txtdesaparecer.Visibility = Visibility.Visible;
                    btnnuevoagregar.Visibility = Visibility.Visible;
                    btnordennum1.Visibility = Visibility.Hidden;
                    btnordennum2.Visibility = Visibility.Hidden;
                    btnletras1.Visibility = Visibility.Hidden;
                    btnletras2.Visibility = Visibility.Hidden;
                    btneditar.Visibility = Visibility.Hidden;
                    return;
                }
                else if (string.IsNullOrEmpty((((Agregar)(grid2.Children[0])).txtdirector.Text)))
                {
                    txtdesaparecer.Visibility = Visibility.Visible;
                    btnnuevoagregar.Visibility = Visibility.Visible;
                    btnordennum1.Visibility = Visibility.Hidden;
                    btnordennum2.Visibility = Visibility.Hidden;
                    btnletras1.Visibility = Visibility.Hidden;
                    btnletras2.Visibility = Visibility.Hidden;
                    btneditar.Visibility = Visibility.Hidden;
                    return;
                }
                else if (string.IsNullOrEmpty((((Agregar)(grid2.Children[0])).txtdescripcion.Text)))
                {
                    txtdesaparecer.Visibility = Visibility.Visible;
                    btnnuevoagregar.Visibility = Visibility.Visible;
                    btnordennum1.Visibility = Visibility.Hidden;
                    btnordennum2.Visibility = Visibility.Hidden;
                    btnletras1.Visibility = Visibility.Hidden;
                    btnletras2.Visibility = Visibility.Hidden;
                    btneditar.Visibility = Visibility.Hidden;
                    return;
                }
                else if (string.IsNullOrEmpty((((Agregar)(grid2.Children[0])).txttipo2.Text)))
                {
                    txtdesaparecer.Visibility = Visibility.Visible;
                    btnnuevoagregar.Visibility = Visibility.Visible;
                    btnordennum1.Visibility = Visibility.Hidden;
                    btnordennum2.Visibility = Visibility.Hidden;
                    btnletras1.Visibility = Visibility.Hidden;
                    btnletras2.Visibility = Visibility.Hidden;
                    btneditar.Visibility = Visibility.Hidden;
                    return;
                }
                else if (string.IsNullOrEmpty((((Agregar)(grid2.Children[0])).txtaño.Text)))
                {
                    txtdesaparecer.Visibility = Visibility.Visible;
                    btnnuevoagregar.Visibility = Visibility.Visible;
                    btnordennum1.Visibility = Visibility.Hidden;
                    btnordennum2.Visibility = Visibility.Hidden;
                    btnletras1.Visibility = Visibility.Hidden;
                    btnletras2.Visibility = Visibility.Hidden;
                    btneditar.Visibility = Visibility.Hidden;
                    return;
                }
                else if (string.IsNullOrEmpty((((Agregar)(grid2.Children[0])).rant.Text)))
                {
                    txtdesaparecer.Visibility = Visibility.Visible;
                    btnnuevoagregar.Visibility = Visibility.Visible;
                    btnordennum1.Visibility = Visibility.Hidden;
                    btnordennum2.Visibility = Visibility.Hidden;
                    btnletras1.Visibility = Visibility.Hidden;
                    btnletras2.Visibility = Visibility.Hidden;
                    btneditar.Visibility = Visibility.Hidden;

                    return;
                }

                else
                {
                    Datos.Add(new Pelicula((((Agregar)(grid2.Children[0])).lbgenero.Text), Convert.ToInt32(((Agregar)(grid2.Children[0])).txtaño.Text), (((Agregar)(grid2.Children[0])).txttitulo.Text),
                   (((Agregar)(grid2.Children[0])).txtdirector.Text), (((Agregar)(grid2.Children[0])).txtdescripcion.Text), Convert.ToInt32(((Agregar)(grid2.Children[0])).rant.Text), (((Agregar)(grid2.Children[0])).txttipo2.Text)));

                    grid2.Children.Clear();
                    btncancelarnuevo.Visibility = Visibility.Hidden;
                }
            }
            else if ((((Agregar)(grid2.Children[0])).rbserie.IsChecked) == true && (((Agregar)(grid2.Children[0])).rbpelicula.IsChecked) == false)
            {
                if (string.IsNullOrEmpty((((Agregar)(grid2.Children[0])).txttitulo.Text)))
                {
                    txtdesaparecer.Visibility = Visibility.Visible;
                    btnnuevoagregar.Visibility = Visibility.Visible;
                    btnordennum1.Visibility = Visibility.Hidden;
                    btnordennum2.Visibility = Visibility.Hidden;
                    btnletras1.Visibility = Visibility.Hidden;
                    btnletras2.Visibility = Visibility.Hidden;
                    btneditar.Visibility = Visibility.Hidden;
                    return;
                }
                else if (string.IsNullOrEmpty((((Agregar)(grid2.Children[0])).lbgenero.Text)))
                {
                    txtdesaparecer.Visibility = Visibility.Visible;
                    btnnuevoagregar.Visibility = Visibility.Visible;
                    btnordennum1.Visibility = Visibility.Hidden;
                    btnordennum2.Visibility = Visibility.Hidden;
                    btnletras1.Visibility = Visibility.Hidden;
                    btnletras2.Visibility = Visibility.Hidden;
                    btneditar.Visibility = Visibility.Hidden;
                    return;
                }
                else if (string.IsNullOrEmpty((((Agregar)(grid2.Children[0])).txttipo2.Text)))
                {
                    txtdesaparecer.Visibility = Visibility.Visible;
                    btnnuevoagregar.Visibility = Visibility.Visible;
                    btnordennum1.Visibility = Visibility.Hidden;
                    btnordennum2.Visibility = Visibility.Hidden;
                    btnletras1.Visibility = Visibility.Hidden;
                    btnletras2.Visibility = Visibility.Hidden;
                    btneditar.Visibility = Visibility.Hidden;
                    return;
                }
                else if (string.IsNullOrEmpty((((Agregar)(grid2.Children[0])).txtproduccion.Text)))
                {
                    txtdesaparecer.Visibility = Visibility.Visible;
                    btnnuevoagregar.Visibility = Visibility.Visible;
                    btnordennum1.Visibility = Visibility.Hidden;
                    btnordennum2.Visibility = Visibility.Hidden;
                    btnletras1.Visibility = Visibility.Hidden;
                    btnletras2.Visibility = Visibility.Hidden;
                    btneditar.Visibility = Visibility.Hidden;
                    return;
                }
                else if (string.IsNullOrEmpty((((Agregar)(grid2.Children[0])).txtdescripcion.Text)))
                {
                    txtdesaparecer.Visibility = Visibility.Visible;
                    btnnuevoagregar.Visibility = Visibility.Visible;
                    btnordennum1.Visibility = Visibility.Hidden;
                    btnordennum2.Visibility = Visibility.Hidden;
                    btnletras1.Visibility = Visibility.Hidden;
                    btnletras2.Visibility = Visibility.Hidden;
                    btneditar.Visibility = Visibility.Hidden;
                    return;
                }
              
                else if (string.IsNullOrEmpty((((Agregar)(grid2.Children[0])).txtaño.Text)))
                {
                    txtdesaparecer.Visibility = Visibility.Visible;
                    btnnuevoagregar.Visibility = Visibility.Visible;
                    btnordennum1.Visibility = Visibility.Hidden;
                    btnordennum2.Visibility = Visibility.Hidden;
                    btnletras1.Visibility = Visibility.Hidden;
                    btnletras2.Visibility = Visibility.Hidden;
                    btneditar.Visibility = Visibility.Hidden;
                    return;
                }
                else if (string.IsNullOrEmpty((((Agregar)(grid2.Children[0])).rant.Text)))
                {
                    txtdesaparecer.Visibility = Visibility.Visible;
                    btnnuevoagregar.Visibility = Visibility.Visible;
                    btnordennum1.Visibility = Visibility.Hidden;
                    btnordennum2.Visibility = Visibility.Hidden;
                    btnletras1.Visibility = Visibility.Hidden;
                    btnletras2.Visibility = Visibility.Hidden;
                    btneditar.Visibility = Visibility.Hidden;
                    return;
                }

                else if (string.IsNullOrEmpty((((Agregar)(grid2.Children[0])).lbtemporadas_.Text)))
                {
                    txtdesaparecer.Visibility = Visibility.Visible;
                    btnnuevoagregar.Visibility = Visibility.Visible;
                    btnordennum1.Visibility = Visibility.Hidden;
                    btnordennum2.Visibility = Visibility.Hidden;
                    btnletras1.Visibility = Visibility.Hidden;
                    btnletras2.Visibility = Visibility.Hidden;
                    btneditar.Visibility = Visibility.Hidden;
                    return;
                }


                else
                {
                   /* Datos.Add(new Serie((((Agregar)(grid2.Children[0])).txtproduccion.Text), Convert.ToInt32(((Agregar)(grid2.Children[0])).txtaño.Text), (((Agregar)(grid2.Children[0])).txttitulo.Text), (((Agregar)(grid2.Children[0])).txtdirector.Text), (((Agregar)(grid2.Children[0])).txtdescripcion.Text)
                   , (((Agregar)(grid2.Children[0])).lbtemporadas_.Text), Convert.ToInt32(((Agregar)(grid2.Children[0])).rant.Text), (((Agregar)(grid2.Children[0])).txttipo2.Text)));*/

                    Datos.Add(new Serie((((Agregar)(grid2.Children[0])).lbgenero.Text), Convert.ToInt32(((Agregar)(grid2.Children[0])).txtaño.Text), (((Agregar)(grid2.Children[0])).txttitulo.Text), (((Agregar)(grid2.Children[0])).txtproduccion.Text), (((Agregar)(grid2.Children[0])).txtdescripcion.Text),
                      (((Agregar)(grid2.Children[0])).lbtemporadas_.Text), Convert.ToInt32(((Agregar)(grid2.Children[0])).rant.Text), (((Agregar)(grid2.Children[0])).txttipo2.Text)));
                    grid2.Children.Clear();
                    btncancelarnuevo.Visibility = Visibility.Hidden;
                    txtdesaparecer.Visibility = Visibility.Hidden;
                }
            }
            /*Datos.Add(new Serie((((Agregar)(grid2.Children[0])).txtproduccion.Text),Convert.ToInt32(((Agregar)(grid2.Children[0])).txtaño.Text), (((Agregar)(grid2.Children[0])).txttitulo.Text), (((Agregar)(grid2.Children[0])).txtdirector.Text), 
                (((Agregar)(grid2.Children[0])).txtproduccion.Text), (((Agregar)(grid2.Children[0])).txttemporadas.Text), Convert.ToInt32(((Agregar)(grid2.Children[0])).rant.Text)));

            Datos.Add(new Pelicula((((Agregar)(grid2.Children[0])).lbgenero.Text), Convert.ToInt32(((Agregar)(grid2.Children[0])).txtaño.Text), (((Agregar)(grid2.Children[0])).txttitulo.Text),
                (((Agregar)(grid2.Children[0])).txtdirector.Text), (((Agregar)(grid2.Children[0])).txtdescripcion.Text), Convert.ToInt32(((Agregar)(grid2.Children[0])).rant.Text)));*/
            else
            {
                txtdesaparecer.Visibility = Visibility.Visible;
            }
            }

        private void Btnregresar_Click(object sender, RoutedEventArgs e)
        {
            grid2.Children.Clear();
            btncancelar_.Visibility = Visibility.Hidden;
            btnedicion.Visibility = Visibility.Hidden;
            btneditar.Visibility = Visibility.Visible;
            btneliminar.Visibility = Visibility.Hidden;
            btnguardar.Visibility = Visibility.Hidden;
            btnnuevoagregar.Visibility = Visibility.Hidden;
            btnletras1.Visibility = Visibility.Visible;
            btnletras2.Visibility = Visibility.Visible;
            btnordennum1.Visibility = Visibility.Visible;
            btnordennum2.Visibility = Visibility.Visible;
            
        }

        private void Btncancelar__Click(object sender, RoutedEventArgs e)
        {
            grid2.Children.Clear();
            btncancelar_.Visibility = Visibility.Hidden;
            btnedicion.Visibility = Visibility.Hidden;
            btneditar.Visibility = Visibility.Visible;
            btneliminar.Visibility = Visibility.Hidden;
            btnguardar.Visibility = Visibility.Hidden;
            btnnuevoagregar.Visibility = Visibility.Hidden;
            btnletras1.Visibility = Visibility.Visible;
            btnletras2.Visibility = Visibility.Visible;
            btnordennum1.Visibility = Visibility.Visible;
            btnordennum2.Visibility = Visibility.Visible;

            _0estrellas.Visibility = Visibility.Hidden;
            _1estrellas.Visibility = Visibility.Hidden;
            _2estrellas.Visibility = Visibility.Hidden;
            _3estrellas.Visibility = Visibility.Hidden;
            _4estrellas.Visibility = Visibility.Hidden;
            _5estrellas.Visibility = Visibility.Hidden;
            btnedicion.Visibility = Visibility.Hidden;


        }

        private void Btncancelarnuevo_Click(object sender, RoutedEventArgs e)
        {
            grid2.Children.Clear();
            btncancelarnuevo.Visibility = Visibility.Hidden;
            btnnuevoagregar.Visibility = Visibility.Hidden;
            _0estrellas.Visibility = Visibility.Hidden;
            _1estrellas.Visibility = Visibility.Hidden;
            _2estrellas.Visibility = Visibility.Hidden;
            _3estrellas.Visibility = Visibility.Hidden;
            _4estrellas.Visibility = Visibility.Hidden;
            _5estrellas.Visibility = Visibility.Hidden;

            btnletras1.Visibility = Visibility.Visible;
            btnletras2.Visibility = Visibility.Visible;
            btnordennum1.Visibility = Visibility.Visible;
            btnordennum2.Visibility = Visibility.Visible;
            btnedicion.Visibility = Visibility.Hidden;
            btneditar.Visibility = Visibility.Visible;
        }
    }
    }

