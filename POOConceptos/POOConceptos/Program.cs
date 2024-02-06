// Nos permite importar todos los métodos estaticos de la clase math
using static System.Math;
using static System.Console;

namespace POOConceptos
{
    internal class Program
    {
        static void Main(string[] args)
        {            
            RealizarTarea();

            // En este caso no es necesario llamar a la case Math o Console
            // Esta es una alternativa que simplifica las cosas pero puede crear confución en otros programadores
            double raiz = Sqrt(9);
            double potencia = Pow(3, 4);
            WriteLine($"{raiz} {potencia}");

            // clases anonimas
            var Variable = new
            {
                Nombre = "Sonny",
                Edad = 19
            };

            var SegundaVariable = new {Nombre = "Carla",  Edad = 19};

            Variable = SegundaVariable;

            WriteLine($"Mi nombre es: {Variable.Nombre} y tengo {Variable.Edad}");            
        }

        static void RealizarTarea()
        {
            // TODO: Implementar logica de negocios
            // en visual studio tenemos la herramienta de lista de tareas
            // View > Task List

            // Una clase sin constructor tiene un constructor por defecto
            // LLamada al constructor sin parametros
            Punto origen = new Punto();

            // Llmada al segundo constructo que lleva paramentos
            Punto destino = new Punto(150, 90);

            Punto otroPunto = new Punto();

            // La constatePrueva se asume como static
            int constante = Punto.constantePrueva;

            double distancia = origen.DistanciaHasta(destino);

            Console.WriteLine(distancia);
            Console.WriteLine($"Numero de objetos creados: {Punto.getContadorDeObjetos()}");
        }

        /*
         * CLASES ANÓNIMAS REQUISITOS
         * - Solo pueden contener campos públicos
         * - Todos los campos deben esta iniciados
         * - Los campos no pueden ser static
         * - No se pueden definir métodos
         */
    }
}
