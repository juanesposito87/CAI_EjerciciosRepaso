using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Net;
using System.Net.Http;
using Newtonsoft.Json;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EspositoSegundoParcial.Entidades.Dominio;

namespace EspositoSegundoParcial.Datos
{
    public class MapperPlazoFIjo
    {
        private List<PlazoFijo> _plazosFijos;
        public MapperPlazoFIjo()
        {
            _plazosFijos = new List<PlazoFijo>();
        }

        public List<PlazoFijo> GetPlazosFijosPorUsuario(string Usuario)
        {
            string json = WebHelper.Get(Usuario);
            _plazosFijos = JsonConvert.DeserializeObject<List<PlazoFijo>>(json);
            return _plazosFijos;
        }

        public ResultadoTransaccion PostPlazoFijo(PlazoFijo pf, string Usuario)
        {
            NameValueCollection obj = MappeoReverso(pf, Usuario);
            string json = WebHelper.Post("PlazoFijo/", obj);
            ResultadoTransaccion rt = JsonConvert.DeserializeObject<ResultadoTransaccion>(json);
            return rt;
        }

        private NameValueCollection MappeoReverso(PlazoFijo pf, string Usuario)
        {
            NameValueCollection n = new NameValueCollection();
            n.Add("Tipo", pf.Tipo.ToString());
            n.Add("CapitalInicial", pf.CapitalInicial.ToString());
            n.Add("Dias", pf.Dias.ToString());
            n.Add("Interes", pf.Interes.ToString());
            n.Add("Usuario", Usuario);
            return n;
        }
    }
}
