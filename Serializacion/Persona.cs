using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
namespace Serializacion
{
    [Serializable]
    public class Persona
    {
        
        string nombre;
        string apellido;
        string edad;
        
        




        public Persona(string Nombre,string Apellido,string Edad)
        {

            this.nombre = Nombre;
            this.apellido = Apellido;
            this.edad = Edad;
            



        }

        public void Getname()
        {
            Console.WriteLine(nombre);
        }







    }
}
