using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial1.Esposito.Utilidades
{
    public static class Validaciones
    {
        //Validaciones de strings
        public static string PedirString(string Campo)
        {
            Console.WriteLine(String.Format("Por favor, ingrese el valor para el campo {0}", Campo));
            return Console.ReadLine();
        }

        public static bool ValidarNoVacio(string Valor)
        {
            return !(String.IsNullOrEmpty(Valor));
        }


        //Validaciones de Números
        public static int PedirInt(string Campo)
        {
            bool Flag = false;
            string Dato = "";
            int IntValidado;
            do
            {
                Dato = Validaciones.PedirString(Campo);
                Flag = int.TryParse(Dato, out IntValidado);
                if (!Flag)
                {
                    Console.WriteLine("Error, el dato debe ser un número entero.");
                }
            } while (!Flag);

            return IntValidado;

        }

        public static byte PedirByte(string Campo)
        {
            bool Flag = false;
            string Dato = "";
            byte ByteValidado;
            do
            {
                Dato = Validaciones.PedirString(Campo);
                Flag = byte.TryParse(Dato, out ByteValidado);
                if (!Flag)
                {
                    Console.WriteLine("Error, el dato debe ser un número entero entre 0 y 255.");
                }
            } while (!Flag);

            return ByteValidado;

        }

        public static double PedirDouble(string Campo)
        {
            bool Flag = false;
            string Dato = "";
            double DoubleValidado;
            do
            {
                Dato = Validaciones.PedirString(Campo);
                Flag = double.TryParse(Dato, out DoubleValidado);
                if (!Flag)
                {
                    Console.WriteLine("Error, el dato debe ser un número.");
                }
            } while (!Flag);

            return DoubleValidado;

        }

        public static bool ValidarPositivo(int Dato)
        {
            return (Dato > 0);
        }


        public static bool ValidarPositivo(double Dato)
        {
            return (Dato > 0);
        }


        //Validaciones de Fechas

        public static DateTime PedirFecha(string Campo)
        {
            bool Flag = false;
            string Dato = "";
            DateTime FechaValidada;
            do
            {
                Dato = Validaciones.PedirString(Campo);
                Flag = DateTime.TryParse(Dato, out FechaValidada);
                if (!Flag)
                {
                    Console.WriteLine("Error, el dato debe ser una fecha válida.");
                }
            } while (!Flag);

            return FechaValidada;

        }

        public static bool FechaMayorAMinimo(DateTime Fecha, byte Minimo)
        {
            if ((DateTime.Now.Month >= Fecha.Month) && (DateTime.Now.Day >= Fecha.Day))
            {
                return ((DateTime.Now.Year - Fecha.Year) >= Minimo);
            }
            else
            {
                return ((DateTime.Now.Year - Fecha.Year - 1) >= Minimo);
            }
        }

        public static int Antiguedad(DateTime FechaPosterior, DateTime FechaAnterior)
        {
            if ((FechaPosterior.Month >= FechaAnterior.Month) && (FechaPosterior.Day >= FechaAnterior.Day))
            {
                return (FechaPosterior.Year - FechaAnterior.Year);

            }
            else
            {
                return (FechaPosterior.Year - FechaAnterior.Year - 1);
            }
        }

        public static bool FechaFutura(DateTime Fecha)
        {
            return (Fecha > DateTime.Now);
        }

        //Validaciones de Booleanos
        public static bool PedirBool(string Campo)
        {
            string input = "";
            bool Devolver = false;
            do
            {
                Console.WriteLine(String.Format("Por favor, ingrese el valor para el campo {0} (S/N)", Campo));
                input = Console.ReadLine();
                if ((input == "S") || (input == "s"))
                {
                    Devolver = true;
                }
                else if ((input == "N") || (input == "n"))
                {
                    Devolver = false;
                }
                else
                {
                    Console.WriteLine("Entrada incorrecta, por favor reintente.");
                }
            } while (input != "N" || input != "n" || input != "S" || input != "s");

            return Devolver;
        }

        public static string BoolASiNo(bool Dato)
        {
            if (Dato)
            {
                return "SI";
            }
            else
            {
                return "NO";
            }
        }


        // menu
        /*
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
                Console.WriteLine(
                    "Por favor, seleccione una opción del menú:\n" +
                    "1) Listar Indumentarias\n" +
                    "2) Agregar \n" +
                    "3) Modificar \n" +
                    "4) Eliminar \n" +
                    "5) Listar \n" +
                    "6) Ingresar \n" +
                    "7) Devolver \n" +
                    "8) Salir");

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
        */
    }
}
