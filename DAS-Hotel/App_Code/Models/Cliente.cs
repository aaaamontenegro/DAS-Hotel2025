using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/**
 * Esta clase se encarga de generar el modelo cliente. 
 * Representa a un cliente de un hotel con su ID, nombre y número de teléfono.
 * 
 * La clase incluye propiedades para almacenar los datos del cliente, 
 * y un constructor para inicializarlos.
 */
namespace DAS_Hotel.App_Code.Models
{
    class Cliente
    {
        public int Id { get; set; }
        public string Nombre { get; set; }

        public int Tel { get; set; }

        public Cliente (int id, string nombre, int tel)
        {
            Id = id;
            Nombre = nombre;
            Tel = tel;
        }
    }
}
