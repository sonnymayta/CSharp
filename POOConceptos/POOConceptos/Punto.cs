namespace POOConceptos
{
    internal class Punto
    {
        private int x;
        private int y;

        public Punto(int x, int y)
        {
            //Console.WriteLine($"Coordenanda X: {x}\nCoordenada Y: {y}");
            this.x = x; 
            this.y = y;
        }

        public Punto()
        {
            //Console.WriteLine("Este es el constructor por defecto.");
            this.x = 0;
            this.y = 0;
        }

        // El atributo de tipo objeto es simiar a los primitivos int y double
        public double DistanciaHasta(Punto otroPunto)
        {
            int xdif = this.x - otroPunto.x;
            int ydif = this.x - otroPunto.y;
            double distanciaPunto = Math.Sqrt(Math.Pow(xdif, 2) + Math.Pow(ydif, 2));
            return distanciaPunto;
        }
    }
    /*
     * MODULARIZACIÓN
     * Nos permite organizar las clases de tu proyecto
     */
}
