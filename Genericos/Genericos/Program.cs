namespace Genericos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AlmacenObjetos archivos = new AlmacenObjetos(4);

            archivos.Agregar(new Empleado(1500));
            archivos.Agregar(new Empleado(2500));
            archivos.Agregar(new Empleado(3500));
            archivos.Agregar(new Empleado(4500));
            //archivos.Agregar("Juan");
            //archivos.Agregar("Elena");
            //archivos.Agregar("Antonio");
            //archivos.Agregar("Sandra");

            // Haciendo un castin al objeto que solo en la compilacion es posible visualizar el error
            //string nombrePersona = (string)archivos.GetElemento(2);
            //Console.WriteLine(nombrePersona);

            // Hay que corregirlo
            Empleado salarioEmpleado = (Empleado)archivos.GetElemento(2);
            Console.WriteLine(salarioEmpleado.GetSalario());
        }
    }

    class AlmacenObjetos
    {
        private Object[] datosElemento;

        private int _i = 0;

        public AlmacenObjetos(int z)
        {
            datosElemento = new Object[z];            
        }

        public void Agregar(Object obj)
        {
            datosElemento[_i] = obj;
            _i++;
        }

        public Object GetElemento(int i)
        {
            return datosElemento[i];
        }
    }

    class Empleado
    {
        private double _salario;

        public Empleado(double salario)
        {
            _salario = salario;
        }

        public double GetSalario()
        {
            return _salario;
        }
    }

    /*
     * PROGRAMACIÓN GENÉRICA
     * Reutilización de código utilizando clases comodin permitiendo manejar cualquier tipo de objeto
     * Ejemplo:
     *      Clase<string> archivos = new EjemploClase<string>
     *      Sera capaz de manejar cualquier tipo de objeto
     * ¿Podemos hacer lo mismo sin programación genérica?
     * - con la clase object
     * Inconvenientes:
     * - uso continuo del casting
     * - complicación del código
     * - no posibilidad de comprobacion de errores
     * ¿Por qué usar la programación genérica?
     * - mayor sencillez del código
     * - reutilización del código en numerosos escenarios
     * - comprobación de errores en tiempo de compilación
     */
}
