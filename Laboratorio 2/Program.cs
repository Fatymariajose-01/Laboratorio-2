using System;
using System.Collections.Generic;
using Laboratorio_2;

public class Program
{
    private static List<Habitación> habitaciones = new List<Habitación>();

    public static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Menú:");
            Console.WriteLine("1. Agregar Habitación");
            Console.WriteLine("2. Eliminar Habitación");
            Console.WriteLine("3. Mostrar Habitaciones");
            Console.WriteLine("4. Asignar Habitación a Cliente");
            Console.WriteLine("5. Liberar Habitación");
            Console.WriteLine("6. Salir");
            Console.Write("Seleccione una opción: ");
            int opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    AgregarHabitacion();
                    break;
                case 2:
                    EliminarHabitacion();
                    break;
                case 3:
                    MostrarHabitaciones();
                    break;
                case 4:
                    AsignarHabitacion();
                    break;
                case 5:
                    LiberarHabitacion();
                    break;
                case 6:
                    return;
                default:
                    Console.WriteLine("Opción no válida. Intente de nuevo.");
                    break;
            }
        }
    }

    private static void AgregarHabitacion()
    {
        Console.WriteLine("Seleccionar Tipo de Habitación:");
        Console.WriteLine("1. Habitación Simple");
        Console.WriteLine("2. Habitación Doble");
        Console.WriteLine("3. Suite");
        Console.WriteLine("4. Habitación Deluxe");
        Console.Write("Seleccione una opción: ");
        int tipo = int.Parse(Console.ReadLine());

        Console.Write("Número: ");
        int numero = int.Parse(Console.ReadLine());
        Console.Write("Precio por Noche: ");
        double precio = double.Parse(Console.ReadLine());
        Console.Write("Disponible (true/false): ");
        bool disponible = bool.Parse(Console.ReadLine());
        Console.WriteLine("Cliente Asignado: ");
        string clienteA = Console.ReadLine();

        switch (tipo)
        {
            case 1:
                Console.Write("Número de Camas: ");
                int camas = int.Parse(Console.ReadLine());
                habitaciones.Add(new HabitaciónSimple(numero, precio, disponible, clienteA, camas));
                break;
            case 2:
                Console.Write("Vista al Mar (true/false): ");
                bool vistaAlMar = bool.Parse(Console.ReadLine());
                habitaciones.Add(new HabitaciónDoble(numero, precio, disponible,clienteA, vistaAlMar));
                break;
            case 3:
                Console.Write("Número de Habitaciones: ");
                int numHabitaciones = int.Parse(Console.ReadLine());
                Console.Write("Tiene Jacuzzi (true/false): ");
                bool tieneJacuzzi = bool.Parse(Console.ReadLine());
                habitaciones.Add(new Suite(numero, precio, disponible, clienteA, numHabitaciones, tieneJacuzzi));
                break;
            case 4:
                Console.Write("Servicios Extras (Desayuno incluido, acceso al spa): ");
                string serviciosExtras = Console.ReadLine();
                habitaciones.Add(new Deluxe(numero, precio, disponible, clienteA, serviciosExtras));
                break;
            default:
                Console.WriteLine("Tipo de habitación no válido.");
                break;
        }
    }

    private static void EliminarHabitacion()
    {
        Console.Write("Número de la habitación a eliminar: ");
        int numero = int.Parse(Console.ReadLine());
        Habitación habitacionARemover = habitaciones.Find(h => h.Numero == numero);

        if (habitacionARemover != null)
        {
            habitaciones.Remove(habitacionARemover);
            Console.WriteLine("Habitación eliminada.");
        }
        else
        {
            Console.WriteLine("Habitación no encontrada.");
        }
    }

    private static void MostrarHabitaciones()
    {
        foreach (var habitacion in habitaciones)
        {
            habitacion.MostrarInformacion();
            Console.WriteLine();
        }
    }

    private static void AsignarHabitacion()
    {
        Console.Write("Número de la habitación a asignar: ");
        int numero = int.Parse(Console.ReadLine());
        Console.Write("Nombre del cliente: ");
        string cliente = Console.ReadLine();

        Habitación habitacion = habitaciones.Find(h => h.Numero == numero);

        if (habitacion != null)
        {
            if (habitacion.Disponible)
            {
                habitacion.AsignarCliente(cliente);
                Console.WriteLine("Habitación asignada.");
            }
            else
            {
                Console.WriteLine("La habitación no está disponible.");
            }
        }
        else
        {
            Console.WriteLine("Habitación no encontrada.");
        }
    }

    private static void LiberarHabitacion()
    {
        Console.Write("Número de la habitación a liberar: ");
        int numero = int.Parse(Console.ReadLine());

        Habitación habitacion = habitaciones.Find(h => h.Numero == numero);

        if (habitacion != null)
        {
            habitacion.LiberarHabitacion();
            Console.WriteLine("Habitación liberada.");
        }
        else
        {
            Console.WriteLine("Habitación no encontrada.");
        }
    }
}
