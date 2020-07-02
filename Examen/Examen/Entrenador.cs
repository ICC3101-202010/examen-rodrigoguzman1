using System;
namespace Examen
{
    public class Entrenador : Persona
    {
        private int puntosDeTactica;

        public Entrenador(string nombre, int edad, string nacion, int sueldo, int puntosDeTactica)
        {
            this.Nombre = nombre;
            this.Edad = edad;
            this.Nacion = nacion;
            this.Sueldo = sueldo;
            this.puntosDeTactica = puntosDeTactica;
        }

        public new string EntregarInfo()
        {
            return base.EntregarInfo() + ", Puntos De Tactica:" + Convert.ToString(this.puntosDeTactica);
        }

        public void OnJugadorLesionado(object source, EventArgs e)
        {
            this.CambiarJugador();
        }

        private void CambiarJugador()
        {

        }

    }
}
