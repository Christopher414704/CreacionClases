using CreacionClases;
using System;

namespace Personas
{
    class Programa
    {
        public static void Main(string[] args)
        {
            Estudiante oEstudiante = new Estudiante ("Cristofer","Antonio","26/04/2004",31434501,"2da Calle C","09-07-23-1218","Instituto Privado el Porvenir","15/1/2021");
            Profesor oProfesor = new Profesor("Julio","Cesar","15/7/1995",65784356,"Barrio la Esperanza","7689-16-4214","Insituto el Moriao","14/5/2005","Matematicas","15/1/2021");


            Console.WriteLine($"Informacion del Estudiante:");
            Console.WriteLine($"Nombre: {oEstudiante.Nombre} {oEstudiante.Apellido}");
            Console.WriteLine($"Fecha Nacimiento: {oEstudiante.Fecha_Nacimiento}");
            Console.WriteLine($"Numero Telefonico: {oEstudiante.Telefono}");
            Console.WriteLine($"Direccion: {oEstudiante.Direccion}");
            Console.WriteLine($"No.Carnet: {oEstudiante.Carnet}");
            Console.WriteLine($"Fecha de Ingreso: {oEstudiante.Fecha_Ingreso}");

            Console.WriteLine($"Informacion del Profesor:");
            Console.WriteLine($"Nombre: {oProfesor.Nombre} {oProfesor.Apellido}");
            Console.WriteLine($"Fecha Nacimiento: {oProfesor.Fecha_Nacimiento}");
            Console.WriteLine($"Numero Telefonico: {oProfesor.Telefono}");
            Console.WriteLine($"Direccion: {oProfesor.Direccion}");
            Console.WriteLine($"Area: {oProfesor.Area}");
            Console.WriteLine($"Fecha de Contrato: {oProfesor.Fecha_Contrato}");

        }
    }


}

