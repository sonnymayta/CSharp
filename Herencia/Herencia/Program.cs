namespace Herencia
{
    internal class Program
    {
        static void Main(string[] args)
        {            
            Caballo miRento = new Caballo("Rento");
            Humano miDaniel = new Humano("Daniel");
            Gorila miCopito = new Gorila("Copito");

            miRento.getNombre();
            miDaniel.getNombre();
            miCopito.getNombre();

            // Principo de sustitución
            // Animal y persona son de tipo mamiferos solo pueden acceder a los metodos declarados en la
            // clase Mamiferos
            Mamiferos animal = new Caballo("Merianda");

            // Instanciamos clases y despues aplicamos el principio de sustitución. Esta es otra forma de aplicar el principio de sustitución
            Mamiferos gato = new Mamiferos("Gato");
            Caballo suerte = new Caballo("Suerte");
            gato = suerte;

            // Principio de sustitución con la superclase cosmica object
            Object miCaballo = new Caballo("Bucefalo");

            // Ejemplo
            Console.WriteLine("\nEjemplo de almacen de animales usando el principio de sustitución.");
            Mamiferos[] almacenAnimales = new Mamiferos[3];
            almacenAnimales[0] = miRento;
            almacenAnimales[1] = miDaniel;
            almacenAnimales[2] = miCopito;

            almacenAnimales[2].getNombre();            
        }

        class Mamiferos
        {
            // Campos de clase
            private string NombreSerVivo;

            // Comstructor
            public Mamiferos(string nombre)
            {
                NombreSerVivo = nombre;
            }

            public void Respirar()
            {
                Console.WriteLine("Soy capaz de respirar.");
            }

            public void CuidarCrias()
            {
                Console.WriteLine("Cuido de mis crias.");
            }

            public void getNombre()
            {
                Console.WriteLine($"El nombre del ser vivo es: {NombreSerVivo}");
            }
        }

        // Caballo, Humano, Gorila hereda metodos de mamifero
        class Caballo : Mamiferos
        {
            // Utilizando la instrucción base() para pasar un valor al atributo heredado de la clase mamifero
            public Caballo(string nombreCaballo) : base(nombreCaballo)
            {

            }

            public void Galopar()
            {
                Console.WriteLine("Soy capaz de galopar.");
            }
        }

        class Humano : Mamiferos 
        {
            public Humano(string nombreHumano) : base(nombreHumano)
            {

            }

            public void Pensar()
            {
                Console.WriteLine("Soy capaz de pensar.");
            }
        }

        class Gorila : Mamiferos
        {
            public Gorila(string nombreGorila) : base(nombreGorila)
            {

            }

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
     * 
     *      empleado
     *         |
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
     *      object
     *         |
     *      empleado
     *         |
     * jefe  < - >   director
     * 
     * Las clases hijos que heredan de la clase padre llaman implicitamente al constructor de la clase padre
     * Utilizan una instrucción que no es visible ":base()"
     * En caso de que la superclase ya tenga un constructor definido la instrucción implicita ":base()" 
     * deja de funcionar 
     * 
     * PRINCIPIO DE SUSTITUCIÓN EN LA HERENCIA
     * Consiste en sustituir un objeto de un tipo por un objeto de un tipo diferente siempre teniendo en
     * cuenta la herencia. Se utiliza constantemente en lenguajes de programación orientado a objetos
     * Principio de sustitución -> "es siempre un"
     * 
     * Ejemplo: 
     * 
     *         [mamífero]
     * [caballo]  [humano]  [gorila]
     * 
     * - un mamífero es siempre un caballo -> no
     * - un caballo es siempre un humano -> si
     * 
     * Ejemplo: director-general, empleado, secretaria, jefe-sección
     * 
     * un empleado es siempre un director-general -> no
     * un director-general es siempre un empleado -> si
     * una secretaria es siempre un empleado -> si
     * ...
     * 
     * La jerarquia seria así:
     * 
     *                 empleado
     *        _____________|_____________
     *       |             |             |
     * jefe-sección    secretaria   director-general
     */
}
