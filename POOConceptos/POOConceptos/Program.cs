namespace POOConceptos
{
    internal class Program
    {
        static void Main(string[] args)
        {            
            RealizarTarea();
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
    }
}
