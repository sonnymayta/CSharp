namespace POOPractica
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Avion miAvion = new Avion();
            miAvion.ArrancaMotor("runnn...");
            miAvion.Despegar();
            miAvion.Conducir();
            miAvion.Aterrizar();
            miAvion.ParaMotor("pooof...");

            Coche miCoche = new Coche();
            miCoche.ArrancaMotor("ratata...");
            miCoche.Acelerar();
            miCoche.Conducir();
            miCoche.Frenar();
            miCoche.ParaMotor("tutut...");

            // Cambiamos la forma de miVehiculo en tiempo de ejecución
            Console.WriteLine("\nPolimorfismo en acción!");
            Vehiculo miVehiculo = miCoche;
            miVehiculo.Conducir();
            miVehiculo = miAvion;
            miVehiculo.Conducir();
        }
    }
}
