using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_2
{
    internal class Deluxe:Habitación
    {
        public string ServiciosExtras { get; set; }

        public Deluxe(int numero, double precioPorNoche, bool disponible, string clienteasignado, string serviciosExtras)
            : base(numero, precioPorNoche, disponible, clienteasignado)
        {
            ServiciosExtras = serviciosExtras;
        }

        public override void MostrarInformacion()
        {
            base.MostrarInformacion();
            Console.WriteLine($"Servicios Extras: {ServiciosExtras}");
        }
    }
}
