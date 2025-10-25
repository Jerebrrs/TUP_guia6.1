

using Ejercicio_1.Models.Exception;

namespace Ejercicio_1.Models
{
    public class Persona
    {
        public string Nombre { get; }

        int dni;
        public int Dni
        {
            get
            {
                return dni;
            }

            set
            {
                if (value <= 1000000)
                {
                    throw new RangoDniIncorrectoException();
                }

                dni = value;
            }
        }

        public Persona(string nombre,int dni)
        {
            this.Nombre = nombre;
            this.Dni = dni;
        }
    }
}
