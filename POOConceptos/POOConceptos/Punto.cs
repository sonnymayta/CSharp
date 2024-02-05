using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOConceptos
{
    internal class Punto
    {
        public Punto(int x, int y)
        {
            Console.WriteLine($"Coordenanda X: {x}\nCoordenada Y: {y}");
        }

        public Punto()
        {
            Console.WriteLine("Este es el constructor por defecto.");
        }
    }
    /*
     * MODULARIZACIÓN
     * Nos permite organizar las clases de tu proyecto
     */
}
