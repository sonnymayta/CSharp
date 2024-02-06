namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Cuando iniciamos un array y no declaramos sus valores como toma el valor por defecto del tipo
            int[] edades;
            edades = new int[4];

            edades[0] = 15;
            edades[1] = 27;
            edades[2] = 29;
            edades[3] = 80;

            Console.WriteLine(edades[2]);
            // Consejo: familiarizarse con la exception (System.IndexOutOfRangeException)

            int[] numero = [15, 27, 19, 80];

            Console.WriteLine(numero[2]);

            // Otra sintaxis que es posible en C# restringiendo la dimension del array
            int[] valores = new int[5] { 15, 27, 19, 80, 44 };

            // Array implícitos
            // Almacena datos pero no se especifica el tipo de dato y su tamaño
            var datos = new[] { "Juan", "Carla", "Ricado", "Luz" };

            // En algunos casos con tipos de datos compatibles podemos hacer lo siguiente
            // En este caso el array sera de tipo double
            var medidas = new[] { 12, 33, 2.44, 53, 5.22 };

            // Array de objetos
            Empleados[] arrayEmpleados = new Empleados[2];

            // Crear un objeto mientras lo almacenamos en el array
            arrayEmpleados[0] = new Empleados("Sara", 37);

            // Creamos o instanciamos un objeto y despues lo almacenamos en el array
            Empleados Carla = new Empleados("Carla", 23);
            arrayEmpleados[1] = Carla;

            // Array de tipos o clases anónimas
            var personas = new[]
            {
                new {Nombre = "Daniel", Edad=19},
                new {Nombre = "Maria", Edad=34},
                new {Nombre = "Carla", Edad=22}
            };
            Console.WriteLine(personas[1]);
        }

        class Empleados
        {
            string nombre;
            int edad;

            public Empleados(string nombre, int edad)
            {
                this.nombre = nombre;
                this.edad = edad;
            }
        }
    }

    /*
     * ARRAYS (Matrices, arreglos)
     * - Son estucturas de datos que contiene una colección de valores del mismo tipo
     * - Para almacenar valores que normalmente tienen alguna relación entre sí
     * Sintaxis:
     * - Declaración: int[] mi_matriz;
     * - Iniciación: mi_matriz = new int[4];
     * - Declaración y iniciación: int[] mi_matriz = new int[4];
     * 
     * Dato: El array no reseva un espacio en memoria hasta utilizar el operador "new"
     * 
     * int[] mi_matriz = new int [5];
     * 
     * [15][25][8][-7][92]
     * 
     * mi_matriz[0]=15;
     * mi_matriz[1]=25;
     * mi_matriz[2]=8;
     * mi_matriz[3]=-7;
     * mi_matriz[4]=92;
     * 
     * Declaración simplificada alternativa
     * int[] mi_matriz = {15, 25, 8, -7, 92}
     */
}
