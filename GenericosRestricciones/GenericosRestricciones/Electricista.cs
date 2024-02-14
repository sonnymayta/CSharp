namespace GenericosRestricciones
{
    internal class Electricista : IParaEmpleados
    {
        private double _salario;

        public Electricista(double salario)
        {
            _salario = salario;
        }

        public double GetSalario()
        {
            return _salario;
        }
    }
}
