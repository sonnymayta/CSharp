namespace GenericosRestricciones
{
    internal class Secretaria : IParaEmpleados
    {
        private double _salario;

        public Secretaria(double salario)
        {
            _salario = salario;
        }

        public double GetSalario()
        {
            return _salario;
        }
    }
}
