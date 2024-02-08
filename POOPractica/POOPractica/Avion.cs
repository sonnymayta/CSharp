namespace POOPractica
{
    internal class Avion : Vehiculo
    {
        public override void Conducir()
        {
            Console.WriteLine("Conducir con palanca");
        }

        public void Aterrizar()
        {
            Console.WriteLine("Aterrizando");
        }

        public void Despegar()
        {
            Console.WriteLine("Despegando");
        }
    }
}
