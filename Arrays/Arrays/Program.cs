namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Cuando iniciamos un array y no declaramos sus valores como toma el valor por defecto del tipo
            int[] edades;
            edades = new int[4];

            edades[0] = 15;
            edades[1] = 27;
            edades[2] = 29;
            edades[3] = 80;

            Console.WriteLine(edades[2]);
            // Consejo: familiarizarse con la exception (System.IndexOutOfRangeException)

            int[] numero = [15, 27, 19, 80];

            Console.WriteLine(numero[2]);

            // Otra sintaxis que es posible en C# restringiendo la dimension del array
            int[] valores = new int[5] { 15, 27, 19, 80, 44 };
        }
    }

    /*
     * ARRAYS (Matrices, arreglos)
     * - Son estucturas de datos que contiene una colección de valores del mismo tipo
     * - Para almacenar valores que normalmente tienen alguna relación entre sí
     * Sintaxis:
     * - Declaración: int[] mi_matriz;
     * - Iniciación: mi_matriz = new int[4];
     * - Declaración y iniciación: int[] mi_matriz = new int[4];
     * 
     * Dato: El array no reseva un espacio en memoria hasta utilizar el operador "new"
     * 
     * int[] mi_matriz = new int [5];
     * 
     * [15][25][8][-7][92]
     * 
     * mi_matriz[0]=15;
     * mi_matriz[1]=25;
     * mi_matriz[2]=8;
     * mi_matriz[3]=-7;
     * mi_matriz[4]=92;
     * 
     * Declaración simplificada alternativa
     * int[] mi_matriz = {15, 25, 8, -7, 92}
     */
}
