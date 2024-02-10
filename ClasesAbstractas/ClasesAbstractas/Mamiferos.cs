namespace ClasesAbstractas
{
    internal class Mamiferos : Animales
    {
        public override void GetNombre()
        {
            Console.WriteLine("El nombre del mamífero es: ");
        }

        public virtual void Pensar()
        {
            Console.WriteLine("Pensamiento basico.");
        }
    }
}
