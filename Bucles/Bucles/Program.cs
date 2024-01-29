namespace Bucles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Uso del bucle while
            Console.WriteLine("¿Deseas entrar en el bucle while?");
            string respuesta = Console.ReadLine();
            string bucle = "no";

            while (respuesta != "no" && bucle != "si")
            {
                Console.WriteLine("Te encuentras en el bucle.");
                Console.WriteLine("¿Deseas salir del bucle?");
                bucle = Console.ReadLine();
            }

            Console.WriteLine("Has salido del bucle.");

            // Ejercicio del numero aleatorio
            Random numero = new Random();
            int numeroAleatorio = numero.Next(0, 100);
            Console.WriteLine(numeroAleatorio);
        }

        /*
         * BUCLES
         * Permiten repetir la ejecución de línes de código un número determinado o indetermidado
         * de veces.
         * - Permite repetir de forma rápida y sencilla
         * - Ahorro de tiempo a la hora de programar
         * - Permite trabajar con grandes volúmenes de datos
         * - Permite trabajar con arrays
         * 
         *  TIPOS
         *  - Determinados (FOR)
         *  - Indeterminados (WHILE, DO-WHILE) en español mientras
         *  
         *  Ejemplo:
         *  while(condición a evaluar) 
         *  {
         *      código a repetir
         *  }
         *      
         */
    }
}
