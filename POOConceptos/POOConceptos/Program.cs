namespace POOConceptos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            RealizarTarea();
        }

        static void RealizarTarea()
        {
            // TODO: Implementar logica de negocios
            // en visual studio tenemos la herramienta de lista de tareas
            // View > Task List

            // Una clase sin constructor tiene un constructor por defecto
            // LLamada al constructor sin parametros
            Punto punto = new Punto();

            // Llmada al segundo constructo que lleva paramentos
            Punto punto1 = new Punto(4, 2);
        }
    }
}
