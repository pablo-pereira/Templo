using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace PrototipoInterfazTemplo_2013.Entidades
{
    public class Sesion
    {
        private int idSesion;
        private DateTime fechaHoraInicio, fechaHoraFin;
        private Miembro primeraOracion, segundaOracion;
        private BindingList<IntegranteComNomb> listaIntegranteComNomb;

        public Sesion()
        {
            idSesion = 0;
            listaIntegranteComNomb = new BindingList<IntegranteComNomb>();
        }

        public Sesion(int idSesion, DateTime fechaHoraInicio, DateTime fechaHoraFin, Miembro primeraOracion, Miembro segundaOracion, BindingList<IntegranteComNomb> listaIntegranteComNomb)
        {
            this.idSesion = idSesion;
            this.fechaHoraInicio = fechaHoraInicio;
            this.fechaHoraFin = fechaHoraFin;
            this.primeraOracion = primeraOracion;
            this.segundaOracion = segundaOracion;
            this.listaIntegranteComNomb = listaIntegranteComNomb;
        }

        public int IdSesion
        {
            set { idSesion = value; }
            get { return idSesion; }
        }

        public DateTime FechaHoraInicio
        {
            set { fechaHoraInicio = value; }
            get { return fechaHoraInicio; }
        }

        public DateTime FechaHoraFin
        {
            set { fechaHoraFin = value; }
            get { return fechaHoraFin; }
        }

        public Miembro PrimeraOracion
        {
            set { primeraOracion = value; }
            get { return primeraOracion; }
        }

        public Miembro SegundaOracion
        {
            set { segundaOracion = value; }
            get { return segundaOracion; }
        }

        public BindingList<IntegranteComNomb> ListaIntegranteComNomb
        {
            set { listaIntegranteComNomb = value; }
            get { return listaIntegranteComNomb; }
        }

    }
}
