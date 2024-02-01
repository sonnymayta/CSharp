namespace Finally
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }

        /* FINALLY
         * try
         * {
         *      código que se intenta
         * }
         * cath (FormatException e)
         * {
         *      código que se ejecuta si hay una excepción
         * }
         * finally
         * {
         *      código que se ejecuta siempre
         * }
         * 
         * Se utiliza casi siempre con base de datos y lectura de ficheros externos
         * Se utiliza siempre que necesitemos liberar recursos
         * Cerrar conexiones en BBDD y lectura de ficheros
         */
    }
}
