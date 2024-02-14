namespace Colecciones
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Crear una coleccion de tipo List
            List<int> numeros = new List<int>();

            LinkedList<int> valores = new LinkedList<int>();

            //int[] listaNumeros = new int[] { 3, 6, 8, 4, 7 };

            //for (int i = 0; i < listaNumeros.Length; i++)
            //{
            //    numeros.Add(listaNumeros[i]);
            //}

            //for (int i = 0; i < numeros.Count; i++)
            //{
            //    Console.WriteLine(numeros[i]);
            //}

            //Console.WriteLine("¿Cuantos elementos quieres introducir?");
            //int elemento = int.Parse(Console.ReadLine());
            //for (int i = 0; i < elemento; i++)
            //{
            //    numeros.Add(int.Parse(Console.ReadLine()));
            //}

            //Console.WriteLine("Elementos introducidos.");

            //for (int i = 0; i < numeros.Count; i++)
            //{
            //    Console.WriteLine(numeros[i]);
            //}

            // LinkedList
            foreach (int valor in new int[] { 10, 8, 16, 32, 64 })
            {
                valores.AddFirst(valor);
            }

            //foreach (int valor in valores)
            //{
            //    Console.WriteLine(valor);
            //}

            LinkedListNode<int> nodoImportante = new LinkedListNode<int>(15);
            valores.AddFirst(nodoImportante);
            valores.Remove(16);

            for (LinkedListNode<int> nodo = valores.First; nodo != null; nodo = nodo.Next)
            {
                int valor = nodo.Value;
                Console.WriteLine(valor);
            }

            // List
            Console.WriteLine("Introduce en la colección (0 para salir)");
            int elementos = 1;
            while (elementos != 0)
            {
                elementos = int.Parse(Console.ReadLine());
                numeros.Add(elementos);
            }
            numeros.RemoveAt(numeros.Count - 1);
            Console.WriteLine("Elementos introducidos: ");
            foreach (int i in numeros)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("El numero de elementos es: " + numeros.Count);
        }
    }
    /*
     * COLECIONES
     * - Son clases que pertenecen al namespace System.Collection.Generic
     * - Estas permiten almacenar elementos
     * - Son clases genéricas (como indica el propio namespace)
     * - No tiene limitaciones de los arryas (a cambio de mayor consumo de recursos)
     * Permite:
     * - Ordenar
     * - Añadir
     * - Eliminar
     * - Buscar
     * - Etc.
     * 
     * Colecciones más frecuentes
     * List<T> Parecidos a los arryas per con metotod adicionales para agregar, eliminar, ordenar, buscar, etc.
     * Queue<T> Las "colas". Un elemento entra y uno sale. Primero en entrar-primero en salir.
     * Stack<T> Parecido a las Queue pero con algunas diferencias. Primero en entrar-último en salir.
     * LinkedList<T> Comportamiento como Queue o Stack pero con acceso aleatorio.
     * HashSet<T> Listas de valores sin ordenar.
     * Dictionary<Tkey, Tvalue> Almacena elementos con estructura de clave-valor.
     * SortedList<Tkey, Tvalue> Igual que los Dictionary pero ordenados.
     * 
     * COLECCIÓN LINDEDLIST (LISTAS ENLAZADAS)
     * LinedList vs List
     * List {dato dato dato dato} en una lista todos sus elementos deben estar juntos no puede haber
     * un espacio sin un elemento adiacente (no puede haber una lista con un espacio vacio)
     * LinkedList [enlace(link)] Dato [enlace(link)]
     *                             |
     *                          nodos
     * LinkedList   []dato[link1]
     *              [link1]dato[link2]
     *              [link2]dato[link3]
     *              [link3]dato[]
     *            
     * Si eliminamos
     *              []dato[link1]
     *              [link1]dato[link3]
     * 
     *              [link3]dato[]
     */
}
