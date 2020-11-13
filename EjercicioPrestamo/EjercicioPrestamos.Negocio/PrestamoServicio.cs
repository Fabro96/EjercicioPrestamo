using EjercicioPrestamo.Datos;
using EjercicioPrestamo.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioPrestamos.Negocio
{
    public class PrestamoServicio
    {
        private PrestamoMapper _prestamoMapper;

        public PrestamoServicio()
        {
            this._prestamoMapper = new PrestamoMapper();
        }

        public List<Prestamo> TraerPrestamos()
        {
            List<Prestamo> result = _prestamoMapper.GetPrestamos();
            return result;
        }

        public int AgregarPrestamo(Prestamo prestamo)
        {
            ResultadoTransaccion resultante = _prestamoMapper.Insert(prestamo);

            if (resultante.IsOk)
                return resultante.Id;
            else
                throw new Exception("Hubo un error en la petición al servidor. Detalle: " + resultante.Error);
        }
    }
}
