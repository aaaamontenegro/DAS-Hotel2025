using DAS_Hotel.App_Code.Models;
using DAS_Hotel.BusinessLogic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace DAS_Hotel
{
    public partial class Form1 : Form
    {

        GestorReservaciones Gestor = new GestorReservaciones();



        public Form1()
        {
            InitializeComponent();
            MostarHabitaciones();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

            string Dui = tbDui.Text;
            string Nombre = tbNombre.Text;
            string Telefono = tbTelefono.Text;


            if (VerificarDato(Dui))
            {
                MessageBox.Show("El campo Dui no debe estar vacio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbNombre.Focus();
                return;
            }

            if (VerificarDato(Nombre))
            {
                MessageBox.Show("El campo Nombre no debe estar vacio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbDui.Focus();
                return;
            }

            if (VerificarDato(Telefono))
            {
                MessageBox.Show("El campo Telefono no debe estar vacio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbTelefono.Focus();
                return;
            }

            // Verificar los numeros

            int telTransfomInt;
            int DuiTransformInt;

            if (!int.TryParse(Telefono, out telTransfomInt))
            {
                MessageBox.Show("El campo Telefono debe ser un numero del 0 al 9", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbTelefono.Focus();
                return;
            }

            if (!int.TryParse(Dui, out DuiTransformInt))
            {
                MessageBox.Show("El campo DUI debe ser un numero del 0 al 9 sin guiones", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbDui.Focus();
                return;
            }

            // Validar datos Habitacion

            string NumHab = tbNumHab.Text;
            int NumHabInt;

            if (VerificarDato(NumHab))
            {
                MessageBox.Show("El campo Numero de habitacion no debe estar vacio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbNumHab.Focus();
                return;
            }

            if (!int.TryParse(NumHab, out NumHabInt))
            {
                MessageBox.Show("El campo Numero de habitacion debe ser un numero", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbNumHab.Focus();
                return;
            }

            if (NumHabInt >= 51)
            {
                MessageBox.Show("El campo Numero de habitacion debe ser un numero del 1 al 50", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbNumHab.Focus();
                return;
            }

            if (!Gestor.VerificarHabitacionDisponible(NumHabInt))
            {
                MessageBox.Show($"La habitacion numero {NumHabInt} no esta disponible", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbNumHab.Focus();
                return;
            }

            string NumNoches = tbNoches.Text;
            int NumNochesInt;

            if (VerificarDato(NumNoches))
            {
                MessageBox.Show("El campo Numero de noches no debe estar vacio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbNoches.Focus();
                return;
            }

            if (!int.TryParse(NumNoches, out NumNochesInt))
            {
                MessageBox.Show("El campo  Numero de noches debe ser un numero", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbNoches.Focus();
                return;
            }


            string TipoHab = TipoHabitacionSeleccionada(cbHabitacion.SelectedIndex);
            double precioHab = GetPrecioHab(TipoHab);

            DialogResult Click = MessageBox.Show($"La habitacion {TipoHab} tiene un precio de ${precioHab} por noches, Desea continuar con esta seleccion", "Consulta",MessageBoxButtons.YesNoCancel,MessageBoxIcon.Question);


            if (Click == DialogResult.Yes)
            {

                Cliente cliente = new Cliente(DuiTransformInt, Nombre, telTransfomInt);
                Habitacion habitacion = new Habitacion(NumHabInt, TipoHab);
                Reservacion reserva = new Reservacion(cliente, habitacion, NumNochesInt);

                Gestor.AgregarReserva(NumHabInt, reserva);

                MostarHabitaciones();
                MostrarReservasActivas();
                btnCancelar.Visible = true;
                lbCancelacion.Visible = true;
                tbNumeroHabitaciones.Visible = true;

                MessageBox.Show($"✅ Reserva Confirmada\n\n" +
                $"Cliente: {cliente.Nombre}\n" +
                $"Habitación: {habitacion.NumeroHab} ({habitacion.TipoHab})\n" +
                $"Noches: {reserva.CantNoches}\n" +
                $"Total: ${reserva.Total}\n\n" +
                "Este cliente ya tiene una reserva registrada.",
                "Reserva Exitosa",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

                tbDui.Clear();
                tbNoches.Clear();
                tbNombre.Clear();
                tbNumHab.Clear();
                tbTelefono.Clear();
                cbHabitacion.SelectedIndex = -1;


            }
            else
            {
                return;
            }

        }
    

        private bool VerificarDato(string dato) => string.IsNullOrEmpty(dato);

        private void MostarHabitaciones()
        {

            lstHabitaciones.Items.Clear();

            List<string> habitaciones = Gestor.ObtenerEstadoHabitaciones();

            foreach(var habitacion in habitaciones)
            {
                lstHabitaciones.Items.Add(habitacion);
            }

        }

        private void MostrarReservasActivas()
        {
            listReservasOn.Items.Clear(); // Limpia el ListBox antes de llenarlo

            Dictionary<int, Reservacion> activas = Gestor.ReservasHistory;

            foreach (var reserva in activas.Values)
            {
                string reservaInfo = $"📌 Cliente: {reserva.cliente.Nombre} | Tel: {reserva.cliente.Tel} \n" +
                                     $"   Habitación: {reserva.habitacion.NumeroHab} ({reserva.habitacion.TipoHab}) \n" +
                                     $"   Noches: {reserva.CantNoches} | Total: ${reserva.Total}";

                listReservasOn.Items.Add(reservaInfo);
            }
        }


        private string TipoHabitacionSeleccionada(int index)
        {

            switch (index)
            {
                case 0:
                    return "Sencilla";
                case 1:
                    return "Doble";
                case 2:
                    return "Suite";

                default:
                    return "Secilla";
            }
        }

        private static double GetPrecioHab(string hab)
        {
            switch (hab)
            {
                case "Sencilla":
                    return 9.99;
                case "Doble":
                    return 19.99;
                case "Suite":
                    return 29.99;

                default:
                    return 0;
            }
         }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

            string habitacion = tbNumeroHabitaciones.Text;
            int HabitacionInt;



            if (VerificarDato(habitacion))
            {
                MessageBox.Show("El campo Numero de habitacion no debe estar vacio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbNumHab.Focus();
                return;
            }


            if (!int.TryParse(habitacion, out HabitacionInt))
            {
                MessageBox.Show("El campo Numero de habitacion debe ser un numero", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbNumeroHabitaciones.Focus();
                return;
            }


            if (Gestor.VerificarHabitacionDisponible(HabitacionInt))
            {
                MessageBox.Show("la habitacion que busca esta diponible no esta reservada", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbNumeroHabitaciones.Focus();
                return;
            }


            Gestor.TerminarReserva(HabitacionInt);
            MessageBox.Show($"La habitacion numero: {HabitacionInt} esta disponible y la resevacion ha sido cancelada", "Reservacion ha sido cancelada", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            MostarHabitaciones();
            MostrarReservasActivas();

            tbNumeroHabitaciones.Clear();

        }

    }
}
