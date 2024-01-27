using System.Threading.Channels;

namespace Condicionales
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool haceFrio = true;
            Console.WriteLine(haceFrio);

            // Operador negación "!" invierte el valor de una variable booleana
            Console.WriteLine(!haceFrio);

            int edad = 18;

            if (edad >= 18)
            {
                Console.WriteLine("La persona es mayor de edad.");
            }

            // Es mas correcto usar (condicional == true) a (condicional)
            bool carnet = true;
            if (carnet)
            {
                Console.WriteLine("Puedes conducir un vehiculo");
            }
            else
            {
                Console.WriteLine("No puedes conducir un vehiculo");
            }

            // Uso de operadores logicos
            Console.WriteLine("Ingrese una edad: ");
            int miEdad = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Tienes permiso: ");
            string miPermiso = Console.ReadLine();

            if (miEdad >= 18 && miPermiso == "si")
            {
                Console.WriteLine("Tu puedes trabajar.");
            }
            else
            {
                Console.WriteLine("Tu aun no puedes trabajar.");
            }

            // if anidados
            Console.WriteLine("Ingrese su edad actual: ");
            int edadRequerida = Int32.Parse(Console.ReadLine());
            if (edadRequerida < 18)
            {
                Console.WriteLine("No puedes conducir");
            }
            else
            {
                Console.WriteLine("¿Tienes carnet?");
                string carnetRequerido = Console.ReadLine();
                // Nos permite comparar cadenas de caracteres
                int compara = String.Compare(carnetRequerido, "si", true);
                if (compara == 0)
                {
                    Console.WriteLine("Puedes conducir");
                }
                else
                {
                    Console.WriteLine("No puedes conducir");
                }
            }

            float parcial1 = 9, parcial2 = 8, parcial3 = 5;

            if (parcial1 >=5 || parcial2 >=5 || parcial3 >=5)
            {
                Console.WriteLine($"La nota media es: {(parcial1 + parcial2 + parcial3 / 3)}");
            }
            else
            {
                Console.WriteLine("Vuevle en septiembre");
            }

            // Uso del else if
            Console.WriteLine("Ingrese un valor numerico: ");
            int numero = Int32.Parse(Console.ReadLine());

            if (numero < 20)
            {
                Console.WriteLine("Numero menor a 20");
            }
            else if (numero < 30)
            {
                Console.WriteLine("Numero menor a 30");
            }
            else if (numero < 60) 
            {
                Console.WriteLine("Numero menor a 60");
            }
            else
            {
                Console.WriteLine("Numero mayor a 60");
            }

            // Uso del condicional switch
            Console.WriteLine("Elige un medio de transporte (coche, tren, avion)");
            string medio = Console.ReadLine();
            switch (medio)
            {
                case "coche":
                    Console.WriteLine("Velocidad media: 100 km/h");
                    break;
                case "tren":
                    Console.WriteLine("Velocidad media: 250 km/h");
                    break;
                case "avion":
                    Console.WriteLine("Velocidad media: 800 km/h");
                    break;
                default:
                    Console.WriteLine("No hay información");
                    break;
            }

        }

        /*
         * Operadores de comparación
         * igual que ==
         * diferente que !=
         * menor que <
         * menor o igual que <=
         * mayor que >
         * mayor o igual que >=
         * 
         * Operadores lógico
         * Y lógico &&
         * O lógico ||
         */

        /*
         * En C# todo lo que se hace con un switch lo podemos hacer con un if
         * Pero no todo lo que se hace con un if lo podemos hacer con un switch
         * A tener en cuenta:
         * - Cada expresión constante ha de ser única
         * - Solo se puede usar el switch para evaluar (int, char, string)
         * - Los case solo pueden contener expresiones constantes
         * - Todos los case deben llevar su break (se puede utilizar return y throw => no se ve en C#)
         */
    }
}
