namespace InterfacesPractica
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AvisosTrafico primerAviso = new AvisosTrafico();
            primerAviso.MostrarAviso();

            AvisosTrafico segundoAviso = new AvisosTrafico("Jefatura provincial", "Sanción de velocidad", "02-02-24");
            segundoAviso.MostrarAviso();
            Console.WriteLine(segundoAviso.GetFecha());
        }
    }
}
