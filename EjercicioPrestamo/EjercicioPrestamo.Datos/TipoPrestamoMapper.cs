using EjercicioPrestamo.Entidades;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioPrestamo.Datos
{
    public class TipoPrestamoMapper
    {
        public List<TipoPrestamo> TraerTiposPrestamo()
        {
            string json2 = WebHelper.Get("/api/v1/prestamotipo"); // trae un texto en formato json de una web
            List<TipoPrestamo> resultado = MapList(json2);
            return resultado;
        }

        private List<TipoPrestamo> MapList(string json)
        {
            List<TipoPrestamo> lst = JsonConvert.DeserializeObject<List<TipoPrestamo>>(json);
            return lst;
        }
    }
}
    