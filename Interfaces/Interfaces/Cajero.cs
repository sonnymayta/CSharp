namespace Interfaces
{
    internal class Cajero : Empleado, IEmpleadoProductos, IComunicacion, IPagos, ITrabajoPorDia
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

        int ITrabajoPorDia.HorasTrabajo()
        {
            return 8;
        }

        int IPagos.HorasTrabajo()
        {
            return 120;
        }
    }
}
