namespace Delegados
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Personas> list = new List<Personas>();
            Personas P1 = new Personas();
            P1.Nombre = "Juan";
            P1.Edad = 18;

            Personas P2 = new Personas();
            P2.Nombre = "Maria";
            P2.Edad = 28;

            Personas P3 = new Personas();
            P3.Nombre = "Ana";
            P3.Edad = 46;

            list.AddRange(new Personas[] { P1, P2, P3 });
            Predicate<Personas> predicadoPersonas = new Predicate<Personas>(ExisteJuan);
            bool existe = list.Exists(predicadoPersonas);
            if(existe) { Console.WriteLine("Hay personas que se llaman Juan"); } else { Console.WriteLine("No hay nadie llamado Juan"); }

            List<int> listaNumeros = new List<int>();
            listaNumeros.AddRange(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 });

            // Declaramos delegado predicado
            Predicate<int> predicate = new Predicate<int>(DamePares);
            listaNumeros.FindAll(predicate);

            List<int> numerosPares = listaNumeros.FindAll(predicate);

            foreach (int numero in numerosPares)
            {
                Console.WriteLine(numero);
            }
           

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

        static bool DamePares(int num)
        {
            if (num % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }           
        }

        static bool ExisteJuan(Personas persona)
        {
            if (persona.Nombre == "Juan") { return true; } else { return false; }
        }
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
     * DELEGADOS PREDICADOS
     * - Son delegados que devulven true o false
     * - Sirven para muchas tareas diferentes. Muy utilizados para filtrar listas de valores comprobando
     * si una condición es cierta para un valor dado
     * Sintaxis:
     * Predicate<T> nombrePredicado = new Predicate<T>(funcionDelegado)
     */
}
