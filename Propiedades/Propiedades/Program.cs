namespace Propiedades
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Empleado Raul = new Empleado("Raul");
            Raul.Salario = 1200;
            Console.WriteLine("El salario del empleado es: {0}", Raul.Salario);
            Raul.Salario += 500;
            Console.WriteLine($"El salario del empleado es: {Raul.Salario}");
        }
    }
}
