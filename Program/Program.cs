namespace Program
{
    using System;
    using System.Collections.Generic;

    public class Program
    {
        static void Main()
        {
            List<Cita> citas = new List<Cita>();
            int opcion;

            do
            {
                Console.WriteLine("Menu de opciones:");
                Console.WriteLine("1. Crear Cita");
                Console.WriteLine("2. Listar Citas");
                Console.WriteLine("3. Modificar Universidades");
                Console.WriteLine("4. Salir");
                Console.Write("Seleccione una opcion: ");
                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        CitaUtil.CrearCita(citas);
                        break;
                    case 2:
                        CitaUtil.ListarCitas(citas);
                        break;
                    case 3:
                        Console.Write("Texto a buscar: ");
                        string textoABuscar = Console.ReadLine();
                        Console.Write("Texto de reemplazo: ");
                        string textoRemplazo = Console.ReadLine();
                        CitaUtil.ModificarUniversidad(citas, textoABuscar, textoRemplazo);
                        break;
                    case 4:
                        Console.WriteLine("Saliendo del programa.");
                        break;
                    default:
                        Console.WriteLine("Opcion no valida.");
                        break;
                }
            } while (opcion != 4);
        }
    }
}
