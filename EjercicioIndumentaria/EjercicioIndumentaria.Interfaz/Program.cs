using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EjercicioIndumentaria.BibliotecaDeClases.Entidades;
using EjercicioIndumentaria.BibliotecaDeClases.Entidades.Abstractas;
using EjercicioIndumentaria.BibliotecaDeClases.Enum;
using EjercicioIndumentaria.BibliotecaDeClases.Excepciones;
using EjercicioIndumentaria.Utilidades;

namespace EjercicioIndumentaria.Interfaz
{
    class Program
    {

        private static List<Cliente> ListadoClientes;

        static Program()
        {
            ListadoClientes = new List<Cliente>();
            Cliente a = new Cliente(1, "Vazquez", "Jose");
            Cliente b = new Cliente(2, "Lopez", "Juan");
            Cliente c = new Cliente(3, "Riquelme", "Juan Román");
        }
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
                    string Origen1 = Validaciones.PedirString("origen");
                    double Porcentaje1 = Validaciones.PedirDouble("porcentaje de algodón");
                    bool Estampado1 = Validaciones.PedirBool("estampado S/N");
                    string Manga1 = Validaciones.PedirString("manga");

                    IndumentariaCasual ic1 = new IndumentariaCasual(Origen1, Porcentaje1);
                    Camisa cc = new Camisa(ic1, Estampado1, Manga1);
                    TiendaRopa.Agregar(cc);
                    break;

                case "2":
                    Console.WriteLine("Ingrese los datos:");
                    string Origen2 = Validaciones.PedirString("origen");
                    double Porcentaje2 = Validaciones.PedirDouble("porcentaje de algodón");
                    bool Bolsillos2 = Validaciones.PedirBool("bolsillos S/N");
                    string Material2 = Validaciones.PedirString("material");

                    IndumentariaCasual ic2 = new IndumentariaCasual(Origen2, Porcentaje2);
                    Pantalon pc = new Pantalon(ic2, Bolsillos2, Material2);
                    TiendaRopa.Agregar(pc);
                    break;

                case "3":
                    Console.WriteLine("Ingrese los datos:");
                    string Origen3 = Validaciones.PedirString("origen");
                    double Porcentaje3 = Validaciones.PedirDouble("porcentaje de algodón");
                    bool Estampado3 = Validaciones.PedirBool("estampado S/N");
                    string Manga3 = Validaciones.PedirString("manga");
                    IndumentariaFormal ifo3 = new IndumentariaFormal(Origen3, Porcentaje3);
                    Camisa cf = new Camisa(ifo3, Estampado3, Manga3);
                    TiendaRopa.Agregar(cf);
                    break;

                case "4":
                    Console.WriteLine("Ingrese los datos:");
                    string Origen4 = Validaciones.PedirString("origen");
                    double Porcentaje4 = Validaciones.PedirDouble("porcentaje de algodón");
                    bool Bolsillos4 = Validaciones.PedirBool("bolsillos S/N");
                    string Material4 = Validaciones.PedirString("material");

                    IndumentariaFormal if4 = new IndumentariaFormal(Origen4, Porcentaje4);
                    Pantalon pf = new Pantalon(if4, Bolsillos4, Material4);
                    TiendaRopa.Agregar(pf);
                    break;

                case "5":
                    Console.WriteLine("Ingrese los datos:");
                    string Origen5 = Validaciones.PedirString("origen");
                    double Porcentaje5 = Validaciones.PedirDouble("porcentaje de algodón");
                    bool Estampado5 = Validaciones.PedirBool("estampado S/N");
                    string Manga5 = Validaciones.PedirString("manga");
                    IndumentariaDeportiva ide5 = new IndumentariaDeportiva(Origen5, Porcentaje5);
                    Camisa cd = new Camisa(ide5, Estampado5, Manga5);
                    TiendaRopa.Agregar(cd);
                    break;

                case "6":
                    Console.WriteLine("Ingrese los datos:");
                    string Origen6 = Validaciones.PedirString("origen");
                    double Porcentaje6 = Validaciones.PedirDouble("porcentaje de algodón");
                    bool Bolsillos6 = Validaciones.PedirBool("bolsillos S/N");
                    string Material6 = Validaciones.PedirString("material");

                    IndumentariaDeportiva id6 = new IndumentariaDeportiva(Origen6, Porcentaje6);
                    Pantalon pd = new Pantalon(id6, Bolsillos6, Material6);
                    TiendaRopa.Agregar(pd);
                    break;

                default:
                    Console.WriteLine("Opción incorrecta.");
                    break;

            }
            DesplegarMenu();
        }

        private static void ModificarIndumentarias()
        {
            Console.Write("Por favor, seleccione el código de la indumentaria que desea modificar: ");
            int InputCodigo = Validaciones.PedirInt("código");
            Console.WriteLine("Seleccione el tipo de indumentaria:");
            Console.WriteLine("1) Pantalón");
            Console.WriteLine("2) Camisa");
            string InputSeleccion = Console.ReadLine();
            switch(InputSeleccion)
            {
                case "1":
                    int NvoStock = Validaciones.PedirInt("nuevo stock.");
                    Validaciones.ValidarPositivo(NvoStock);
                    Pantalon p = new Pantalon(InputCodigo);
                    try
                    {
                        TiendaRopa.Modificar(p, NvoStock);
                        Console.WriteLine("El stock ha sido modificado satisfactoriamente.");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    break;

                case "2":
                    int NvoStock2 = Validaciones.PedirInt("nuevo stock.");
                    Validaciones.ValidarPositivo(NvoStock2);
                    Camisa c = new Camisa(InputCodigo);
                    try
                    {
                        TiendaRopa.Modificar(c, NvoStock2);
                        Console.WriteLine("El stock ha sido modificado satisfactoriamente.");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    break;

                default:
                    Console.WriteLine("Opción incorrecta.");
                    break;
                

            }

            DesplegarMenu();
            
        }

        private static void EliminarIndumentaria()
        {
            Console.Write("Por favor, seleccione el código de la indumentaria que desea eliminar: ");
            int InputCodigo = Validaciones.PedirInt("código");
            Console.WriteLine("Seleccione el tipo de indumentaria:");
            Console.WriteLine("1) Pantalón");
            Console.WriteLine("2) Camisa");
            string InputSeleccion = Console.ReadLine();
            switch (InputSeleccion)
            {
                case "1":
                    Pantalon p = new Pantalon(InputCodigo);
                    try
                    {
                        TiendaRopa.Eliminar(p);
                        Console.WriteLine("El pantalón ha sido eliminado satisfactoriamente.");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    break;

                case "2":
                    Camisa c = new Camisa(InputCodigo);
                    try
                    {
                        TiendaRopa.Eliminar(c);
                        Console.WriteLine("La camisa ha sido eliminada satisfactoriamente.");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    break;

                default:
                    Console.WriteLine("Opción incorrecta.");
                    break;


            }

            DesplegarMenu();
        }

        private static void ListarOrdenes()
        {
            foreach (Venta v in TiendaRopa.ListarOrden())
            {
                Console.WriteLine(String.Format("{0}) {1}, {2}, {3}, ${4}", v.Codigo, v.Cliente.Apellido, v.Cliente.Nombre, v.GetCantidadTotal(), v.GetTotalPedido()));
            }
        }

        private static void IngresarOrden()
        {
            int CodCliente = Validaciones.PedirInt("código de cliente");
            Validaciones.ValidarPositivo(CodCliente);
            Cliente cliente = ListadoClientes.Find(c => c.Codigo == CodCliente);
            if (cliente != null)
            {
                Venta v = new Venta(cliente);
                bool Flag = false;
                do
                {
                    
                    int CodItem = Validaciones.PedirInt("código de indumentaria");
                    int QItem = Validaciones.PedirInt("cantidad");
                    Indumentaria ind = TiendaRopa.Inventario.Find(i => i.Codigo == CodItem);
                    if (ind != null)
                    {
                        VentaItem item = new VentaItem(ind, QItem);
                        v.Items.Add(item);
                        Flag = Validaciones.PedirBool("otro item?");
                    }
                    else
                    {
                        Console.WriteLine("Código de indumentaria incorrecto.");
                    }
                } while (Flag == true);

            try
                {
                    TiendaRopa.IngresarOrden(v);
                    Console.WriteLine(String.Format("Venta registrada correctamente con código {0}", v.Codigo));
                }
            catch (SinStockException exc)
                {
                    Console.WriteLine(exc);
                }
                
                
            }

        }

        private static void DevolverOrden()
        {
            int CodigoVenta = Validaciones.PedirInt("código de la venta que desea devolver");
            Venta vtadevolver = new Venta(CodigoVenta);
            try
            {
                TiendaRopa.DevolverOrden(vtadevolver);
                Console.WriteLine("Venta devuelta satisfactoriamente.");
            }
            catch (Exception exce)
            {
                Console.WriteLine(exce.Message);
            }
        }
  

    }
}
