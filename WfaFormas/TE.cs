using System;

namespace WfaFormas
{
    public class TE : Triangulo
    {
        public override double CalcularArea()
        {
            return Lado * Math.Sqrt(Lado * Lado - Lado / 2 * Lado / 2);
        }

        public override double CalcularPerimetro()
        {
            return Lado * 3;
        }
    }
}
