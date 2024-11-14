using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{

    public static class CitaUtil
    {
        public static void CrearCita(List<Cita> citas)
        {
            Console.Write("Numero de cita: ");
            int numero = int.Parse(Console.ReadLine());

            Console.Write("Codigo de estudiante: ");
            int codigo = int.Parse(Console.ReadLine());
            Console.Write("Nombre del estudiante: ");
            string nombre = Console.ReadLine();
            Console.Write("Universidad del estudiante: ");
            string universidad = Console.ReadLine();

            Estudiante estudiante = new Estudiante(codigo, nombre, universidad);

            Console.Write("Enfermedad: ");
            string enfermedad = Console.ReadLine();
            Console.Write("Precio: ");
            double precio = double.Parse(Console.ReadLine());

            Cita cita = new Cita(numero, estudiante, enfermedad, precio);
            citas.Add(cita);

            Console.WriteLine("Cita creada con exito.");
        }

        public static void ListarCitas(List<Cita> citas)
        {
            double totalPrecio = 0;
            foreach (var cita in citas)
            {
                Console.WriteLine(cita);
                totalPrecio += cita.Precio;
            }
            Console.WriteLine($"Total acumulado en precios: {totalPrecio:C}");
        }

        public static void ModificarUniversidad(List<Cita> citas, string textoABuscar, string textoRemplazo)
        {
            foreach (var cita in citas)
            {
                if (cita.Estudiante.Universidad.Contains(textoABuscar))
                {
                    cita.Estudiante.Universidad = cita.Estudiante.Universidad.Replace(textoABuscar, textoRemplazo);
                }
            }
            Console.WriteLine("Las universidades modificadas con exito.");
            Console.ReadKey();
        }
    }
}