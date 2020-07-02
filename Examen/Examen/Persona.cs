using System;
namespace Examen
{
    public class Persona : IInformacion
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
                if (value.GetType().Name == "string")
                {
                    nombre = value;
                }
                else
                {
                    Console.WriteLine("Nombre no valido");
                }
            }
        }
        private int edad;
        public int Edad
        {
            get
            {
                return edad;
            }
            set
            {
                if (value.GetType().Name == "int")
                {
                    edad = value;
                }
                else
                {
                    Console.WriteLine("Edad no valida");
                }
            }
        }
        private string nacion;
        public string Nacion
        {
            get
            {
                return nacion;
            }
            set
            {
                if (value.GetType().Name == "string")
                {
                    nacion = value;
                }
                else
                {
                    Console.WriteLine("Nación no valida");
                }
            }
        }
        private int sueldo;
        public int Sueldo
        {
            get
            {
                return sueldo;
            }
            set
            {
                if (value.GetType().Name == "int")
                {
                    sueldo = value;
                }
                else
                {
                    Console.WriteLine("Sueldo no valido");
                }
            }
        }

        public string EntregarInfo()
        {
            return "Nombre: " + this.Nombre + ", Edad: " + Convert.ToString(this.Edad) + ", Nación: " + this.Nacion + ", Sueldo: " + Convert.ToString(this.Sueldo);
        }


    }
    
}
