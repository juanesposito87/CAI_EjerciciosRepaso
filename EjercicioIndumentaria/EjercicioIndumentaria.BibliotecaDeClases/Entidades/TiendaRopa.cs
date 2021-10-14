using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EjercicioIndumentaria.BibliotecaDeClases.Entidades.Abstractas;
using EjercicioIndumentaria.BibliotecaDeClases.Enum;
using EjercicioIndumentaria.BibliotecaDeClases.Excepciones;

namespace EjercicioIndumentaria.BibliotecaDeClases.Entidades
{
    public static class TiendaRopa
    {
        private static List<Indumentaria> _inventario;
        private static List<Venta> _ventas;
        private static int _ultimoCodigo;

        
        /*
        public TiendaRopa()
        {
            _inventario = new List<Indumentaria>();
            _ventas = new List<Venta>();
            _ultimoCodigo = 0;
        }
       
        */

        public static List<Indumentaria> Inventario
        {
            get
            {
                return _inventario;
            }

            set
            {
                _inventario = value;
            }
        }

        public static List<Venta> Ventas
        {
            get
            {
                return _ventas;
            }

        }

        public static int GetProximoCodigo()
        {
            return (_ultimoCodigo + 1);
        }

        public static void Agregar(Indumentaria i)
        {
            _inventario.Add(i);
        }

        public static void Quitar(Indumentaria i)
        {
            _inventario.Remove(i);
        }

        public static void IngresarOrden(Venta v)
        {
            bool Flag = true;
            string PrendaAgotada = "";
            foreach (VentaItem item in v.Items)
            {
                if (item.Cantidad > (TiendaRopa._inventario.Find(i => i.Equals(item)).Stock))
                {
                    Flag = false;
                    PrendaAgotada = item.Prenda.GetDetalle();
                }
            }

            if (Flag == true)
            {
                v.Estado = (int)EstadoVenta.Procesada;
                _ventas.Add(v);
                _ultimoCodigo = v.Codigo;
                foreach (Indumentaria indum in TiendaRopa._inventario)
                {
                    foreach(VentaItem it in v.Items)
                    {
                        if (indum.Equals(it))
                        {
                            indum.Stock -= it.Cantidad;
                        }
                    }
                }
            }
            else
            {
                throw new SinStockException(PrendaAgotada);
            }

        }

        public static List<Indumentaria> Listar()
        {
            return _inventario;
        }

        public static List<Venta> ListarOrden()
        {
            return _ventas;
        }

        public static void DevolverOrden(Venta v)
        {
            v.Estado = (int)EstadoVenta.Devuelto;    
        }

        public static void Modificar(Indumentaria i, int NuevoStock)
        {
            int Index = -1;
            foreach (Indumentaria indu in _inventario)
            {
                if(i.Equals(indu))
                {
                    Index = _inventario.IndexOf(indu);
                }
            }

            if(Index != -1)
            {
                _inventario.ElementAt(Index).Stock = NuevoStock;
            }
            else
            {
                throw new Exception("El código es incorrecto.");
            }
            
        }

        public static void Eliminar(Indumentaria i)
        {
            int Index = -1;
            foreach (Indumentaria indu in _inventario)
            {
                if (i.Equals(indu))
                {
                    Index = _inventario.IndexOf(indu);
                }
            }

            if (Index != -1)
            {
                _inventario.RemoveAt(Index);
            }
            else
            {
                throw new Exception("El código es incorrecto.");
            }
        }
    }
}
