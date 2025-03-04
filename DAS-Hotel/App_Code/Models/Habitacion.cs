using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/**
 * Esta clase se encarga de generar el modelo habitacion
 * */
namespace DAS_Hotel.App_Code.Models
{
    class Habitacion
    {
        public int NumeroHab { get; set; }
        public string TipoHab { get; set; }
        public bool EstadoHab { get; set; }

        public Habitacion (int NumeroHab, string TipoHab)
        { 
            this.NumeroHab = NumeroHab; 
            this.TipoHab = TipoHab; 
            this.EstadoHab = false; 

        }




    }
        
}
