
namespace Metodos
{
    internal class Program
    {
        // Variables de ambito de clase
        int valor1 = 5;        

        static void Main(string[] args)
        {
            mensajeEnPantalla();
            Console.WriteLine("Mensaje desde el main.");

            Suma(4, 4);

            Console.WriteLine($"La resta es: {Resta(5, 2)}");
            Console.WriteLine($"La divisón es: {Division(5, 2)}");

            // Llamando a métodos sobrecargados

            Console.WriteLine(metodoSuma(2, 3));
            Console.WriteLine(metodoSuma(2, 3, 5));

            // Creando un método por medio de visual studio
            // Usar la opción quick actions and refactorings...

            // Console.WriteLine(metodoResta(2, 4));

            // Usando un método con parametros opcionales
            Console.WriteLine(multiplicacion(3, 4));
        }

        // Método creado por visual studio
        private static bool metodoResta(int v1, int v2)
        {
            throw new NotImplementedException();
        }

        // El método es buscando en todo el bloque de la clase donde se encuentra
        // Métodos de tipo void
        static void mensajeEnPantalla() // es necesario usar static en este caso
        {
            Console.WriteLine("Mensaje desde un método.");
        }
       
        // Estamos utilizando el paso de parametros por valor
        static void Suma(int num1, int num2)
        {
            Console.WriteLine($"La suma de los numeros es: {num1 + num2}");
        }

        // Métodos de tipo
        static int Resta(int num1, int num2)
        {
            return num1 - num2; // Tener cuidad con el tipo de dato que se devuelve
        }

        // Para métodos sencillos de una sola linea de codio podemos hacer los siguiente
        static double Division(double num1, double num2) => num1 / num2;

        // La variable declarada e iniciada solo se puede usar en el contexto actual donde se encuentra
        // numero1 y numero2 tiene un ambito local
        void primerMetodo()
        {
            int numero1 = 5;
            int numero2 = 7;
            Console.WriteLine(numero1 + numero2);
        }

        void segundoMetodo()
        {
            // Console.WriteLine(numero1); No podiamos usar la variable numero1 declarada en otro método
            Console.WriteLine(valor1 + valor2);            
        }

        // Métodos sobrecargados
        // Esta forma de escribir un método se lo suele llamar expression-bodied
        static int metodoSuma(int operador1, int operador2) => operador1 + operador2;

        static int metodoSuma(int operador1, int operador2, int numero3) => operador1 + operador2 + numero3;
               
        // Métodos con parametros opcionales siempre deben ir al final
        static double multiplicacion(int v1, double v2, double v3 = 1)
        {
            return v1 * v2 * v3;
        }

        /*
         * Metodos son un grupo de instrucciones que realizan una tarea en concreto
         * Sirven para hacer una tarea en un momento determinado
         * Solo realiza su tarea hasta que es llamado
         * Todos los métodos irán dentro de una clase
         * Se debe especificar el tipo devuelto y los parámetros
         * Los metodos y funciones hacen referencia a los mismo en C#
         * 
         * sintaxis
         * 
         * tipo nombre (parametros) {
         *   cuerpo del método
         *   return resultado;
         * }
         * 
         * Existen métodos que no devuelvan algun valor
         * Este tipo de metodo nunca llevará return
         * 
         * void nombre (parametros) {
         *   cuerpo del método
         * }
         * 
         * El metodo no debe ser mas grande que tu pantalla o se considera que esta mal diseñado
         */

        /*
         * Sobrecarga de métodos es cuando tienes en el mismo ambito dos o más métodos con el mismo nombre
         * Para diferenciarlos se utilizan los parametros que reciven
         */

        /*
         * Visual studio tiene una herramienta de depuración que nos ayuda a entender el funcionamiento del codigo
         * Click derecho "Run to cursor" y utilizar las herramientas que proporciona el programa
         */

        // Estas variables son accesibles desde cualquier punto de la clase
        int valor2 = 6;
    }
}
