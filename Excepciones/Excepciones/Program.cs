namespace Excepciones
{
    internal class Program
    {
        static void Main(string[] args)
        {
            UsoChecked2();
        }

        static void IntroducirValor()
        {
            int numero;
            try
            {
                // Si se ingresa un texto en lugar de numero ocaciona una excepción
                // Si se ingresa un valor numérico demaciado grande
                Console.WriteLine("Introduzca un numero: ");
                numero = int.Parse(Console.ReadLine());
            }
            catch (FormatException) //catch (Exception) captura cualquier exception existente
            {
                Console.WriteLine("No has introducido un valor numérico válido.");
                numero = 0;
            }
            catch (OverflowException)
            {
                Console.WriteLine("No has introducido un valor numérico válido.");
                numero = 0;
            }
            Console.WriteLine($"Mi numero: {numero}");
        }

        static void IntroducirValor2()
        {
            // Como capturar varias excepciones y excepciones especificas
            // catch (Exception) debe encontrarse al final
            int numero;
            try
            {
                Console.WriteLine("Introduzca un numero: ");
                numero = int.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("No has introducido un valor numérico válido.");
                numero = 0;
            }
            catch (Exception)
            {
                Console.WriteLine("Ha habido un error.");
                numero = 0;
            }
            Console.WriteLine($"Mi numero: {numero}");
        }

        static void IntroducirValor3()
        {
            // Como capturar varias excepciones usando filtros
            int numero;
            try
            {
                Console.WriteLine("Introduzca un numero: ");
                numero = int.Parse(Console.ReadLine());
            }
            catch (Exception e) when (e.GetType() != typeof(FormatException))
            {
                Console.WriteLine("Ha habido un error.");
                numero = 0;
            }
            catch (FormatException)
            {
                Console.WriteLine("No has introducido un valor numérico válido.");
                numero = 0;
            }
            Console.WriteLine($"Mi numero: {numero}");
        }

        static void UsoChecked()
        {
            // Checked comprueba los errores y lanza la excepcion si es necesario
            // Podemos activar el comportamiento del checked en todo el proyecto
            // dirigiendonos a los ajustes del proyecto y activar "check for aritmetic overflow"
            // Solo funciona con primitivos de tipo int y long
            checked
            {
                int numero = int.MaxValue;
                int resultado = numero + 20;
                Console.WriteLine(resultado);
            }
            // Nos devuelve una respuesta erronea por rendimiento
            // Asume que hay un error y continua ejecutando el programa para que este no caiga
        }

        static void UsoChecked2()
        {
            // Forma abreviada del uso de checked
            int numero = int.MaxValue;
            int resultado = checked(numero + 20);
            Console.WriteLine(resultado);
        }

        static void UsoChecked3()
        {
            // Si tienes el checked activado para todo el proyecto puedes usar la siguiente expresion para 
            // que no revise la exception
            int numero = int.MaxValue;
            int resultado = unchecked(numero + 20);
            Console.WriteLine(resultado);
        }


            /*
             * EXCEPCIONES
             * Las excepciones son errores en tiempo de ejecución del programa que escapan al control
             * del programador.
             * - memoria corrupta
             * - desbordamiento de pila
             * - sectores de disco dura defectuosos
             * - conexiones de BBDD interrumpidas
             * - etc.
             * 
             * Si intenta capturar el error y decir al programa que hacer cuando ocurre esa expeción
             * 
             * Varias excepciones
             * try
             * {
             *     código que se intenta ejecutar
             * }
             * catch (FormatException ex)
             * {
             *     código que se ejecuta si hay excepción
             *     ex.Message > nos proporciona informacion útil acerca de la exception ocurrida
             * }
             * 
             * HERENCIA DE EXCEPCIONES
             * Exception
             * - SystemException (FormatException, OverflowException)      
             * 
             * No abusar con el uso de "Exception" e intentar capturar las exceptiones especificas
             */
        }
    }
