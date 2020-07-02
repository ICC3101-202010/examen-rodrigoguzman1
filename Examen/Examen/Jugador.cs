using System;
namespace Examen
{
    public class Jugador : Persona
    {
        private int puntosDeAtaque { get; set; }
        private int puntosDeDefensa { get; set; }
        private int numeroDeCamiseta { get; set; }

        public delegate void JugadorLesionadoEventhandler(object source, EventArgs args);

        public event JugadorLesionadoEventhandler JugadorLesionado;

        public Jugador(string nombre, int edad, string nacion, int sueldo, int puntosDeAtaque, int puntosDeDefensa, int numeroDeCamiseta)
        {
            this.Nombre = nombre;
            this.Edad = edad;
            this.Nacion = nacion;
            this.Sueldo = sueldo;
            this.puntosDeAtaque = puntosDeAtaque;
            this.puntosDeDefensa = puntosDeDefensa;
            this.numeroDeCamiseta = numeroDeCamiseta;
        }

        public new string EntregarInfo()
        {
            return base.EntregarInfo() + ", Puntos De Ataque:" + Convert.ToString(this.puntosDeAtaque) + ", Puntos De Defensa:" + Convert.ToString(this.puntosDeDefensa) + ", Numero De Camiseta:" + Convert.ToString(this.numeroDeCamiseta);
        }

        protected virtual void OnJugadorLesionado()
        {
            if (JugadorLesionado != null)
            {
                JugadorLesionado(this, EventArgs.Empty);
            }

        }
    }
}
