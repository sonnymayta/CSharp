namespace ClasesAbstractas
{
    // Decimos que la clase lagartija no tendra herederos
    internal sealed class Lagartija : Animales
    {
        private string nombreReptil;

        public Lagartija(string nombreReptil)
        {
            this.nombreReptil = nombreReptil;
        }

        public override void GetNombre()
        {
            Console.WriteLine("El nombre del reptil es: {0}", nombreReptil);
        }
    }
}
