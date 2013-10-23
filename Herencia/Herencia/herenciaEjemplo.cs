using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Herencia {

class herenciaEjemplo
    {
       public static void Main(string[] args)
        {
            Persona persona1 = new Persona();
            persona1.Nombre = "Jesús";
            persona1.Edad = 109;
            persona1.telefono = 254587687;
            Console.WriteLine("\ninformación de la persona:\n");
            persona1.Imprimir();

            Empleado empleado1 = new Empleado();
            empleado1.Nombre = "Toribia";
            empleado1.Edad=48;
            empleado1.Sueldo = 25000;
            //empleado1.Telefono =  8794324893;
            empleado1.Curp = "GJRTT452423TTF";
            Console.WriteLine("\n\n\ninformación del empleado(a):\n");
            empleado1.Imprimir();

            Console.ReadKey();
        }
    }
}