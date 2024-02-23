using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreacionClases
{
    public class Profesor : Persona
    {
        public string Area {  get; set; }
        public string Fecha_Contrato {  get; set; }
        public Profesor(string nombre, string apellido, string fecha_nacimiento, int telefono, string direccion, string carnet, string instituto, string fecha_ingreso, string area, string fecha_contrato)
            : base(nombre, apellido, fecha_nacimiento,telefono,direccion) 
        {
            Area = area;
            Fecha_Contrato = fecha_contrato;
        }   

       
    }
}
