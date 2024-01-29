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

            // bucle while con operador logico
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

            BuscarNumeroWhile(numeroAleatorio);
            BuscarNumeroDoWhile(numeroAleatorio);
        }

        static void BuscarNumeroWhile(int numeroAleatorio)
        {
            int miNumero = 101;
            int intentos = 0;

            while (numeroAleatorio != miNumero)
            {
                Console.WriteLine("Ingrese un numero entre 0 y 100: ");
                miNumero = int.Parse(Console.ReadLine());
                intentos++;
                if (miNumero > numeroAleatorio)
                {
                    Console.WriteLine("El numero es más bajo.");
                }
                if (miNumero < numeroAleatorio)
                {
                    Console.WriteLine("El numero es más alto.");
                }
            }
            Console.WriteLine($"Has acertado el numero de intentos es: {intentos}");
        }

        static void BuscarNumeroDoWhile(int numeroAleatorio)
        {
            int miNumero;
            int intentos = 0;

            do
            {
                Console.WriteLine("Ingrese un numero entre 0 y 100: ");
                miNumero = int.Parse(Console.ReadLine());
                intentos++;
                if (miNumero > numeroAleatorio)
                {
                    Console.WriteLine("El numero es más bajo.");
                }
                if (miNumero < numeroAleatorio)
                {
                    Console.WriteLine("El numero es más alto.");
                }
            }
            while (numeroAleatorio != miNumero);
            Console.WriteLine($"Has acertado el numero de intentos es: {intentos}");
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
         *  El bucle do-while en español sera "haz-mientras"
         *  El bucle do while ejecutara el codigo en su interior al menos una vez
         *  
         *  Ejemplo:
         *  do
         *  {
         *      código a repetir
         *  } while (condición a evaluar)
         */
    }
}
