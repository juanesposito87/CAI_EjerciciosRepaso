using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EjercicioIndumentaria.BibliotecaDeClases.Entidades;
using EjercicioIndumentaria.BibliotecaDeClases.Entidades.Abstractas;
using EjercicioIndumentaria.BibliotecaDeClases.Enum;
using EjercicioIndumentaria.Utilidades;

namespace EjercicioIndumentaria.Interfaz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido!");
            DesplegarMenu();    
        }

        private static void DesplegarMenu()
        {
            List<String> OpcionesPosibles = new List<string>();
            string Seleccion = "";
            OpcionesPosibles.Add("1");
            OpcionesPosibles.Add("2");
            OpcionesPosibles.Add("3");
            OpcionesPosibles.Add("4");
            OpcionesPosibles.Add("5");
            OpcionesPosibles.Add("6");
            OpcionesPosibles.Add("7");
            OpcionesPosibles.Add("8");
            do
            {
                Console.WriteLine("Por favor, seleccione una opción del menú:");
                Console.WriteLine("1) Listar Indumentarias.");
                Console.WriteLine("2) Agregar Indumentaria.");
                Console.WriteLine("3) Modificar Indumentaria.");
                Console.WriteLine("4) Eliminar Indumentaria.");
                Console.WriteLine("5) Listar órdenes.");
                Console.WriteLine("6) Ingresar orden.");
                Console.WriteLine("7) Devolver orden.");
                Console.WriteLine("8) Salir.");

                Seleccion = Console.ReadLine();
            } while (!(OpcionesPosibles.Contains(Seleccion)));

            switch (Seleccion)
            {
                case "1":
                    ListarIndumentarias();
                    break;
                case "2":
                    AgregarIndumentarias();
                    break;
                case "3":
                    ModificarIndumentarias();
                    break;
                case "4":
                    EliminarIndumentaria();
                    break;
                case "5":
                    ListarOrdenes();
                    break;
                case "6":
                    IngresarOrden();
                    break;
                case "7":
                    DevolverOrden();
                    break;
                case "8":
                    Console.WriteLine("Gracias, hasta luego");
                    break;
                default:
                    break;
            }
        }
        private static void ListarIndumentarias()
        {
            string Mensaje = "";
            foreach (Indumentaria i in TiendaRopa.Listar())
            {
                Mensaje = Mensaje + i.GetDetalle() + System.Environment.NewLine;
            }

            DesplegarMenu();
        }

        private static void AgregarIndumentarias()
        {
            Console.WriteLine("Ingrese el tipo de indumentaria que desea agregar:");
            Console.WriteLine("1) Camisa Casual");
            Console.WriteLine("2) Pantalón Casual");
            Console.WriteLine("3) Camisa Formal");
            Console.WriteLine("4) Pantalón Formal");
            Console.WriteLine("5) Camisa Deportiva");
            Console.WriteLine("6) Pantalón Deportivo");

            string Seleccion = "";
            Seleccion = Console.ReadLine();

            switch (Seleccion)
            {
                case "1":
                    Console.WriteLine("Ingrese los datos:");
                    string Origen = Validaciones.PedirString("origen");
                    double Porcentaje = Validaciones.PedirDouble("porcentaje de algodón");
                    bool Estampado = Validaciones.PedirBool("estampado S/N");
                    string Manga = Validaciones.PedirString("manga");

                    IndumentariaCasual ic = new IndumentariaCasual(Origen, Porcentaje);
                    Camisa c = new Camisa(ic, Estampado, Manga);
                    TiendaRopa.Agregar(c);
            }

        }
    }
}
