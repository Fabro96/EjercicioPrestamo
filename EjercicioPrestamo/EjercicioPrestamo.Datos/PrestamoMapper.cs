using System;
using EjercicioPrestamo.Entidades;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace EjercicioPrestamo.Datos
{
    public class PrestamoMapper
    {
        public List<Prestamo> GetPrestamos()
        {
            string json2 = WebHelper.Get("/api/v1/prestamo/{893746}"); // trae un texto en formato json de una web
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

            string result = WebHelper.Post("/api/v1/cliente", obj);

            TransactionResult resultadoTransaccion = MapResultado(result);

            return resultadoTransaccion;
        }
        private NameValueCollection ReverseMap(Prestamo prestamo)
        {
            NameValueCollection n = new NameValueCollection();
            n.Add("Nombre", cliente.Nombre);
            
            return n;
        }

        private TransactionResult MapResultado(string json)
        {
            TransactionResult lst = JsonConvert.DeserializeObject<TransactionResult>(json);
            return lst;
        }
    }
}
