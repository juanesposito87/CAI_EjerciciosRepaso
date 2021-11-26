using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaParcial.Entidades.Clases
{
    public class ResultadoTransaccion
    {
        public bool isOk;
        public string error;
        public int id;

        public ResultadoTransaccion(bool Ok, string Error, int Id)
        {
            isOk = Ok;
            error = Error;
            id = Id;
        }


    }
}
