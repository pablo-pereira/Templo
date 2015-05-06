using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PrototipoInterfazTemplo_2013.Entidades
{
    class Candidato
    {
        private int idCandidato, cantidadVotos;
        private Miembro miembro;

        public Candidato()
        {
        }

        public Candidato(int idCandidato, int cantidadVotos, int idVotacion, Miembro miembro)
        {
            this.idCandidato = idCandidato;
            this.cantidadVotos = cantidadVotos;            
            this.miembro = miembro;
        }

        public int IdCandidato
        {
            set { idCandidato = value; }
            get { return idCandidato; }
        }

        public int CantidadVotos
        {
            set { cantidadVotos = value; }
            get { return cantidadVotos; }
        }
                
        public Miembro Miembro
        {
            set { miembro = value; }
            get { return miembro; }
        }
    }
}
