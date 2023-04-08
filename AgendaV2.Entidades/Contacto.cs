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

        public DateTime FechaNacimiento { get => _fechaNacimiento; set => _fechaNacimiento = value; }

        public int Llamadas { get => _llamadas; }

        public Contacto()
        {

        }
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
            Double calculo = (DateTime.Now - _fechaNacimiento).TotalDays;
            int edad = Convert.ToInt32(calculo) / 365;

            return edad;
        }

        public void llamar()
        {
            _llamadas++;
        }

        public string ToString()
        {
            return string.Format("Codigo de contacto: {0} \nNombre y apellido: {1} {2} \nTelefono: {3}  \ndireccion: {4} \nllamadas: {5} ",
                                  _codigo, _nombre, _apellido, _telefono, _direccion, _llamadas);
        }
    }
}
