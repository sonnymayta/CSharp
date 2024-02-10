namespace ClasesAbstractas
{
    // Clase abstracta
    abstract class Animales
    {
        public void Respirar()
        {
            Console.WriteLine("Soy capaz de respirar.");
        }

        // Método abstracto
        public abstract void GetNombre();
    }
}
