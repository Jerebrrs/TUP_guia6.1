using System.Text.RegularExpressions;

namespace Ejercicio_1.Models
{
    public class RegistroVehiculo : IComparable<RegistroVehiculo>
    {
        public string Patente { get; }
        public string Serie{ get; }
        Persona propietario=null;

        public RegistroVehiculo(string patente,Persona pers)
        {
            this.Patente = patente;
            this.propietario = pers;

            Match m = Regex.Match(patente.Trim(), @"^[A-Z]{3}\s*[0-9]{3}$", RegexOptions.IgnoreCase);
            if (m.Success == false)
                throw new FormatException();

        }

        public int CompareTo(RegistroVehiculo? other)
        {
            if (other !=null)
            {
                return Patente.CompareTo(other.Patente);
            }
            return -1;
        }

        public override string ToString()
        {
            return $@"{Patente} - Propietario:{propietario.Nombre}({propietario.Dni})";
        }
    }
}
