using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PrototipoInterfazTemplo_2013.Entidades
{
   public class IntegranteComNomb
    {
        private int idIntegranteComNomb;
        private Miembro miembro;
        private bool presente;

        public IntegranteComNomb()
        { }

        public IntegranteComNomb(int idIntegranteComNomb, Miembro miembro, bool presente)
        {
            this.idIntegranteComNomb = idIntegranteComNomb;
            this.miembro = miembro;
            this.presente = presente;
        }

        public int IdIntegranteComNomb
        {
            set { idIntegranteComNomb = value; }
            get { return idIntegranteComNomb; }
        }

        public Miembro Miembro
        {
            set { miembro = value; }
            get { return miembro; }
        }

        public bool Presente
        {
            set { presente = value; }
            get { return presente; }
        }

        

    }
}
