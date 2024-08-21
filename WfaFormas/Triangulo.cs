namespace WfaFormas
{
    public abstract class Triangulo : FormaGeometrica
    {
		private double a;

		public double A
		{
			get { return a; }
			set { a = value; }
		}

		private double b;

		public double B
		{
			get { return b; }
			set { b = value; }
		}

		private double lado;

		public double Lado
		{
			get { return lado; }
			set { lado = value; }
		}

	}
}
