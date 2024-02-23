using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreacionClases
{
    public class Persona
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Fecha_Nacimiento {  get; set; }
        public int Telefono {  get; set; }
        public string Direccion {  get; set; }

        public Persona() { }

        public Persona(string nombre, string apellido, string fecha_nacimiento, int telefono, string direccion)
        {
            Nombre = nombre;
            Apellido = apellido;
           Fecha_Nacimiento = fecha_nacimiento;
            Telefono = telefono;
            Direccion = direccion;
        }

        
    }
}
