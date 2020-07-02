using System;
namespace Examen
{
    public class Medico : Persona
    {
        private int puntosDeExperiencia;

        public Medico(string nombre, int edad, string nacion, int sueldo, int puntosDeExperiencia)
        {
            this.Nombre = nombre;
            this.Edad = edad;
            this.Nacion = nacion;
            this.Sueldo = sueldo;
            this.puntosDeExperiencia = puntosDeExperiencia;
        }

        public new string EntregarInfo()
        {
            return base.EntregarInfo() + ", Puntos De Experiencia:" + Convert.ToString(this.puntosDeExperiencia);
        }

        private void Evaluar()
        {

        }

        private void Curar()
        {

        }
    }
}
