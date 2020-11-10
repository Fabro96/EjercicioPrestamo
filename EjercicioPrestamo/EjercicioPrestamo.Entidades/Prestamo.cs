using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioPrestamo.Entidades
{
    [DataContract]
    public class Prestamo
    {
        //ATRIBUTOS
        private string _linea;
        private double _tna;
        private int _plazo;
        private double _monto;
        private string _usuario;
        private int _id;

        //CONSTRUCTOR
        public Prestamo()
        {

        }
        public Prestamo(int id, string linea, double tna, int plazo, double monto, string usuario)
        {
            this._id = id;
            this._linea = linea;
            this._tna = tna;
            this._plazo = plazo;
            this._monto = monto;
            this._usuario = usuario;
            
        }

        //PROPIEDADES
        [DataMember]
        public string Linea
        {
            set { _linea = value; }
            get { return _linea;  }
        }
        [DataMember]
        public double TNA
        {
            set { _tna = value; }
            get { return _tna;  }
        }
        [DataMember]
        public int Plazo
        {
            set { _plazo = value; }
            get { return _plazo;  }
        }
        [DataMember]
        public double Monto
        {
            set { _monto = value; }
            get { return _monto;  }
        }
        [DataMember]
        public string Usuario
        {
            set { _usuario = value; }
            get { return _usuario;  }
        }
        [DataMember]
        public int ID
        {
            set { _id = value; }
            get { return _id;  }
        }
        [DataMember]
        public double CuotaCapital
        {
            get { return (Monto / Plazo); }
        }
        [DataMember]
        public double CuotaInteres
        {
            get { return (CuotaCapital * (TNA / 12 / 100)); }
        }
        [DataMember]
        public double CuotaTotal
        {
            get { return (CuotaCapital + CuotaInteres); }
        }



    }
}
