namespace ExpresionesLambda
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Uso del delegado con expresión lambda
            Cuadrado cuadrado = new Cuadrado(numero => numero * numero);
            Console.WriteLine(cuadrado(3));

            Suma suma = new Suma((numero1, numero2) => numero1 + numero2);
            Console.WriteLine(suma(4, 11));

            Console.WriteLine();

            List<int> numeros = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            List<int> numerosPares = numeros.FindAll(i => i % 2 == 0);
            numerosPares.ForEach(numero => { Console.WriteLine("El numero par es: "); Console.WriteLine(numero); });

            Personas p1 = new Personas();
            p1.Nombre = "Juan";
            p1.Edad = 23;

            Personas p2 = new Personas();
            p2.Nombre = "Reina";
            p2.Edad = 23;

            ComparaEdad comparaEdad = (persona1, persona2) => persona1 == persona2;
            Console.WriteLine(comparaEdad(p1.Edad, p2.Edad));
            
            ComparaNombre comparaNombre = (persona1, persona2) => persona1 == persona2;
            Console.WriteLine(comparaNombre(p1.Nombre, p2.Nombre));
        }

        public delegate int Cuadrado(int numero);

        public delegate int Suma(int numero1, int numero2);

        public delegate bool ComparaEdad(int edad1, int edad2);

        public delegate bool ComparaNombre(string nom1,  string nom2);

        //public static int Cuadrado(int numero)
        //{
        //    return numero * numero;
        //}
    }

    /*
     * EXPRESIONES LAMBDA
     * - Son funciones anónimas
     * - Funcionan para ejecutar funciones que no necesitan ser nombradas
     * - Funcionan para simplificar el código
     * - Son utilizadas para crear delegados sensillos
     * - Son utilizadas para expresiones LINQ query
     * - Etc.
     * Sintaxis
     * Parámetros => expresión / bloque de sentencia
     */
}
