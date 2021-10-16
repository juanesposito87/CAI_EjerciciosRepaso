using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial1.Esposito.BibliotecaClases.Entidades
{
    public class Materia
    {
        private int _codigo;
        private string _descripcion;

        public Materia (int Codigo, string Descripcion)
        {
            _codigo = Codigo;
            _descripcion = Descripcion;
        }

        public override string ToString()
        {
            return String.Format("{0}) {1}", this._codigo, this._descripcion);
        }

        public int Codigo
        {
            get
            {
                return _codigo;
            }
        }
    }
}
