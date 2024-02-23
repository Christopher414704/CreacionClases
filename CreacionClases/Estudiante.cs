using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreacionClases
{
    public class Estudiante : Persona
    {
        public string Carnet {  get; set; }
        public string Instituto {  get; set; }
        public string Fecha_Ingreso {  get; set; }


        public Estudiante(string nombre, string apellido, string fecha_nacimiento, int telefono, string direccion, string carnet, string instituto, string fecha_ingreso)
            : base(nombre, apellido, fecha_nacimiento, telefono, direccion)
        {
            Carnet = carnet;
            Instituto = instituto;
            Fecha_Ingreso = fecha_ingreso;
            
        }
    }
}
