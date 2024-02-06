namespace ArraysPorParametros
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = new int[4];

            numeros[0] = 9;
            numeros[1] = 2;
            numeros[2] = 4;
            numeros[3] = 7;

            ProcesaDatos(numeros);
            
            foreach (int i in numeros)
            {
                Console.WriteLine(i);
            }

            int[] arrayElementos = LeerDatos();

            Console.WriteLine("Imprimiendo desde el main");
            foreach (int i in arrayElementos)
            {
                Console.WriteLine(i);
            }
        }

        // Método que recibe un array como parametros
        static void ProcesaDatos(int[] datos)
        {
            for (int i = 0; i < datos.Length; i++)
            {
                datos[i] = datos[i] + 10;
                //Console.WriteLine(datos[i]);
            }
        }

        static int[] LeerDatos()
        {
            Console.WriteLine("¿Cuantos elementos quieres que tenga el array?");
            string respuesta = Console.ReadLine();
            int numeroElementos = int.Parse(respuesta);
            int[] datos = new int[numeroElementos];
            for (int i = 0; i < numeroElementos; i++)
            {
                Console.WriteLine($"Introduce el dato para la posición {i}:");
                respuesta = Console.ReadLine();
                int datosElemento = int.Parse(respuesta);
                datos[i]= datosElemento;
            }
            return datos;
        }

        /*
         * Los arrays son referencias a objetos si modificas el contenido de un array pasado
         * por parametros la modificación es visible en todas las referencias del array fuera 
         * de ese método incluido en el array original
         */
    }
}
