namespace Destructores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ManejoArchivos manejoArchivos = new ManejoArchivos();
            manejoArchivos.Mensaje();
        }
    }

    class ManejoArchivos
    {
        StreamReader archivo = null;
        int contador = 0;
        string linea;

        public ManejoArchivos()
        {
            archivo = new StreamReader(@"D:\Programming\C#\Curso de C#\Destructores\Destructores\Saludo.txt");
            while((linea = archivo.ReadLine()) != null)
            {
                Console.WriteLine(linea);
                contador++;
            }
        }

        public void Mensaje()
        {
            Console.WriteLine($"Hay {contador} lineas.");
        }

        // Sintaxis de un destructor
        ~ManejoArchivos()
        {
            // Aquí va el codigo que queremos que se ejecute cuando el garbage collection esta eliminado este recurso
            archivo.Close();
        }
    }

    /*
     * Recolector de basura (Garbage collection)
     * Es una caracteristica de los lenguajes de programación que elimina de la memoria aquellas partes 
     * de codigo que no se utilizan más
     * 
     * DESTRUCTOR 
     * - Ejecutar código a la destruccipón de un recurso en memoria
     * Ejemplos:
     * - Conexiones con BBDD
     * - Cierre de streams en el manejo externo de ficheros
     * - Eliminación de objetso de colecciones
     * - Etc.
     * 
     * A tener en cuenta 
     * - Los destructores solo se usan en clases
     * - Cada clases solo puede tener un destructor 
     * - Los destructores no se heredan ni se sobrecargan
     * - Los destructores no se llaman. Son invocados automáticamente
     * - Los destructores no tiene modificadores de acceso ni parámetros
     * - No utilizar en la medida de lo posible los destructores solo en caso de ser realmente necesario 
     * y lo tengas muy en claro
     */
}
