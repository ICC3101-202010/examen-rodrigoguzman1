using System;
namespace Examen
{
    public abstract class EmptyClass
    {
        string nombre { get; set; }
        int edad { get; set; }
        string nacion { get; set; }
        int sueldo { get; set; }


        public EmptyClass(string nombre, int edad, string nacion, int sueldo)
        {
            this.nombre = nombre;
            this.edad = edad;
            this.nacion = nacion;
            this.sueldo = sueldo;
        }
    }
}
