using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PrototipoInterfazTemplo_2013.Entidades
{
    class Actividad
    {
        private int idActividad, requeridos;
        private string nombre, descripcion;
        private Dificultad dificultad;
        private Departamento departamento;

        public Actividad()
        { }

        public Actividad(int idActividad, string nombre, string descripcion, int requeridos, Dificultad dificultad, Departamento departamento)
        {
            this.idActividad = idActividad;
            this.nombre = nombre;
            this.descripcion = descripcion;
            this.requeridos = requeridos;
            this.dificultad = dificultad;
            this.departamento = departamento;
        }

        public int IdActividad
        {
            set { idActividad = value; }
            get { return idActividad; }
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

        public int Requeridos
        {
            set { requeridos = value; }
            get { return requeridos; }
        }

        public Dificultad Dificultad
        {
            set { dificultad = value; }
            get { return dificultad; }
        }

        public Departamento Departamento
        {
            set { departamento = value; }
            get { return departamento; }
        }
    }
}
