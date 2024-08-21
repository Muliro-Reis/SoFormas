using System;

namespace WfaFormas
{
    public class TR : Triangulo
    {
        public override double CalcularArea()
        {
            return A * B / 2;
        }

        public override double CalcularPerimetro()
        {
            return A + B + Math.Sqrt(A * A + B * B);
        }
    }
}
