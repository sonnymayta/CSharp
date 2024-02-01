namespace Finally
{
    internal class Program
    {
        static void Main(string[] args)
        {
            System.IO.StreamReader archivo = null;

            try
            {
                string linea;
                int contador = 0;
                string directorioProyecto = System.AppDomain.CurrentDomain.BaseDirectory;
                string path = @"D:\Programación\C#\Curso de C#\Finally\Finally\texto.txt";
                archivo = new System.IO.StreamReader(path);
                while ((linea = archivo.ReadLine()) != null)
                {
                    Console.WriteLine(linea);
                    contador++;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Ha ocurrido un error: " + e);
            }
            finally
            {
                if(archivo != null)
                {
                    archivo.Close();
                    Console.WriteLine("Conxion con el fichero cerrada.");
                }
            }
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
