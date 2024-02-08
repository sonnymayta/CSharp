namespace Interfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cajero miCajero = new Cajero("Ana");
            Conductor miConductor = new Conductor("Marcos");
            miConductor.ConducirCoche();
            Console.WriteLine($"Puede manipular productos: {miConductor.ManejoProductos()}");
            Console.WriteLine($"Puede manipular productos: {miCajero.ManejoProductos()}");
        }
    }

    /*
     * INTERFACES
     * Conjuntos de directrices que deben cumplir las clases
     * [interfaz-1] --implementa-- [clase-ejemplo-1]
     * Marca los comportamientos o directrices que deben tener las clases que hereden 
     * - Nos obliga a que cada clase desarrolle a su manera el metodo de la interfaz
     * - El nombre de método debe coincidir
     * - Mismo tipo de dato a devolver
     * - Mismo numero de parámetros y tipo
     */
}
