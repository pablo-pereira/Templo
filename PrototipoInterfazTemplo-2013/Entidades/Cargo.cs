using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PrototipoInterfazTemplo_2013.Entidades
{
    class Cargo
    {
        private int idCargo, cupo;
        private Departamento departamento;
        private string nombre, descripcion;
        private bool mayoriaSimple, miembroJunta, mitadMasUno;

        public Cargo()
        { }

        public Cargo(int idCargo, string nombre, string descripcion, int cupo, Departamento departamento, bool mayoriaSimple, bool miembroJunta, bool mitadMasUno)
        {
            this.idCargo = idCargo;
            this.nombre = nombre;
            this.descripcion = descripcion;
            this.cupo = cupo;
            this.departamento = departamento;
            this.mayoriaSimple = mayoriaSimple;
            this.mitadMasUno = mitadMasUno;
            this.miembroJunta = miembroJunta;
        }

        public int IdCargo
        {
            set { idCargo = value; }
            get { return idCargo; }
        }

        public int Cupo
        {
            set { cupo = value; }
            get { return cupo; }
        }

        public string Nombre
        {
            set { nombre = value; }
            get { return nombre; }
        }

        public string Descripcion
        {
            set { descripcion = value; }
            get { return descripcion; }
        }

        public Departamento Departamento
        {
            set { departamento = value; }
            get { return departamento; }
        }

        public bool MayoriaSimple
        {
            set { mayoriaSimple = value; }
            get { return mayoriaSimple; }
        }

                public bool MiembroJunta
        {
            set { miembroJunta = value; }
            get { return miembroJunta; }
        }

        public bool MitadMasUno
        {
            set { mitadMasUno = value; }
            get { return mitadMasUno; }
        }

    }
}
