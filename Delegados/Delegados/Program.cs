namespace Delegados
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // La creación del objeto delegado apuntando a MensajeBienvenida
            ObjetoDelegado objetoDelegado = new ObjetoDelegado(MensajeBienvenida.SaludoBienvenida);
            
            // Utilización del delegao para llamar al método saludoBienvenida
            objetoDelegado("Carla");

            objetoDelegado = new ObjetoDelegado(MensajeDespedida.SaludoDespedida);
            objetoDelegado("Carla");
        }

        // Creando un delegado
        // Debe tener la misma structura que los metodos que llama
        delegate void ObjetoDelegado(string text);
    }

    /*
     * DELEGADOS
     * - Funciones que delegan tareas a otras funciones
     * - Muy similares a los apuntadores de C++
     * - Un delegado es una referencia a un método
     * Sirven:
     * - Muy utilizados en C# para llamar a eventos
     * - Se reduce significativamente el código al manejar diferentes escenarios
     * - Código muy reutilizable
     * Sintaxis:
     * delegate tipo NombreDelegado(argumentos);
     * - Podrá llamar solo a métodos con la misma estructura
     * tipo nombreMetodo(argumentos);
     */
}
