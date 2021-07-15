using System;


public class СomputationSinWEps
{
	public double x { get; set; }
	public double a { get; set; }
	public int k { get; set; }
	public double eps { get; set; }

	public СomputationSinWEps(double x, double a, int k, double eps)
	{
		this.x = x;
		this.a = a;
		this.k = k;
		this.eps = eps;
	}

	public СomputationSinWEps()
	{
	
	}

	public double GetSinValue(double x, double a, int k, double eps)
	{
		if (Math.Abs(a) > eps)
		{
			return a + GetSinValue(x, a * (-Math.Pow(x, 2) / (2 * k + 3) / (2 * k + 2)), k + 1, eps);
		}

		return a;
	}

	public double GetSinValue()
	{
		if (Math.Abs(a) > eps)
		{
			return a + GetSinValue(x, a * (-Math.Pow(x, 2) / (2 * k + 3) / (2 * k + 2)), k + 1, eps);
		}

		return a;
	}


}

