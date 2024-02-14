namespace GenericosRestricciones
{
    // Así se crea una clase generica con restriciones
    internal class AlmacenEmpleados<T> where T : IParaEmpleados
    {
        private int _i = 0;
        private T[] _datosEmpleado;

        public AlmacenEmpleados(int z)
        {
            _datosEmpleado = new T[z];
        }

        public void Agregar(T obj)
        {
            _datosEmpleado[_i] = obj;
            _i++;
        }

        public T GetEmpleado()
        {
            return _datosEmpleado[_i];
        }
    }
}
