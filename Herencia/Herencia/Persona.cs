using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Herencia
{
    public class Persona
    {
        public string nombre;
        public int edad;
        public int telefono;

        public string Nombre
        {
            set
            {
                nombre = value;
            }
            get
            {
                return nombre;
            }
        }

        public int Edad
        {
            set
            {
                edad = value;
            }
            get
            {
                return edad;
            }
        }
        
        public int Telefono
        {
        	
        	set
        	{
        		telefono = value;
        	}
        	
        	get
        	{
        		return telefono;
        	}
        }

        public void Imprimir()
        {
            Console.WriteLine("Nombre: " + Nombre);
            Console.WriteLine("Edad: " + Edad);
            Console.WriteLine("Teléfono: " + Telefono);
        }
    }
}
