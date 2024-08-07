using System;

namespace Laboratorio_2
{
    internal class HabitacionSimple : Habitación
    {
        public int NumeroDeCamas { get; set; }

        public HabitacionSimple(int numero, double precioPorNoche, bool disponible, string clienteAsignado, int numeroDeCamas)
            : base(numero, precioPorNoche, disponible, clienteAsignado)
        {
            NumeroDeCamas = numeroDeCamas;
        }

        public override void MostrarInformacion()
        {
            base.MostrarInformacion();
            Console.WriteLine($"Número de Camas: {NumeroDeCamas}");
        }
    }
}
