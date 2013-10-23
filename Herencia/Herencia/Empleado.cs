using System;

namespace Herencia {

public class Empleado : Persona
    {
        public float sueldo;
        public string curp;

        public float Sueldo
        {
            set
            {
                sueldo = value;
            }
            get
            {
                return sueldo;
            }
        }
        
        public string Curp
        {
        	
        	set
        	{
        		curp = value;
        	}
        	
        	get
        	{
        		
        		return curp;
        	}
        }

        new public void Imprimir()
        {
            base.Imprimir();
            Console.WriteLine("Sueldo: " + Sueldo);
            Console.WriteLine("CURP: "+ Curp);
        }
    }
}