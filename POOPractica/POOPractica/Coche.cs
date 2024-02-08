namespace POOPractica
{
    internal class Coche : Vehiculo
    {
        public override void Conducir()
        {
            Console.WriteLine("Conducir con volante");
        }

        public void Acelerar()
        {
            Console.WriteLine("Acelerando");
        }

        public void Frenar()
        {
            Console.WriteLine("Frenar");
        }
    }
}
