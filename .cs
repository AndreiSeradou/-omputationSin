using System;


	public class СomputationSinW
	{
		public double x { get; set; }
		public double a { get; set; }
		public int k { get; set; }
		public double eps { get; set; }

		public СomputationSin(double x, double a, int k, double eps)
		{
			this.x = x;
			this.a = a;
			this.k = k;
			this.eps = eps;
		}

		public double GetSinValue(double x, double a, int k, double eps)
		{
			if (abs(a) > eps)
			{
				return a + GetSinWithEpsilon(x, a * (-pow(x, 2) / (2 * k + 3) / (2 * k + 2)), k + 1, eps);
			}

			return a;
		}

		public double GetSinValue()
		{
			if (abs(this.a) > this.eps)
			{
				return this.a + GetSinValue(this.x, this.a * (-pow(this.x, 2) / (2 * this.k + 3) / (2 * this.k + 2)), this.k + 1, this.eps);
			}

			return this.a;
		}


	}

