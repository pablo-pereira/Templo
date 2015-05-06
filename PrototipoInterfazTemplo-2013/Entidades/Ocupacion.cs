using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PrototipoInterfazTemplo_2013.Entidades
{
    class Ocupacion
    {
        private int idOcupacion;
        private DateTime fechaDesde, fechaHasta;
        private Miembro miembro;
        private Cargo cargo;

        public Ocupacion()
        { }

        public Ocupacion(int idOcupacion, DateTime fechaDesde, DateTime fechaHasta, Miembro miembro, Cargo cargo)
        {
            this.idOcupacion = idOcupacion;
            this.fechaDesde = fechaDesde;
            this.fechaHasta = fechaHasta;
            this.miembro = miembro;
            this.cargo = cargo;
        }

        public int IdOcupacion
        {
            set { idOcupacion = value; }
            get { return idOcupacion; }
        }

        public DateTime FechaDesde
        {
            set { fechaDesde = value; }
            get { return fechaDesde; }
        }

        public DateTime FechaHasta
        {
            set { fechaHasta = value; }
            get { return fechaHasta; }
        }

        public Miembro Miembro
        {
            set { miembro = value; }
            get { return miembro; }
        }

        public Cargo Cargo
        {
            set { cargo = value; }
            get { return cargo; }
        }

    }
}
