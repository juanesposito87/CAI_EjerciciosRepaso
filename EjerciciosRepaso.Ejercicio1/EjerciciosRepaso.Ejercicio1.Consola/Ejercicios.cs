using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosRepaso.Ejercicio1.Consola
{
    class Ejercicios
    {
        public void Ejercicio1()
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
            for (Contador = 1; Contador < (UltCarConvertidos + 1); Contador++)
            {
                if (Contador % 3 == 0)
                {
                    Foo = "Foo";
                }

                if (Contador % 5 == 0)
                {
                    Bar = "Bar";
                }
                string Inter = "";
                if ((Foo.Length + Bar.Length) > 0)
                {
                    Inter = " - ";
                }
                Console.WriteLine(Convert.ToString(Contador) + Inter + Foo + Bar);
                Foo = "";
                Bar = "";

            }

        }

        public void Ejercicio2()
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
            string mje = "";
            int pivot = 0;
            bool EsPrimo = true;
            for (Contador = 1; Contador < (UltCarConvertidos + 1); Contador++)
            {
                for (pivot = Contador-1; pivot > 1; pivot--)
                {
                    EsPrimo = true;
                    if (Contador % pivot == 0)
                    {
                        EsPrimo = false;
                        pivot = 0;
                    }
                }
                if (Contador == 3)
                {
                    mje = "Es primo y divisible por 3.";
                }
                else if (Contador % 3 == 0)
                {
                    mje = "Es divisible por 3.";
                }
                else if (EsPrimo == false)
                {
                    mje = "Es primo.";
                }

                Console.WriteLine(Convert.ToString(Contador) + " - " + mje);
            }
        }

        public void Ejercicio3()
        {
            bool EsPalindromo = false;
            string Palabra = "";

        }
    }
}
