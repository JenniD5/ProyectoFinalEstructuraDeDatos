using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto3parcial
{
    class Serie : Produccion
    {
       



        public Serie() { }
        public Serie(string genero, int año, string titulo, string director, string sinopsis, string temporadas, int rating, string tipo)
        {
            Genero = genero;
            Titulo = titulo;
            Director = director;
            Año = año;
            Sinopsis = sinopsis;
            Temporadas = temporadas;
            Rating = rating;
            Tipo = tipo;
        }
        

    }
}
