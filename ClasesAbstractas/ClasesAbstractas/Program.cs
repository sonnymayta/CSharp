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
     * CLASES SELLADAS (SEALED CLASSES)
     * Son aquellas clases que designamos "sealed" para que no puedan tener herederos
     * En general podemos decir que una clase de tipo sealed impide la herencia
     * 
     * METODOS SELLADOS 
     * Son aquellos metodos que designamos "sealed" para que no puedan ser modificados por las clases que lo heredan
     * En general podemos decir que una metodo de tipo sealed impide la sobreescritura
     */
}
