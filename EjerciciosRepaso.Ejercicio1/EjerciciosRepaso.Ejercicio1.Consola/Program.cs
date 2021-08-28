using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosRepaso.Ejercicio1.Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            string NumeroRegistroIngresado;
            string UltimosCaracteres;
            int UltCarConvertidos;
            int Contador;
            Console.Write("Ingrese el número de registro: ");
            NumeroRegistroIngresado = Console.ReadLine();
            Contador = 1;
            UltimosCaracteres = NumeroRegistroIngresado.Substring(NumeroRegistroIngresado.Length - 3);
            UltCarConvertidos = Convert.ToInt32(UltimosCaracteres);
            string Foo = "";
            string Bar = "";
            for (Contador = 1; Contador < (UltCarConvertidos+1); Contador++)
            {
                if(Contador%3 == 0)
                {
                    Foo = "Foo";
                }
                
                if(Contador%5 == 0)
                {
                    Bar = "Bar";
                }
                string Inter = "";
                if((Foo.Length + Bar.Length)> 0)
                {
                    Inter = " - ";
                }
                Console.WriteLine(Convert.ToString(Contador) + Inter + Foo + Bar);
                Foo = "";
                Bar = "";
                
            }

            Console.WriteLine("Presione enter para salir.");
            Console.ReadLine();
        }


    }
}
