using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioIndumentaria.Utilidades
{
    public static class Validaciones
    {
        //Validaciones de strings
        public static string PedirString(string Campo)
        {
            Console.WriteLine(String.Format("Por favor, ingrese el valor para el campo {0}", Campo));
            return Console.ReadLine();
        }

        public static bool ValidarNoVacio (string Valor)
        {
            return !(String.IsNullOrEmpty(Valor));
        }


        //Validaciones de Números
        public static int PedirInt (string Campo)
        {
            bool Flag = false;
            string Dato = "";
            int IntValidado;
            do
            {
                Dato = Validaciones.PedirString(Campo);
                Flag = int.TryParse(Dato, out IntValidado);
                if(!Flag)
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

        public static bool ValidarPositivo (int Dato)
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

        public static bool FechaFutura(DateTime Fecha)
        {
            return (Fecha > DateTime.Now);
        }

        //Validaciones de Booleanos
        public static bool PedirBool(string Campo)
        {
            string input = "";
            do
            {
                Console.WriteLine(String.Format("Por favor, ingrese el valor para el campo {0} (S/N)", Campo));
                input = Console.ReadLine();
                if ((input == "S") || (input == "s"))
                {
                    return true;
                }
                else if ((input == "N") || (input == "n"))
                {
                    return false;
                }
                else
                {
                    Console.WriteLine("Entrada incorrecta, por favor reintente.");
                }
            } while (input != "N" || input != "n" || input != "S" || input != "s");
        }

    }
}
