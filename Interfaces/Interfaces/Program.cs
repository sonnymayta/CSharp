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

            // Utilizamos el principio de sustitución en este caso para poder llamar a los metodos HorasTrabajo
            IPagos ipagos = miCajero;
            ITrabajoPorDia itrabajoPorDia = miCajero;
            Console.WriteLine(ipagos.HorasTrabajo());
            Console.WriteLine(itrabajoPorDia.HorasTrabajo());
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
     * 
     * Abigüedad de métodos iguales en interfaces diferentes se soluciona retirando el modificar de acceso public del metodo de la clase
     * y llamando a la interfaz con la nomenclatura del punto usando el método.
     * 
     * RESTRICCIONES
     * - No se permite definir campos (variables) en interfaces
     * - No se pueden definir constructores
     * - No se pueden definir destructores
     * - No se pueden especificar modificadores de acceso en métodos (todos son public de forma implícita)
     * - No se pueden anidar clases ni otro tipo de estructuras en las interfaces
     */
}
