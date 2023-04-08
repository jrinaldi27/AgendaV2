using AgendaV2.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendaV2.InterfazConsola
{
    class Program
    {
        static void Main(string[] args)
        {
            Agenda a = new Agenda("Agenda", "Contactos", 10);
            Utils u = new Utils();
            u.DesplegarMenu();


            Contacto c1 = new Contacto(123, "Julian", "Rinaldi", "115", "jbaba", Convert.ToDateTime("08 / 05 / 2001"));
            c1.llamar();
            Contacto c2 = new Contacto(124, "Pedro", "Rinaldo", "115", "jbaba", Convert.ToDateTime("08 / 05 / 2001"));
            Contacto c3 = new Contacto(125, "Marselo", "Rinaldi", "115", "jbaba", Convert.ToDateTime("08 / 05 / 2001"));
            a.AgregarContacto(c1);
            a.AgregarContacto(c2);
            a.AgregarContacto(c3);


            bool activo = true;

            do
            {
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        a.ListarContactos();
                        break;

                    case "2":
                        Contacto c = u.pedirDatos();
                        a.AgregarContacto(c);
                        break;

                    case "3":
                        Console.WriteLine("Ingrese codigo para eliminar contacto");
                        int codigo = Convert.ToInt32(Console.ReadLine());
                        a.EliminarContacto(codigo);
                        break;

                    case "4":
                        Contacto cont = new Contacto();
                         cont = a.TraerContactoFrecuente();
                        Console.WriteLine("El contacto mas frecuente es" + cont.Nombre);
                        break;

                    case "x":
                        activo = false;
                        break;

                }

            } while (activo);
        }
    }
}
