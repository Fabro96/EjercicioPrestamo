using System;
using EjercicioPrestamo.Entidades;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Collections.Specialized;
using System.Configuration;

namespace EjercicioPrestamo.Datos
{
    public class PrestamoMapper
    {
        public List<Prestamo> GetPrestamos()
        {
            string json2 = WebHelper.Get("/api/v1/prestamo/" + ConfigurationManager.AppSettings["Legajo"]); // trae un texto en formato json de una web
            List<Prestamo> resultado = MapList(json2);
            return resultado;
        }

        private List<Prestamo> MapList(string json)
        {
            List<Prestamo> lst = JsonConvert.DeserializeObject<List<Prestamo>>(json);
            return lst;
        }

        public ResultadoTransaccion Insert(Prestamo prestamo)
        {
            NameValueCollection obj = ReverseMap(prestamo);

            string result = WebHelper.Post("/api/v1/prestamo", obj);

            ResultadoTransaccion resultadoTransaccion = MapResultado(result);

            return resultadoTransaccion;
        }
        private NameValueCollection ReverseMap(Prestamo prestamo)
        {
            NameValueCollection n = new NameValueCollection();
            //n.Add("id", prestamo.ID.ToString());
            n.Add("TNA", prestamo.TNA.ToString());
            n.Add("Linea", prestamo.Linea.ToString());
            n.Add("Plazo", prestamo.Plazo.ToString());
            n.Add("Monto", prestamo.Monto.ToString());
            n.Add("Cuota", prestamo.CuotaTotal.ToString());
            n.Add("Usuario", ConfigurationManager.AppSettings["Legajo"]);

            return n;
        }

        private ResultadoTransaccion MapResultado(string json)
        {
            ResultadoTransaccion lst = JsonConvert.DeserializeObject<ResultadoTransaccion>(json);
            return lst;
        }
    }
}
