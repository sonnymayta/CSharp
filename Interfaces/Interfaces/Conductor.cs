namespace Interfaces
{
    // En C# primero son las clases y depues las interfaces
    internal class Conductor : Empleado, IEmpleadoProductos
    {
        public Conductor(string NombreConductor) : base(NombreConductor)
        {

        }

        public void ConducirCoche()
        {
            Console.WriteLine("Puedo conducir coches");
        }

        public bool ManejoProductos()
        {
            return false;
        }
    }
}
