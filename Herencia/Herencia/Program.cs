namespace Herencia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Caballo Rento = new Caballo();
            Humano Daniel = new Humano();
            Gorila Copito = new Gorila();

            Copito.Trepar();
        }

        class Mamiferos
        {
            public void Respirar()
            {
                Console.WriteLine("Soy capaz de respirar.");
            }

            public void CuidarCrias()
            {
                Console.WriteLine("Cuido de mis crias.");
            }
        }

        // Caballo, Humano, Gorila hereda metodos de mamifero
        class Caballo:Mamiferos
        {
            public void Galopar()
            {
                Console.WriteLine("Soy capaz de galopar.");
            }
        }

        class Humano:Mamiferos
        {
            public void Pensar()
            {
                Console.WriteLine("Soy capaz de pensar.");
            }
        }

        class Gorila:Mamiferos
        {
            public void Trepar()
            {
                Console.WriteLine("Soy capaz de trepar.");
            }
        }
    }
    /*
     * HERENCIA
     * Abuelo --> Padre --> hijo (Jerarquia de la herencia)
     * Los bienes pueden ser heredados del abuelo al padre y del padre al abuelo
     * La herencia nos permite reutilizar cosas sin la necesidad de escribirla nuevamente
     * 
     * [clase empleado] [clase jefe] [clase director]
     * (principio de diseño de herencia "es-un")
     * Posible diseños: 
     *      empleado
     * jefe  < - >   director
     * 
     * empleado -> jefe -> director
     * 
     * Características comunes:
     * - Nombre
     * - Edad
     * - Fecha alta empresa
     * - Salario
     * 
     * Comportamientos comunes:
     * - Trabaja
     * - Genera informes
     * 
     * Siempre que crees una clase una clase o varias clases en una jerarquia de herencia
     * La clase object se encontrara en la cuspide de la herencia (Llamada superclase cósmica)
     * 
     */
}
