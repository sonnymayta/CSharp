namespace POOConceptos
{
    internal class Punto
    {
        private int x;
        private int y;
        private static int contadorDeObjetos = 0;

        // Prueba de una propiedad constante
        public const int constantePrueva = 1;

        public Punto(int x, int y)
        {
            //Console.WriteLine($"Coordenanda X: {x}\nCoordenada Y: {y}");
            this.x = x; 
            this.y = y;

            contadorDeObjetos++;
        }

        public Punto()
        {
            //Console.WriteLine("Este es el constructor por defecto.");
            this.x = 0;
            this.y = 0;

            contadorDeObjetos++;
        }

        // El atributo de tipo objeto es simiar a los primitivos int y double
        public double DistanciaHasta(Punto otroPunto)
        {
            int xdif = this.x - otroPunto.x;
            int ydif = this.x - otroPunto.y;
            double distanciaPunto = Math.Sqrt(Math.Pow(xdif, 2) + Math.Pow(ydif, 2));
            return distanciaPunto;
        }

        // Otra forma de escribir un método de una sola linea
        public static int getContadorDeObjetos() => contadorDeObjetos;
    }
    /*
     * MODULARIZACIÓN
     * Nos permite organizar las clases de tu proyecto
     * 
     * VARIABLE NORMAL
     * Crea una copia independiente para cada objeto y se puede modificar cada una de ellas
     * independiente para cada uno de los objetos.
     * 
     * VARIABLE Y MÉTODO STATIC
     * La variable es compartida por todos los objetos y ninguno de los objetos es dueño de la variable
     * Esta variable pertenece a la clase donde ha sido declarada (se lo llama una variable de clase)
     * Un objeto nunca podra actuar sobre una variable de clase
     * Solo la clase puede actuar sobre la variable estatica
     * - Existen casos donde los metodos o atributos de una clase sean estaticos y no puedan ser cambiado
     * - Puede ser útil cuando creamos un contador general de objetos
     * - En C# las constantes se asumen que son de static sin necesidad de utilizar la palabra reservada static
     * 
     */
}
