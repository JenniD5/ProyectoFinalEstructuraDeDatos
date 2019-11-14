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
        public ObservableCollection<Produccion> Datos = new ObservableCollection<Produccion>();




        public string Titulo { get; set; }
        public string Director { get; set; }
        public int Año { get; set; }
        public string Sinopsis { get; set; }
        public string tipo { get; set; }



        

    }
}
