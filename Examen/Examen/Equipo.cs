using System;
using System.Collections.Generic;

namespace Examen
{
    public class Equipo : IInformacion
    {
        private string nombre;
        public string Nombre
        {
            get
            {
                return nombre;
            }
            set
            {
                nombre = value;
            }
        }
        private string tipo;
        public string Tipo
        {
            get
            {
                return tipo;
            }
            set
            {
                if(value == "Nacional" || value == "Liga")
                {
                    tipo = value;
                } else
                {
                    Console.WriteLine("Tipo no valido");
                }
            }
        }
        private List<Jugador> jugadores = new List<Jugador>();
        private Entrenador entrenador;
        private Medico medico;


        public Equipo(string nombre, string tipo)
        {
            this.Nombre = nombre;
            this.Tipo = tipo;
        }

        public void AgregarJugador(string nombre,int edad, string nacion, int sueldo, int puntosDeAtaque, int puntosDeDefensa, int numeroDeCamiseta)
        {
            if(this.tipo == "Nacional" && nacion == this.nombre)
            {
                Jugador jugador = new Jugador(nombre, edad, nacion, sueldo, puntosDeAtaque,puntosDeDefensa, numeroDeCamiseta);
                jugadores.Add(jugador);

            } else if (this.tipo == "Liga")
            {
                Jugador jugador = new Jugador(nombre, edad, nacion, sueldo, puntosDeAtaque, puntosDeDefensa, numeroDeCamiseta);
                jugadores.Add(jugador);
            } else
            {
                Console.WriteLine("Jugador no es del mismo pais");
            }
        }

        public void AgregarEntrenador(string nombre, int edad, string nacion, int sueldo, int puntosDeTactica)
        {
            this.entrenador = new Entrenador(nombre, edad, nacion, sueldo, puntosDeTactica);
        }

        public void AgregarMedico(string nombre, int edad, string nacion, int sueldo, int puntosDeExperiencia)
        {
            this.medico = new Medico(nombre, edad, nacion, sueldo, puntosDeExperiencia);
        }

        public string EntregarInfo()
        {
            string info = "Nombre: " + this.nombre + ", Tipo: " + this.tipo + ", Entrenador: " + this.entrenador.Nombre + ", Medico: " + this.medico.Nombre + ", Jugadores: ";
            foreach(Jugador jugador in jugadores)
            {
                info += jugador.Nombre;
            }
            return info;
        }

    }
}
