namespace Interfaces
{
    internal class Cajero : Empleado, IEmpleadoProductos, IComunicacion, IPagos, ITrabajo
    {
        public Cajero(string NombreCajero) : base(NombreCajero)
        {

        }

        public bool ManejoProductos()
        {
            return true;
        }

        public string TipoPersona()
        {
            return "Cliente"; 
        }

        public bool EsBoliviano()
        {
            return true;
        }

        public int HorasTrabajo()
        {
            return 8;
        }
    }
}
