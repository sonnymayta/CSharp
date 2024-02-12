namespace Estructuras
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Empleado empleado = new Empleado(1200, 250);
            empleado.CambiaSalario(empleado, 100);
            Console.WriteLine(empleado);
        }
    }

    public struct Empleado
    {
        public double salarioBase, comision;

        public Empleado(int salarioBase, int  comision)
        {
            this.salarioBase = salarioBase;
            this.comision = comision;
        }

        public override string ToString()
        {
            return string.Format("Salaraio y comisión del empleado: {0} {1}", this.salarioBase, this.comision);
        }

        public void CambiaSalario(Empleado emp, double incremento)
        {
            emp.salarioBase += incremento;
            emp.comision += incremento;
        }
    }
    /*
     * STRUCTS (ESTRUCTURAS)
     * Las estructuras se almacenan en el "stack" a diferencia de las clases que se almacenan en el "heap"
     * 
     * Valor (stack): representan un valor directo y se almacenan en la memoria de la pila (stack).
     * - La memoria de la pila es más rapida pero limitada en tamaño
     * - Los datos se almacenan directamente en la ubicación de la memoria donde se declara la variable.
     * - Son tipos de datos primitivos como enteros, caracteres, booleanos, y estructuras.
     * 
     * Referencia (heap): contiene una dirección de la memoria que apunta al lugar donde se almacenan los datos, generalmente
     * en el montón (heap)
     * - La memoria en el heap es más grande pero puede ser más lenta de acceder.
     * - Se almacenan en una ubicación diferente de donde se declara la variable.
     * - Son objetos, arryas, y clases ejemplos de datos de referencia.
     * 
     * Deferencias de structs con las clases
     * - No permite la delcaración del constructor por defecto
     * - El compilador no inicia los campos. Puedes iniciarlos en el constructor
     * - No peude haber sobrecarga de constructores
     * - No heredan de otras clases pero si implementan interfaces
     * - Son selladas (sealed)
     * Cuándo usar struct
     * - Cuando necesitas trabajar con una cantidad elevada de datos en memoria (representación de primitivos,
     * números complejos, puntos tridimensionales... etc.
     * - Cuando las instancias no deban cambiar (inmutables)
     * - Cuando la instancia tenga tamaño inferior a 16 bytes
     * - Cuando no necesites convertir a objeto (boxed)
     * - Por razones de rendimiento
     */
}
