using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioPrestamo.Entidades
{
    [DataContract]
    public class Operador
    {
        //ATRIBUTOS
        private List<Prestamo> _prestamos;
        private double _comision;
        private double _porcentajeComision;

        //CONTRUCTOR
        public Operador()
        {

        }

        //PROPIEDADES
        [DataMember]
        public List<Prestamo> Prestamos
        {
            get { return _prestamos; }
        }
        [DataMember]
        public double Comision
        {
            set { _comision = value; }
            get { return _comision;  }
        }
        [DataMember]
        public double PorcentajeComision
        {
            get { return _comision * 0.15; }
        }

        //MÉTODOS

    }
}
