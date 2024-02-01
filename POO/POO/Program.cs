namespace POO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }

    /*
     * POO
     * Paradigmas de la programación ->
     * (Programación orientadas a procedimientos (old), Programación orientada a objetos)
     * 
     * Programación Orientada a procedimientos
     * Desventajas:
     * - Unidades de código muy grandes en aplicaciónes complejas
     * - En aplicacíones complejas el código resultaba dificil de descifrar
     * - Poco reutilizable
     * - Un fallo en una linea de código, es muy probable que el programa caiga
     * - Aparición frecuente de código espagueti
     * - Dificil de depurar por otros programadores en caso de necesidad o error
     * 
     * ¿En que consiste?
     * - Trasladar la naturaleza de los objetos de la vida real al código de programación
     * ¿Cúal es la naturaleza de un objeto de la vida real?
     * - Los objetos tiene un estado, un comportamiento y propiedades
     * Ejemplo
     * - ¿Cual es el estado del coche? Un coche puede estar parado, circulando, aparcado, etc.
     * - ¿Qué propiedades tiene un coche? Un coche tiene color, un peso, un tamaño, etc.
     * - ¿Qué comportamiento tiene un coche? Un coche puede arrancar, frenar, acelerar, girar, etc.
     * 
     * Programación Orientada a Objetos:
     * Algunos lenguajes como: c++. Java, Visual.NET, etc.
     * Ventajas:
     * - Programas divididos en "trozos", "partes", "módulos", "clases", modularización
     * - Muy reutilizable. Herencia
     * - Si existe un fallo en alguna linea de código, el programa continuará con su funcionamiento
     * tratamiento de excepciones
     * - Encapsulamiento
     * 
     * POO concepto
     * Dividir el programa en clases o partes para facilitar su manejo
     * 
     * Modificadores de acceso
     * - public (accesible desde cualquier parte)
     * - private (accesible desde la propia clase)
     * - protected (accesible desde clase derivada)
     * - internal (accesible desde el mismo ensamblado)
     * - protected internal (accesible desde el mismo ensambaldo o clase derivada de otro ensamblado)
     * - private protect (accesible desde la misma clase o clase derivada del mismo ensambaldo)
     * - por defecto (accesible desde el mismo paquete)
     * 
     * Vocabulario de la POO
     * - clase
     * - Objeto
     * - Ejemplar de clase / Instancia de clase / Ejemplarizar una clase / Instanciar una clase
     * - Modularización (dividir el programa en pequeños bloques)
     * - Encapsulamiento / Encapsulación (bloquean el acceso en su interior o parte)
     * - Herencia (Padre -> hijo)
     * - Polimorfismo
     * 
     * CLASE
     * Modelo donde se redactan las características comunes de un grupo de objetos
     * 
     * OBJETO
     * Ejemplar perteneciente a una clase
     * Tiene propiedades / atributos:
     * - Color
     * - Peso
     * - Alto
     * - Largo
     * Tiene un comportamiento / métodos / funciones (¿Qué es capaz de hacer)
     * - Arrancar
     * - Frenar
     * - Girar
     * - Acelerar
     * 
     * NOMENCLATURA DEL PUNTO
     * Objeto. (accediento a propiedades y comportamientos (pseudocódigo)
     * 
     * Accediendo a propiedades de objeto desde código (pseudocódigo)
     * - Renault.color = "rojo"
     * - Renault.peso = 1500
     * - Renault.ancho = 2000
     * - Renault.alto = 900
     * Accediendo a comportamientos de objeto desde código (pseudocódigo)
     * - Renault.arrancar();
     * - Renault.frenar();
     * - Renault.girar();
     * - Renault.acelerar();
     */
}
