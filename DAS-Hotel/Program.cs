using DAS_Hotel.App_Code.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DAS_Hotel
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());


            Cliente  marlon = new Cliente(1, "Marln", 7749939);
            Habitacion habitacion1 = new Habitacion(2, "sencilla", true);
            Reservacion reservacion = new Reservacion(marlon, habitacion1, 20);


            _ = MessageBox.Show("El total de la reserva " + reservacion.Total);
            




        }
    }
}
