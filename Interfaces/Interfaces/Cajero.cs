namespace Interfaces
{
    internal class Cajero : Empleado, IEmpleadoProductos
    {
        public Cajero(string NombreCajero) : base(NombreCajero)
        {

        }

        public bool ManejoProductos()
        {
            return true;
        }
    }
}
