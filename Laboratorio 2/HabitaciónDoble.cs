using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Laboratorio_2
{
    public class HabitaciónDoble: Habitación
    {
        public bool VistaAlMar { get; set; }
        public HabitaciónDoble(int numero, double precioPorNoche, bool disponible, string clienteasignado, bool vistaAlMar)
           : base(numero, precioPorNoche, disponible, clienteasignado)
        {
            VistaAlMar = vistaAlMar;
        }
    public override void MostrarInformacion()
    {
        base.MostrarInformacion();
        Console.WriteLine($"Vista al Mar: {VistaAlMar}");
    }
    }
}
