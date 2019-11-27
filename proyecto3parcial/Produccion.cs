using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace proyecto3parcial
{
    public class Produccion
    {
        //public ObservableCollection<Produccion> Datos = new ObservableCollection<Produccion>();




        public string Titulo { get; set; }
        public string Director { get; set; }
        public int Año { get; set; } 
        public string Sinopsis { get; set; }
        public string Tipo { get; set; }

        public string Temporadas { get; set; }

        public int Rating { get; set; }

        public string Genero { get; set;  }

        

        public Produccion() { }
}
}
