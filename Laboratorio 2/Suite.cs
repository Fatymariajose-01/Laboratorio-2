using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Laboratorio_2
{
    internal class Suite:Habitación
    {
        public int NumeroDeHabitaciones { get; set; }
        public bool TieneJacuzzi { get; set; }
        public Suite(int numero, double precioPorNoche, bool disponible, string clienteasignado, int numeroDeHabitaciones, bool tieneJacuzzi)
                      : base(numero, precioPorNoche, disponible, clienteasignado)
        {
            Numero = numero;
            PrecioPorNoche = precioPorNoche;
            Disponible = disponible;
            ClienteAsignado = clienteasignado;
            NumeroDeHabitaciones = numeroDeHabitaciones;
            TieneJacuzzi = tieneJacuzzi;
        }
        public override void MostrarInformacion()
        {
            base.MostrarInformacion();
            Console.WriteLine($"Numero de habitaciones: {NumeroDeHabitaciones}");
            Console.WriteLine($"Tiene Jacuzzi: {TieneJacuzzi}");
        }
    }
}
