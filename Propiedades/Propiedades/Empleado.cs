namespace Propiedades
{
    internal class Empleado
    {
        private double _salario;
        private string _nombre;

        public Empleado(string nombre)
        {
            _nombre = nombre;
        }

        //public void SetSalario(double salario)
        //{
        //    if (salario < 0)
        //    {
        //        Console.WriteLine("El salario no puede ser negativo. Se le asignara 0 como salario.");
        //        this.salario = 0;
        //    } 
        //    else
        //    {
        //        this.salario = salario;
        //    }
        //}

        //public double GetSalario()
        //{
        //    return salario;
        //}

        private double EvaluarSalario(double salario)
        {
            if (salario < 0) { return 0; } else { return salario; }
        }

        //public double Salario
        //{
        //    get { return _salario; }
        //    set { _salario = EvaluarSalario(value); }
        //}
        
        // Puedes crear properties de solo escritura presindiendo del get y tambien propiedad
        // de solo lectura presindiendo del set
        public double Salario
        {
            get => _salario;
            set => _salario = EvaluarSalario(value);
        }
    }

    /*
     * PROPIEDADES (PROPERTIES)
     * Se da el caso que no siempres se pueden usar las properties y en ocaciones la sintaxis es mas
     * complicada que la encapsulación. Existen escenarios especificos donde las properties son más útiles que 
     * el código convencional
     */
}
