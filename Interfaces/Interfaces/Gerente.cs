namespace Interfaces
{
    internal class Gerente : Empleado, IComunicacion
    {
        public Gerente(string nombreGerente) : base(nombreGerente)
        {

        }

        public string TipoPersona()
        {
            return "proveedores";
        }

        public bool EsBoliviano()
        {
            return false;
        }
    }
}
