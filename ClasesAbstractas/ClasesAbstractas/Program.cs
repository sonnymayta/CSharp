namespace ClasesAbstractas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Lagartija Rancho = new Lagartija("Rancho");
            Rancho.Respirar();
            
            Humano Leo = new Humano();
            Leo.Respirar();

            Rancho.GetNombre();
            Leo.GetNombre();
        }
    }
    /*
     * JERARQUÍA DE HERENCIA
     * mamíferos (respirar(), pensar(), getNombre(), cuidarCrias())
     * - ballena (nada())
     * - caballo : IMamiferos (galopar(), numeroPatas())
     * - humano : IMamiferos (pensar(), numeroPatas())
     * - gorila : IMamiferos (trepar(), numeroPatas())
     * 
     * new clase -> lagartija
     * 
     * IMamiferos
     * - numeroPatas() Que hacemos para agregarlo? Utilizamos clases abstractas
     * 
     * CLASE ABSTRACTA
     * Es la que menos cosas es capaz de hacer y es aquella que se encuentra en la cima de la jerarquia
     * 
     */
}
