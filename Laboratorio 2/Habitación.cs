using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_2
{
    internal class Habitación
    {
        public int Numero { get; set; }
        public double PrecioPorNoche { get; set; }
        public bool Disponible { get; set; }
        public string ClienteAsignado { get; set; }

        public Habitación(int numero, double precioPorNoche, bool disponible, string clienteasignado)
        {
            Numero = numero;
            PrecioPorNoche = precioPorNoche;
            Disponible = disponible;
            ClienteAsignado = clienteasignado;
        }

        public virtual void MostrarInformacion()
        {
            Console.WriteLine($"Número: {Numero}");
            Console.WriteLine($"Precio por Noche: {PrecioPorNoche}");
            Console.WriteLine($"Disponible: {Disponible}");
            Console.WriteLine($"Cliente Asignado: {ClienteAsignado}");
        }

        public void CambiarDisponibilidad(bool disponible)
        {
            Disponible = disponible;
        }

        public void AsignarCliente(string nombreCliente)
        {
            ClienteAsignado = nombreCliente;
            CambiarDisponibilidad(false);
        }

        public void LiberarHabitacion()
        {
            ClienteAsignado = string.Empty;
            CambiarDisponibilidad(true);
        }
    }

}

