using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo1_Clases
{
    class Persona
    {
        
        string id;
        string nombre;
        string direccion;
        string celular;
        string email;

        
        public Persona()
        { }

        public Persona(string id, string nombre, string direccion, string celular, string email)
        {
            this.Id = id;
            this.Nombre = nombre;
            this.Direccion = direccion;
            this.celular = celular;
            this.Email = email;
        }


        //Propiedades
        public string Id { get { return this.id; } set { this.id = value; } }
       public string Nombre { get { return this.nombre; } set { this.nombre = value; } }
       public string Direccion { get { return this.direccion; } set { this.direccion = value; } }
       public string Telf { get { return this.celular; } set { this.celular = value; } }
       public string Email { get { return this.email; } set { this.email = value; } }
    }
}
