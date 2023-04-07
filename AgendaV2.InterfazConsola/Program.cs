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
            Contacto contacto = new Contacto(2727, "Julian", "Rinaldi", "1159474835", "Juan bautista alberdi 4427", Convert.ToDateTime(08/05/2001));

            Console.WriteLine(contacto.edad());
            Console.ReadKey();
        }
    }
}
