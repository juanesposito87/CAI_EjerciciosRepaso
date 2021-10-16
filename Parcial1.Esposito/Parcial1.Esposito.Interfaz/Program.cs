using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Parcial1.Esposito.BibliotecaClases.Entidades.Abstractas;
using Parcial1.Esposito.BibliotecaClases.Entidades;
using Parcial1.Esposito.BibliotecaClases.Excepciones;
using Parcial1.Esposito.Utilidades;

namespace Parcial1.Esposito.Interfaz
{
    public class Program
    {
        private static Instituto _instituto;

        static Program()
        {
            _instituto = new Instituto("NOMBRE");
        }

        static void Main(string[] args)
        {

            //traemos el profesor de turno por legajo (elegir el que quieran)
            Profesor profesor = _instituto.GetProfesor(5);

            bool Flag = false;
            do
            {
                DesplegarOpcionesMenu();

                string opcionMenu = Validaciones.PedirString("opción");
                switch (opcionMenu)
                {
                    case "1":
                        InscribirEstudiante(profesor);
                        break;
                    case "2":
                        MostrarInscripciones();
                        break;
                    case "X":
                        Console.WriteLine("Gracias, hasta pronto.");
                        Flag = true;
                        break;
                    default:
                        Console.WriteLine("Opción incorrecta, por favor reintente.");
                        break;
                } 
            } while (Flag == false);

        }
        static void DesplegarOpcionesMenu()
        {
            Console.WriteLine("1) Inscribir Estudiante");
            Console.WriteLine("2) Mostrar Inscripciones");
            Console.WriteLine("X: Terminar");
        }
        static void InscribirEstudiante(Profesor p)
        {
            // Listar los estudiantes
            // Listar las materias
            // Intento cargar la Inscripción
            // Error: mostrar el error y que luego muestre el menú nuevamente
            Console.WriteLine("Estudiantes:");
            foreach (Estudiante e in _instituto.GetEstudiantes())
            {
                Console.WriteLine(e.ToString());
            }

            Console.WriteLine("Materias:");
            foreach (Materia m in _instituto.GetMaterias())
            {
                Console.WriteLine(m.ToString());
            }
            bool Salida = false;
            do
            {

                int CodMat = Validaciones.PedirInt("código de la materia");
                int RegEst = Validaciones.PedirInt("número de registro del estudiante");
                Materia materia = _instituto.GetMaterias().Find(m => m.Codigo == CodMat);
                Estudiante estudiante = _instituto.GetEstudiantes().Find(e => e.Registro == RegEst);

                if ((!(materia is null)) && (!(estudiante is null)))
                {
                    Salida = true;
                    Inscripcion inscripcion = new Inscripcion(p, estudiante, materia);
                    try
                    {
                        _instituto.CargarInscripcion(inscripcion);
                    }
                    catch (EstudianteInhabilitadoException eie)
                    {
                        Console.WriteLine(eie.Message);
                    }
                    catch (EstudianteInscriptoException einse)
                    {
                        Console.WriteLine(einse.Message);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }

                    
                }
                else
                {
                    Console.WriteLine("El código de la materia y/o el número de registro es incorrecto.");
                }

            } while (!Salida);


            /*
            int CodMat = Validaciones.PedirInt("código de la materia");
            do
            {
                if (!(Validaciones.ValidarPositivo(CodMat)))
                {
                    Console.WriteLine("Debe ingresar un número positivo");
                }
            } while (!Validaciones.ValidarPositivo(CodMat));


            int RegEst = Validaciones.PedirInt("número de registro del estudiante");
            do
            {
                if (!(Validaciones.ValidarPositivo(RegEst)))
                {
                    Console.WriteLine("Debe ingresar un número positivo");
                }
            } while (!Validaciones.ValidarPositivo(RegEst));
            */


        }
        static void MostrarInscripciones()
        {
            // ingreso fecha
            // muestro el toString de cada inscripción
            DateTime Fecha = Validaciones.PedirFecha("fecha");
            if (_instituto.GetInscripcionesPorFecha(Fecha).Any())
            {
                foreach (Inscripcion i in _instituto.GetInscripcionesPorFecha(Fecha))
                {
                    Console.WriteLine(i.ToString());
                }
            }
            else
            {
                Console.WriteLine(String.Format("No hay registros para la fecha {0}", Fecha.ToString("yyyy/MM/dd")));
            }
            
        }

    }
}

