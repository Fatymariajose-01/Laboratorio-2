using System;

namespace Laboratorio_2
{
    public class HabitaciónSimple : Habitación
    {
        public int NumeroDeCamas { get; set; }

        public HabitaciónSimple (int numero, double precioPorNoche, bool disponible, string clienteasignado, int numeroDeCamas)
             : base(numero, precioPorNoche, disponible, clienteasignado)
        {
            Numero = numero;
            PrecioPorNoche = precioPorNoche;
            Disponible = disponible;
            ClienteAsignado = clienteasignado;
            NumeroDeCamas = numeroDeCamas;
        }

        public override void MostrarInformacion()
        {
            base.MostrarInformacion();
            Console.WriteLine($"Número de Camas: {NumeroDeCamas}");
        }
    }
}
