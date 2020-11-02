﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioPrestamo.Entidades
{
    [DataContract]
    public class TipoPrestamo
    {
        //ATRIBUTOS
        private string _linea;
        private double _tna;

        //CONSTRUCTOR
        public TipoPrestamo()
        {

        }
        //PROPIEDADES
        [DataMember]
        public string Linea
        {
            set { _linea = value; }
            get { return _linea;  }
        }
        public double TNA
        {
            set { _tna = value; }
            get { return _tna;  }
        }

        //MÉTODOS
    }
}
