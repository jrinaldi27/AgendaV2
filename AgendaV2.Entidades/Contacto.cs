using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendaV2.Entidades
{
    public class Contacto
    {
        private long _codigo;
        private string _nombre;
        private string _apellido;
        private string _telefono;
        private string _direccion;
        private DateTime _fechaNacimiento;
        private int _llamadas;

        public long Codigo { get => _codigo; }
        public string Nombre { get => _nombre; set => _nombre = value; }
        public string Apellido { get => _apellido; set => _apellido = value; }
        public string Telefono { get => _telefono; set => _telefono = value; }
        public string Direccion { get => _direccion; set => _direccion = value; }

        public DateTime FechaNacimiento  { get => _fechaNacimiento; set => _fechaNacimiento = value; }

        public int Llamadas { get => _llamadas; }


        public Contacto(long codigo, string nombre, string apellido, string telefono, string direccion, DateTime fechaNacimiento)
        {
            _codigo = codigo;
            _nombre = nombre;
            _apellido = apellido;
            _telefono = telefono;
            _direccion = direccion;
            _fechaNacimiento = fechaNacimiento;
            _llamadas = 0;
        }

        public int edad()
        {
            double dias = (DateTime.Now - FechaNacimiento).TotalDays;

            return Convert.ToInt32(dias / 365);
        }

        public void llamar()
        {
            _llamadas++;
        }
    }
}
