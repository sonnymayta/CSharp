namespace Enum
{
    // Declaración de enum
    enum Estaciones { Primavera, Verano, Otoño, Invierno };

    enum Bonus { Bajo = 500, Normal = 1000, Bueno = 1500, Extra = 3000 };

    internal class Program
    {
        static void Main(string[] args)
        {
            Estaciones alergia = Estaciones.Primavera;
            // Si necesitas guardar el valor null en un tipo enumero tienes que utilizar al sintaxis "nombre?"
            Estaciones? frio = Estaciones.Invierno;           
            Console.WriteLine(alergia);
            Console.WriteLine(alergia.GetType());
            Console.WriteLine(frio);

            Bonus Antonio = Bonus.Bueno;
            // ser realiza un casting
            double bonusAntonio = (double)Antonio;
            Console.WriteLine(bonusAntonio);

            Console.WriteLine("Probando la clase empleado usando enum.");
            Empleado empleado = new Empleado(Bonus.Extra, 1900.50);
            Console.WriteLine(empleado.GetSalario());
        }

        class Empleado
        {
            //private double _salario, _bonus;

            private double _salario;
            private Bonus _bonus;

            public Empleado(Bonus bonusEmpleado, double salario)
            {
                _bonus = bonusEmpleado;
                _salario = salario;
            }

            public double GetSalario()
            {
                return _salario + (double)_bonus;
            }
        }
    }
    /*
     * ENUM (TIPOS ENUMERADOS)
     * - Son un conjunto de constantes con nombre
     * - Su sintaxis: enum NombreDeEnumeracion {nombre1, nombre2, nombre3...}
     * - Se utilizan para representar y manejar valores fijos (constantes) en un programa
     * - Casi siempre se ven los tipos enumerados dentro de una namespace
     */
}
