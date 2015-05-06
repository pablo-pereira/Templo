using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PrototipoInterfazTemplo_2013.Entidades
{
    class Departamento
    {
        private int idDepartamento;
        private string nombre, descripcion;        

        public Departamento()
        {            
        }

        public Departamento(int idDepartamento, string nombre, string descripcion)
        {
            this.idDepartamento = idDepartamento;
            this.nombre = nombre;
            this.descripcion = descripcion;            
        }

        public int IdDepartamento
        {
            set { idDepartamento = value; }
            get { return idDepartamento; }
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

    }
}
