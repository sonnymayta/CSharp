namespace POOCoche
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Coche coche1 = new Coche(); // Crear objeto/instancia de tipo Coche. Dar un estado inicial a nuestro coche.
            Coche coche2 = new Coche();
            Coche coche3 = new Coche(4500.25, 1200.5);

            Console.WriteLine(coche1.getInfoCoche());
            Console.WriteLine(coche2.getInfoCoche());
            Console.WriteLine(coche3.getInfoCoche());
            coche3.setExtras(true, "Cuero");
            Console.WriteLine(coche3.getExtras());
        }
    }

    // Podemos dividir una clase en trozos utilizando la palabra reservada partial
    // Es muy útil para dividir una clase grande en partes
    partial class Coche
    {
        // El proposito de un constructor es dar un estado inicial a los objetos de tipo coches
        public Coche()
        {
            ruedas = 4;
            largo = 2300.5;
            ancho = 0.800;
            tapiceria = "Tela";
        }

        // Sobrecarga de constructores permite tener otros estados iniciales para una clase
        public Coche(double largoCoche, double anchoCoche)
        {
            ruedas = 4;
            largo = largoCoche;
            ancho = anchoCoche;
            tapiceria = "Tela";
        }
        private int ruedas;
        private double largo;
        private double ancho;
        private bool climatizador;
        private string tapiceria;

    }

    partial class Coche
    {
        public int getRuedas()
        {
            return ruedas;
        }

        public string getInfoCoche()
        {
            return $"Información del coche\nRuedas: {ruedas}\nLargo: {largo}\nAncho: {ancho}";
        }

        public void setExtras(bool climatizador, string tapiceria)
        {
            // La palabra reservada "this" nos ayuda a diferencia un campo de clase de un parametro
            this.climatizador = climatizador;
            this.tapiceria = tapiceria;
        }

        public string getExtras()
        {
            return $"Climatizador: {climatizador}\nTapiceria: {tapiceria}";
        }
    }
}
