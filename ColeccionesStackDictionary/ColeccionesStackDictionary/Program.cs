namespace ColeccionesStackDictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Dictionary
            Dictionary<string, int> edades = new Dictionary<string, int>();
            edades.Add("Helena", 23);
            edades.Add("Juan", 26);
            edades["Maria"] = 35;
            edades["Antonio"] = 32;

            foreach (KeyValuePair<string, int> persona in edades)
            {
                Console.WriteLine("Nombre: {0}, Edad: {1}", persona.Key, persona.Value);
            }

            // Stack
            Stack<int> numeros = new Stack<int>();

            foreach (int numero in new int[5] { 1, 2, 3, 4, 5 })
            {
                numeros.Push(numero);
            }

            foreach (int i in numeros)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("Eliminando elementos del Stack.");
            numeros.Pop();

            foreach (int i in numeros)
            {
                Console.WriteLine(i);
            }
        }
    }

    /*
     * STACK
     * Ultimo en entrar primero en salir L.I.F.O. (Last In First Out)
     * DICTIONARY
     * Es el que consume mas recursos 
     * => Tkey[Valor] Tkey[Valor] Tkey[Valor] Tkey[Valor] 
     */
}
