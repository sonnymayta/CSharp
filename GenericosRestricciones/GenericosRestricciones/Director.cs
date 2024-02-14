namespace GenericosRestricciones
{
    internal class Director : IParaEmpleados
    {
        private double _salario;

        public Director(double salario)
        {
            _salario = salario;
        }
        public double GetSalario()
        {
            return _salario;
        }
    }
}
