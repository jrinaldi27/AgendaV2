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
            Agenda a = new Agenda("Agenda de Julian", "comun", 3);
            Contacto contacto = new Contacto(1022, "Julian", "Rinaldi", "1159474448", "P124", Convert.ToDateTime("08/05/2001"));
            Contacto contacto2 = new Contacto(1023, "Sancho", "Panza", "1151237818", "P125", Convert.ToDateTime("19/07/1999"));
            Contacto contacto3 = new Contacto(1024, "Julian", "Rinaldi", "1131274648", "P126", Convert.ToDateTime("09/04/1982"));

            a.AgregarContacto(contacto);
            a.AgregarContacto(contacto2);
            a.AgregarContacto(contacto3);
            for (int i = 0; i< 10; i++) {
                contacto2.llamar();
            }
            a.ListarContactos();
            Contacto MasFrecuente = a.TraerContactoFrecuente();
            Console.WriteLine("El contacto mas frecuente es " + MasFrecuente.Nombre + " Con " + MasFrecuente.Llamadas + " llamadas");
            a.EliminarContacto(1023);
            a.ListarContactos();

            Console.ReadKey();
        }
    }
}
