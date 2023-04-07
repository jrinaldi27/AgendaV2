using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendaV2.Entidades
{
    public class Agenda
    {
        private string _nombre;
        private string _tipo;
        private List<Contacto> _contactos;
        private int _cantidadMaximaDeContactos;

        public string Nombre { get => _nombre; set => _nombre = value; }
        public string Tipo { get => _tipo; set => _tipo = value; }

        public int cantidadMaximaContactos { get => _cantidadMaximaDeContactos; set => _cantidadMaximaDeContactos = value; }

        public Agenda(string nombre, string tipo, int cantMaximaContactos)
        {
            _nombre = nombre;
            _tipo = tipo;
            _contactos = new List<Contacto>();
            _cantidadMaximaDeContactos = cantMaximaContactos;

        }


        public void AgregarContacto(Contacto c)
        {
            if (_contactos.Count <= _cantidadMaximaDeContactos)
            {
                _contactos.Add(c);

            }
            else
            {
                Console.WriteLine("La agenda esta completa");
            }
        }

        public void EliminarContacto(int codigo)
        {
            int Eliminados = 0;
            foreach (Contacto c in _contactos)
            {
                if (c.Codigo == codigo)
                {
                    _contactos.Remove(c);

                    Console.WriteLine("Se elimino correctamente al contacto con el codigo " + codigo);
                    Eliminados = 1;
                    break;
                }



            }
            if (Eliminados == 0)
            {
                Console.WriteLine("No se pudo eliminar el contacto");
            }




        }

        public Contacto TraerContactoFrecuente()
        {
            int codigoContactoMasFrecuente = 0;
            int cantidadLlamadas = 0;
            foreach (Contacto c in _contactos)
            {
                if (c.Llamadas > cantidadLlamadas)
                {
                    codigoContactoMasFrecuente = Convert.ToInt32( c.Codigo);
                    cantidadLlamadas = c.Llamadas;
                }
            }


            return _contactos.Find(c => c.Codigo == codigoContactoMasFrecuente);
        }

        public void ListarContactos()
        {
            foreach(Contacto c in _contactos)
            {
                Console.WriteLine(c.ToString());
            }
        }
    }
}
