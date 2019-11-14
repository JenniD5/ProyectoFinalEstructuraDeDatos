using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto3parcial
{
    class Año:Informacion
    {

        public int Fecha { get; set; }
        public Año() { }
        public Año(int fecha)
        {
            Fecha = fecha;
            Nombre ="";
            Descripcion = "";
            Director = "";
        }
    }
}
