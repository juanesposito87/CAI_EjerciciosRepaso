using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticaParcial.Entidades.Utilidades
{
    public static class Validaciones
    {
        //Validaciones de strings

        public static bool ValidarNoVacio(string Valor)
        {
            return !(String.IsNullOrEmpty(Valor));
        }


        //Validaciones de Números
        public static int PasarStringAInt(string Dato)
        {
            bool Flag = false;
            int IntValidado;
            do
            {
                Flag = int.TryParse(Dato, out IntValidado);
                if (!Flag)
                {
                    throw new Exception("Error, el dato debe ser un número entero.");
                }
            } while (!Flag);

            return IntValidado;

        }

        public static byte PasarStringAByte(string Dato)
        {
            bool Flag = false;
            byte ByteValidado;
            do
            {
                Flag = byte.TryParse(Dato, out ByteValidado);
                if (!Flag)
                {
                    throw new Exception("Error, el dato debe ser un número entero entre 0 y 255.");
                }
            } while (!Flag);

            return ByteValidado;

        }

        public static double PasarStringADouble(string Dato)
        {
            bool Flag = false;
            double DoubleValidado;
            do
            {
                Flag = double.TryParse(Dato, out DoubleValidado);
                if (!Flag)
                {
                    throw new Exception("Error, el dato debe ser un número.");
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
        /*
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
        */

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

        /*
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

        */

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

        public static void Validar(ComboBox cb)
        {
            if (cb.SelectedIndex == 0)
            {
                throw new Exception("Seleccione un valor de la lista desplegable.");
            }
                
        }
        public static void Validar(ListBox lb)
        {
            if(lb.SelectedIndex == -1)
            {
                throw new Exception("Debe seleccionar un valor de la lista.");
            }   

        }

        public static void Validar(TextBox tb)
        {
            if (string.IsNullOrEmpty(tb.Text))
                throw new Exception("Debe completar el campo de texto.");
        }

        public static int Get3Random()
        {
            Random random = new Random();
            int ultimos3dígitos = random.Next(100, 999);
            return ultimos3dígitos;
        }

    }
}
