namespace GenericosRestricciones
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AlmacenEmpleados<Director> empleado = new AlmacenEmpleados<Director> (3);
            empleado.Agregar(new Director(4500));
            empleado.Agregar(new Director(1500));
            empleado.Agregar(new Director(2500));

            // No permite almacenar clases que no cumplan con la restricciones establecidad por la interfaz
            //AlmacenEmpleados<Estudiante> estudiante = new AlmacenEmpleados<Estudiante> (3);
        }
    }
}
