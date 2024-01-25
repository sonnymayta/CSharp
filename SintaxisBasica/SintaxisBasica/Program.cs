// Directiva using para el espacio de nombres System, actualmente no se usa
using System;

// Podemos crear namespace para almacenar clases y que no entren en conflicto con otras clases
namespace SintaxisBasica
{
    // Clases propias son aquellas que nosotros creamos
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hola mundo!");

            int edad = 18;
            Console.WriteLine($"Mi edad es: {edad}");

            int suma = 2 + 3;
            // Incremento y decremento
            suma++;
            suma--;
            // Incremento de un numero n
            suma += 10;
            int resta = 2 - 3;
            int multiplicacion = 2 * 3;
            double division = 3 / 2;
            int residuo = 3 % 2;

            // Utilizamos la interpolacion de string usando ($"{}");
            Console.WriteLine($"Suma: {suma}, Resta: {resta}, Multiplicación: {multiplicacion}, División: {division}, Residuo: {residuo}");

            // Operador =

            int edad1;
            int edad2;
            int edad3;
            int edad4;

            edad1 = edad2 = edad3 = edad4 = 0;
            Console.WriteLine($"{edad1} {edad2} {edad3} {edad4}");

            // Declaracion implicita de variable
            var persona = "Carlos";
            Console.WriteLine(persona);

            // Conversión explícita - casting
            double temperatura1 = 35.2;
            int temperatura2;
            temperatura2 = (int)temperatura1;
            Console.WriteLine(temperatura2);

            // Conversión implicita -> revisar la documentación oficial para las conversiones implicitas
            int habitantes = 10000;
            long habitantesActual = habitantes;
            Console.WriteLine(habitantesActual);

            // Conversión de texto a número 
            Console.WriteLine("Introduce un el primer numero");
            int numero1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduce un el segundo numero");
            int numero2 = int.Parse(Console.ReadLine());
            Console.WriteLine($"El resutlado es: {numero1 + numero2}");

            // Constantes 
            // Hay que declarar e iniciar el valor en la misma liena
            // Las constantes por convencion se recomienda nombrarlos en mayusculas
            const int VALOR = 2;
            // Otra fomrma de mostar datos en consola utilizando console.writeline
            Console.WriteLine("El valor de la constante es: {0}", VALOR);

            // Ejemplo
            Console.WriteLine("Introduce la medida del radio: ");
            double radio = double.Parse(Console.ReadLine());
            double area = Math.Pow(radio, VALOR) * Math.PI;
            Console.WriteLine($"El área del circulo es: {area}");
        }

        /*
         * Identificadores son los nombre que se usan para identificar los elementos 
         * de tus programas:
         * - namespaces
         * - clases
         * - métodos
         * - variables
         * - constantes
         * 
         * Convenciones para nombrar identificadores:
         * - solo se pueden usar letras (mayusculas y minusculas), números y guiones bajos
         * - deben comenzar por una letra o un guión bajo
         * 
         * Palabras reservadas son todas aquellas de color rosa y no se pueden usar para los
         * identificadores.
         */

        /*
         * Tipos de datos primitivos se clasifican en:
         * - enteros (con signo (sbyte, short, int, long) y sin signo (byte, ushort, uint, ulong))
         * - reales (float, double y decimal)
         * - booleanos (true, false)
         */

        /*
         * Variables son espacio en la memoria (RAM) del ordenador donde se almacena un valor que
         * podrá cambiar durante la ejecución del programa.
         * 
         * Convenciones:
         * - no comenzar el nombre con guion bajo
         * - no crear mas de una variable que se diferencia solo por una letra
         * - iniciar el nombre de la variable con letra minúscula
         * - usar CamelCase
         * - no usar notación húngara
         * 
         * Declarar una variable
         * Ejemplo:
         * int edad;
         * 
         * Iniciar una variable
         * Ejemplo:
         * edad = 18;
         * 
         * Declarar e iniciar una variable
         * Ejemplo:
         * int edad = 20;
         * 
         * En C# no se puede usar una varible que no ha sido iniciada
         */

        /*
         * Varibales almacenan un valor que podra cambiar durante la ejecución
         * Constantes almacena un valor que no podra cambiar durante la ejecución
         */
    }
}
