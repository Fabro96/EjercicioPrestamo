using System;
using EjercicioPrestamo.Entidades;
using EjercicioPrestamo.Datos;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioPrestamos.Negocio
{
    public class TipoPrestamoServicio
    {
        private TipoPrestamoMapper _tipoPrestamoMapper;

        public TipoPrestamoServicio()
        {
            _tipoPrestamoMapper = new TipoPrestamoMapper();

        }

        public List<TipoPrestamo> TraerTiposPrestamo()
        {
            List<TipoPrestamo> result = _tipoPrestamoMapper.TraerTiposPrestamo();
            return result;
        }

    }
}
