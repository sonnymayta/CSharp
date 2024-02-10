namespace ClasesAbstractas
{
    internal class Humano : Mamiferos
    {
        public sealed override void Pensar()
        {
            Console.WriteLine("Soy capaz de pensar.");
        }
    }
}
