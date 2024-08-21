using System;

namespace WfaFormas
{
    public class TI : Triangulo
    {
        public override double CalcularArea()
        {
            return A * B / 2;
        }

        public override double CalcularPerimetro()
        {
            return A + B + Math.Sqrt(A * A + B / 2 * B / 2);
        }
    }
}
