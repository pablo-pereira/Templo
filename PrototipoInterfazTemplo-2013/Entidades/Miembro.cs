using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PrototipoInterfazTemplo_2013.Entidades
{
    public class Miembro
    {
        private int idMiembro;
        private string nombre, apellido, telefono, mail, direccion;
        private DateTime fechaBaja;

        public Miembro()
        { }

        public Miembro(int idMiembro, string nombre, string apellido, string telefono, string mail, string direccion)
        {
            this.idMiembro = idMiembro;
            this.nombre = nombre;
            this.apellido = apellido;
            this.telefono = telefono;
            this.mail = mail;
            this.direccion = direccion;           
        }

        public Miembro(int idMiembro, string nombre, string apellido, string telefono, string mail, string direccion, DateTime fechaBaja)
        {
            this.idMiembro = idMiembro;
            this.nombre = nombre;
            this.apellido = apellido;
            this.telefono = telefono;
            this.mail = mail;
            this.direccion = direccion;
            this.fechaBaja = fechaBaja;
        }

        public int IdMiembro
        {
            set { idMiembro = value; }
            get { return idMiembro; }
        }

        public string Nombre
        {
            set { nombre = value; }
            get { return nombre; }
        }

        public string Apellido
        {
            set { apellido = value; }
            get { return apellido; }
        }

        public string Telefono
        {
            set { telefono = value; }
            get { return telefono; }
        }

        public string Mail
        {
            set { mail = value; }
            get { return mail; }
        }

        public string Direccion
        {
            set { direccion = value; }
            get { return direccion; }
        }

        public string NombreCompleto
        {
            get { return  apellido + ", "+nombre; }
        }

        public DateTime FechaBaja
        {
            set { fechaBaja = value; }
            get { return fechaBaja; }
        }
    }
}
