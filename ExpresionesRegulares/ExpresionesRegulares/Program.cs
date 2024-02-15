using System.Text.RegularExpressions;

namespace ExpresionesRegulares
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string frase = "Mi nombre es Jonny y mi n° de telefono es (+591) 788-586-28 y mi código postal es: 12345";

            // Herramienta de visual studio Edit -> Find and Remplace -> Quick Find activate expresion regular
            //string patron = "[S]";
            //string patron = @"\d{3}-";
            string patron = @"\+591";

            Regex regex = new Regex(patron);

            MatchCollection matches = regex.Matches(frase);

            if (matches.Count > 0 ) { Console.WriteLine("Coincidencia"); } else { Console.WriteLine("Sin coincidencia"); }
        }
    }

    /*
     * EXPRESIONES REGULARES
     * - Son secuencias de caracteres que funcionan como un patrón de búsqueda
     * - Buscan cadenas de caracteres: letras, números, otros caracteres...
     * - Si dominas las expresiones regulares las podrás utilizar en innumerables escenarios:
     * validación de formularios, búsquedas en ficheros externos, búsqwuedad en BBDD, 
     * comprobación de entradas de usuarios etc.
     * FUNCIONAMIENTO DE EXPRESIONES REGULARES
     * Clases útiles:
     * - Regex
     * - Match
     * - MatchCollection
     * - GroupCollection
     * Métodos útiles:
     * - Matches
     * Propiedades útiles:
     * - Groups
     */
}
