namespace POOPractica
{
    internal class Vehiculo
    {
        public virtual void Conducir()
        {
            Console.WriteLine("El vehiculo esta siendo conducido.");
        }

        public void ArrancaMotor(string sondioAlArrancar)
        {
            Console.WriteLine($"Arrancar el motor: {sondioAlArrancar}");
        }

        public void ParaMotor(string sonidoAlParar)
        {
            Console.WriteLine($"Parando el motor: {sonidoAlParar}");
        }
    }
}
