using DAS_Hotel.App_Code.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DAS_Hotel.BusinessLogic
{
    /// <summary>
    /// Clase encargada de gestionar las reservaciones en el hotel.
    /// Maneja Clientes, Reservas y el estado de las habitaciones.
    /// </summary>
    class GestorReservaciones
    {

        List<Cliente> ListaClientes;

        public Dictionary<int, Reservacion> ReservasHistory;

        bool[,] MatrizHab = new bool[5, 10];


        public GestorReservaciones()
        {
            ReservasHistory = new Dictionary<int, Reservacion>();
        }

        public void CrearCliente(int Id, string nombre, int telefono)
        {

            Cliente cliente = new Cliente(Id, nombre, telefono);
            ListaClientes.Add(cliente);

        }

    
        public void AgregarReserva(int numerHab, Reservacion reserva)
        {
            if (!VerificarHabitacionDisponible(numerHab))
            {
                throw new InvalidOperationException($"La habitación {numerHab} ya está ocupada.");
            }


            ReservasHistory.Add(numerHab, reserva);  // Agrega la reserva

            int piso = AsignarPiso(numerHab) - 1;  // Convertir el piso a índice de matriz
            int habitacionIndex = (numerHab - 1) % 10;  // Ajustar índice de habitación


            MatrizHab[piso, habitacionIndex] = true;  // Marcar la habitación como ocupada

        }

        public bool VerificarHabitacionDisponible(int numHab)
        {

            if (numHab <= 0 || numHab > 50)
            {
                throw new ArgumentOutOfRangeException(nameof(numHab), "Número de habitación inválido.");
            }

            int piso = AsignarPiso(numHab) - 1;  // Convertir el piso a índice de matriz (0-4)

            int habitacionIndex = (numHab - 1) % 10;  // Índice de la habitación dentro del piso (0-9)


            return !MatrizHab[piso, habitacionIndex];

        }

        private static int AsignarPiso(int numHab)
        {
            if (numHab <= 0 || numHab > 50) return 0;  // Validación para fuera de rango

            return (numHab - 1) / 10 + 1;  // Cálculo directo del piso
        }

        //Cancelar la reserva y liberar la habitacion
        public void TerminarReserva(int numHab)
        {
            if (ReservasHistory.ContainsKey(numHab))
            {
                ReservasHistory.Remove(numHab);

                int piso = AsignarPiso(numHab) - 1;
                int habitacionIndex = (numHab - 1) % 10;

                MatrizHab[piso, habitacionIndex] = false; // No esta ocupada    
            }
        }

        public List<Cliente> ObtenerClientes()
        {

            return ListaClientes;


        }

        public List<string> ObtenerEstadoHabitaciones()
        {
            List<string> listaHabitaciones = new List<string>();

            int habitacionTotal = 1; // Contador global para las habitaciones

            for (int i = 0; i < MatrizHab.GetLength(0); i++) // Recorre pisos
            {
                listaHabitaciones.Add($"📌 Piso {i + 1}"); // Agrega el título del piso

                for (int j = 0; j < MatrizHab.GetLength(1); j++) // Recorre habitaciones
                {
                    string estado = MatrizHab[i, j] ? "Ocupada" : "Disponible";
                    listaHabitaciones.Add($"   → Habitación {habitacionTotal}: {estado}"); // Usa habitacionTotal para numerar del 1 al 50
                    habitacionTotal++; // Aumenta el contador para la siguiente habitación
                }

                listaHabitaciones.Add(""); // Línea en blanco para separar pisos
            }

            return listaHabitaciones;
        }


        private void EliminarReserva(int numerHab)
        {
            if (ReservasHistory.ContainsKey(numerHab))
            {
                ReservasHistory.Remove(numerHab);
                TerminarReserva(numerHab);
            }
        }



    }
}
