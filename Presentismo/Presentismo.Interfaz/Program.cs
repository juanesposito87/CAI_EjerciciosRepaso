using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EjercicioPresentismo.Utilidades;
using EjercicioPresentismo.BibliotecaClases.Entidades;
using EjercicioPresentismo.BibliotecaClases.Excepciones;

namespace EjercicioPresentismo.Interfaz
{
    public class Program
    {
        private static Presentismo _presentismo;
        static Program()
        {
            _presentismo = new Presentismo();
        }
        static void Main(string[] args)
        {
            Preceptor preceptorActivo = _presentismo.GetPreceptorActivo();
            DesplegarOpcionesMenu();
            ElegirOpcionesMenu(preceptorActivo);
        }

        static void DesplegarOpcionesMenu()
        {
            Console.WriteLine("1) Tomar Asistencia");
            Console.WriteLine("2) Mostrar Asistencia");
            Console.WriteLine("X) Terminar");
        }
        static void ElegirOpcionesMenu(Preceptor preceptorActivo)
        {
            string opcionMenu = Validaciones.PedirString("opción");
            switch (opcionMenu)
            {
                case "1":
                    TomarAsistencia(preceptorActivo);
                    break;
                case "2":
                    MostrarAsistencia();
                    break;
                case "X":
                    Console.WriteLine("Gracias, hasta pronto.");
                    break;
                default:
                    break;

            }
        }

        static void TomarAsistencia (Preceptor p)
        {
            List<Asistencia> ListaAsist = new List<Asistencia>();
            string input = Validaciones.PedirString("fecha");
            string inputbool = "";

            Console.WriteLine(_presentismo.GetListaAlumnos().);
            foreach (Alumno a in _presentismo.GetListaAlumnos())
                if (a is AlumnoRegular)
                {
                    Console.Write(a.ToString() + " está presente? Ingrese (S/N):");
                    inputbool = Console.ReadLine();
                    switch (inputbool)
                    {
                        case "S":
                            Asistencia asist = new Asistencia(input, p, a, true);
                            ListaAsist.Add(asist);
                            break;
                        case "N":
                            Asistencia asist2 = new Asistencia(input, p, a, false);
                            ListaAsist.Add(asist2);
                            break;
                        default:
                            Console.WriteLine("Opción incorrecta.");
                            break;
                    }
                }
            try
            {
                _presentismo.AgregarAsistencia(ListaAsist, input);
            }

            catch (AsistenciaExistenteEseDiaException ex)
            {
                Console.Write(ex.Message);
            }

            catch (AsistenciaInconsistenteException exc)
            {
                Console.Write(exc.Message);
            }

            catch (Exception exce)

            {
                Console.Write(exce.Message);
            }

            DesplegarOpcionesMenu();
            ElegirOpcionesMenu(_presentismo.GetPreceptorActivo());

        }

        static void MostrarAsistencia()
        {
            string input = Validaciones.PedirString("fecha");
            string Mensaje = "";
            try
            {
                foreach (Asistencia a in _presentismo.GetAsistenciasPorFecha(input))
                {
                    Mensaje += a.ToString();
                }
                Console.WriteLine(Mensaje);
            }
            catch (SinAlumnosRegistradosException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            DesplegarOpcionesMenu();
            ElegirOpcionesMenu(_presentismo.GetPreceptorActivo());
        }
    }
}
