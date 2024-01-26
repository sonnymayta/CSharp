namespace Condicionales
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool haceFrio = true;
            Console.WriteLine(haceFrio);

            // Operador negación "!" invierte el valor de una variable booleana
            Console.WriteLine(!haceFrio);

            int edad = 18;

            if (edad >= 18)
            {
                Console.WriteLine("La persona es mayor de edad.");
            }
        }

        /*
         * Operadores de comparación
         * igual que ==
         * diferente que !=
         * menor que <
         * menor o igual que <=
         * mayor que >
         * mayor o igual que >=
         * 
         * Operadores lógico
         * Y lógico &&
         * O lógico ||
         */
    }
}
