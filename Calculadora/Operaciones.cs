namespace Calculadora
{
    internal class Operaciones
    {
        public Operaciones() { }

        public double Sumar(double primero, double segundo)
        {
            return primero + segundo;
        }

        public double Restar (double primero, double segundo)
        {
            return primero - segundo;
        }

        public double Multiplicar (double primero, double segundo)
        {
            return primero * segundo;
        }

        public double Dividir (double primero, double segundo)
        {
            return primero / segundo;
        }

        public double MasMenos (double numero)
        {
            return numero * -1;
        }

        public double ElevarAlCuadrado(double numero)
        {
            return Math.Pow(numero, 2);
        }

        public double RaizCuadrada (double numero)
        {
            return Math.Sqrt(numero);
        }

        public double Porciento(double primero, double segundo)
        {
            return this.Multiplicar(primero, segundo)/100;
        }

        public double Residuo(double primero, double segundo)
        {
            return primero % segundo;
        }

        
    }
}
