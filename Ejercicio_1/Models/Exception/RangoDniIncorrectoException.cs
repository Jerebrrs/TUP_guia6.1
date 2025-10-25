
namespace Ejercicio_1.Models.Exception
{
    public class RangoDniIncorrectoException : ApplicationException
    {

        public RangoDniIncorrectoException() : base("El dni debe ser mayor a 1000000") { }
        public RangoDniIncorrectoException(string msg) : base(msg) { }
        public RangoDniIncorrectoException(string msg, IOException inner) : base(msg, inner){}
    }
}
