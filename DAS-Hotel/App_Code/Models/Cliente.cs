using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/**
 * Esta clase se encarga de generar el modelo cliente. 
 * */
namespace DAS_Hotel.App_Code.Models
{
    class Cliente
    {
        int Id { get; set; }
        string Nombre { get; set; }

        int Tel { get; set; }

        public Cliente (int id, string nombre, int tel)
        {
            Id = id;
            Nombre = nombre;
            Tel = tel;
        }
    }
}
