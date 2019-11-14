using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto3parcial
{
    class Informacion
    {
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public string Director { get; set; }
        

        public Informacion()
        {

        }

        public Informacion(string nombre, string descripcion, string director)
        {  
             Nombre = nombre;
            Descripcion = descripcion;
            Director = director;

        }
        public override string ToString()  //para que se vea en la lista, ya que la informacion proviene de una lista , se sobre-escribe para que aparezca
        {
            return this.Nombre;
        }
    }
}
