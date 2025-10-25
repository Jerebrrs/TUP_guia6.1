
namespace Ejercicio_1.Models
{
    internal class DepartamentoVehicular
    {

        public int CantidadRegistros
        {
            get { return registro.Count; }
        }
        private int serie;
        List<RegistroVehiculo> registro = new List<RegistroVehiculo>();


        public void RegistrarVehiculo(Persona propietario, string patente)
        {
            registro.Add(new RegistroVehiculo(patente, propietario));
            
        }

        public void OrdenarRegistros()
        {
            registro.Sort();
        }
        public RegistroVehiculo VerRegistro(int idx)
        {
            if (idx >= 0 && idx < CantidadRegistros)
            {
                return registro[idx];
            }
            return null;
        }
    }
}
