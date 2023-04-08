using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendaV2.Entidades
{
    public class Utils
    {
        public Utils()
        {

        }
        public void DesplegarMenu()
        {
            string mensaje = "Bienvenido a la agenda " + "\n" + "Pulse 1 para listar contactos" +
                            "\n" + "Pulse 2 para agregar un contacto" + "\n" + "Pulse 3 para eliminar un contacto" +
                            "\n" + "Pulse 4 para traer contacto mas frecuente" + "\n" + "Pulse x para salir";

            Console.WriteLine(mensaje);
        }

        public Contacto pedirDatos()
        {
            Console.WriteLine("Ingrese codigo:");
            long codigo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese nombre:");

            string nombre = Console.ReadLine();
            Console.WriteLine("Ingrese apellido:");
            string apellido = Console.ReadLine();
            Console.WriteLine("Ingrese telefono:");
            string telefono = Console.ReadLine();
            Console.WriteLine("Ingrese direccion:");
            string direccion = Console.ReadLine();
            Console.WriteLine("Ingrese fecha de nacimiento:");
            string fechaNacimiento = Console.ReadLine();

            Contacto c = new Contacto(codigo, nombre, apellido, telefono, direccion, Convert.ToDateTime(fechaNacimiento));


            return c;
        }

        

    }
}
