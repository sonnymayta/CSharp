namespace ClasesAbstractas
{
    internal class Lagartija : Animales
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
