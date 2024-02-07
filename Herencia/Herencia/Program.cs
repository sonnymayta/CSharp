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

            //almacenAnimales[2].getNombre();
            
            // Con esto llamamos al metodo pensar de cada clase correspondiente 
            // A esto se llama polimorfismo -> es la capacidad que tiene los objetos en programación a comportarse de diferente forma 
            // o tener diferente formas.
            for (int i = 0; i < 3; i++)
            {
                almacenAnimales[i].Pensar();
            }
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

            // Para poder trabajar con los metodos pensar tanto de la clase padre mamiferos como de las demas
            // clases heredadas utilizamos en el metodo pensar del tipo virtual
            public virtual void Pensar() => Console.WriteLine("Pensamiento básico instintivo.");

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

            // Cuando una clase hereda un metodo con el mismo nombre de un metodo que ya posee
            // Esta oculta el metodo heredado del mismo nombre
            // Utilizamos la palabra reservada "new" para quitar la advertencia del metodo haciendo que oculte el metodo heredado
            // Sin embargo si queremos que este metodo modifique el metodo heredado debemos utilizar la palabra reservada "override"
            // que sobre escribe el metodo heredado
            public override void Pensar()
            {
                Console.WriteLine("Soy capaz de pensar.");
            }
        }

        class Gorila : Mamiferos
        {
            public Gorila(string nombreGorila) : base(nombreGorila)
            {

            }

            public override void Pensar() => Console.WriteLine("Pensamiento instintivo avanzado");

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
     * 
     * HERENCIA DE MÉTODOS
     * Palabras reservadas new, virtual y override
     * 
     * Ejemplo: public virtual string toString();
     * -  Esto nos indica que todas las clases que podamos crear en c# deberian heredad el metodo toString y
     *    todas las clases deberian modificar el metodo toString para que se adpate a cada clase.
     */
}
