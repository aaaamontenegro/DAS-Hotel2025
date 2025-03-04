using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/**
 * Esta clase se encarga de generar el modelo de una reservación. 
 * También calcula el precio total basado en el tipo de habitación y la cantidad de noches.
 */
namespace DAS_Hotel.App_Code.Models
{
    class Reservacion
    { 
        
        //precios de habitacion

        private const double HabSencilla = 9.99;
        private const double HabDoble = 19.99;
        private const double habSuite = 29.99;


        int contadorId = 0;

        int id;

       public Cliente cliente { get; set; }

        public Habitacion habitacion { get; set; }

        public int CantNoches { get; set; }
        /// <summary>
        /// Calcula el precio total de la reservación basado en el tipo de habitación y la cantidad de noches.
        /// </summary>

        public double Total { 
          
            get
            {

                if(habitacion.TipoHab == "Sencilla")
                {
                    return HabSencilla * CantNoches;
                } else if (habitacion.TipoHab == "Doble")
                {
                    return HabDoble * CantNoches;
                } else if (habitacion.TipoHab == "Suite")
                {
                    return habSuite * CantNoches;
                }

                return 0;
            }
        
        }
        /// <summary>
        /// Inicializa una nueva instancia de la clase <see cref="Reservacion"/>.
        /// </summary>
        /// <param name="cliente">El cliente que realiza la reservación.</param>
        /// <param name="habitacion">La habitación asociada a la reservación.</param>
        /// <param name="cantNoches">La cantidad de noches que se han reservado.</param>

        public Reservacion(Cliente cliente, Habitacion habitacion, int cantNoches)
        {
            this.id = contadorId++;
            this.cliente = cliente;
            this.habitacion = habitacion;
            this.CantNoches = cantNoches;
        }



     
    }
}
