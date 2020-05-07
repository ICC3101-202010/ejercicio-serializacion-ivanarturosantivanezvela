using System;
using System.Collections.Generic;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using System.IO;

namespace Serializacion
{
    class MainClass
    {
        public static void Main(string[] args)
        {

            bool accion = false;
            
           
            List<Persona> personas = new List<Persona>();
            while (!accion)
            {
                Console.WriteLine("Eliga su opcion: 1)Crear persona   2)Ver personas    3)Guardar persona   4) Cargar persona ");
                string opcion = Console.ReadLine();
                if (opcion == "1")
                {
                    Console.WriteLine("Nombre: ");
                    string nombre1 = Console.ReadLine();
                    Console.WriteLine("Apelido: ");
                    string apellido1 = Console.ReadLine();
                    Console.WriteLine("Edad: ");
                    string edad1 = Console.ReadLine();

                    Persona persona = new Persona(nombre1, apellido1, edad1);
                    personas.Add(persona);
                    IFormatter formatter = new BinaryFormatter();
                    Stream stream = new FileStream("MyFile.bin", FileMode.Create, FileAccess.Write, FileShare.None);
                    formatter.Serialize(stream, persona);
                    stream.Close();
                    continue;



                }
                if (opcion == "2")
                {
                    foreach(Persona person in personas)
                    {

                        person.Getname();
                        IFormatter formatter = new BinaryFormatter();
                        Stream stream = new FileStream("MyFile.bin", FileMode.Open, FileAccess.Read, FileShare.Read);
                        Persona obj = (Persona)formatter.Deserialize(stream);
                        stream.Close();

                        foreach(Persona per in personas)
                        {
                            per.Getname();

                        }




                    }


                }
                if (opcion == "3")
                {


                    Console.WriteLine("Guardado");


                }
                if (opcion == "4")
                {

                    Console.WriteLine("Cargada");
                }






            }















        }
    }
}
