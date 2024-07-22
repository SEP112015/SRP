using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP
{
    // Para cumplir con el principio SRP hay que crear dos clases
    // En este caso sería una clase llamada "Persona" y otra clase llamada "CorreoElectrónico"


    //Clase Persona
    public class Persona
    {
        private string nombre;
        private int edad;
        private string direccion;
        private string correoElectronico;

        public Persona(string nombre, int edad, string direccion, string correoElectronico)
        {
            this.nombre = nombre;
            this.edad = edad;
            this.direccion = direccion;
            this.correoElectronico = correoElectronico;
        }

        public void ImprimirDatos()
        {
            Console.WriteLine($"NOMBRE: {nombre}");
            Console.WriteLine($"EDAD: {edad}");
            Console.WriteLine($"DIRECCIÓN: {direccion}");
            Console.WriteLine($"CORREO ELECTRÓNICO: {correoElectronico}");
            Console.WriteLine("\n");
            Console.WriteLine("-----------------------------------------------------");
            
        }

        public string GetCorreoElectronico()
        {
            return correoElectronico;
        }
    }

    public class CorreoElectronico
    {
        public void EnviarCorreo(string destinatario, string mensaje)
        {
            // Lógica para enviar correo electrónico
            Console.WriteLine($"CORREO ENVIADO A:  {destinatario}" );
            Console.WriteLine("MENSAJE:\n");
            Console.WriteLine($"{mensaje}");
            Console.WriteLine("--------------------------------------------------------");
        }
    }

    class Program
    {
        static void Main()
        {
            // Solicitar datos al usuario
            Console.WriteLine("NOMBRE:");
            string nombre = Console.ReadLine();

            Console.WriteLine("EDAD:");
            int edad = int.Parse(Console.ReadLine());

            Console.WriteLine("DIRECCIÓN:");
            string direccion = Console.ReadLine();

            Console.WriteLine("CORREO ELECTRÓNICO:");
            string correoElectronico = Console.ReadLine();
            Console.WriteLine("\n");
            Console.WriteLine("----------------------------------------------------------");
            
            
            // Crear la instancia de Persona
            Persona persona = new Persona(nombre, edad, direccion, correoElectronico);
            persona.ImprimirDatos();

            // Solicitar el mensaje al usuario
            Console.WriteLine("ASUNTO:");
            string mensaje = Console.ReadLine();
            Console.WriteLine("\n");
            Console.WriteLine("-----------------------------------------------------------");
            


            // Enviar el correo electrónico
            CorreoElectronico correo = new CorreoElectronico();
            correo.EnviarCorreo(persona.GetCorreoElectronico(), mensaje);
        }
    }


}
