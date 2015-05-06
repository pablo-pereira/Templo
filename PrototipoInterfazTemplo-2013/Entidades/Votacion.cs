using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace PrototipoInterfazTemplo_2013.Entidades
{
    class Votacion
    {
        private int idVotacion;
        private BindingList<Candidato> listaCandidatos;
        private Cargo cargo;
        private Sesion sesion;

        public Votacion()
        {
            listaCandidatos = new BindingList<Candidato>();
        }

        public Votacion(int idVotacion, BindingList<Candidato> listaCandidatos, Cargo cargo, Sesion sesion)
        {
            this.idVotacion = idVotacion;
            this.listaCandidatos = listaCandidatos;
            this.cargo = cargo;
            this.sesion = sesion;
        }

        public int IdVotacion
        {
            set { idVotacion = value; }
            get { return idVotacion; }
        }

        public BindingList<Candidato> ListaCandidatos
        {
            set { listaCandidatos = value; }
            get { return listaCandidatos; }
        }

        public Cargo Cargo
        {
            set { cargo = value; }
            get { return cargo; }
        }

        public Sesion Sesion
        {
            set { sesion = value; }
            get { return sesion; }
        }
    }
}
