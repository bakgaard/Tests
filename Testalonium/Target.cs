using System;
using Testalonium.Interfaces;

namespace Testalonium
{
	public class Target : ITarget
	{
		public int NumberToGet { get; set; } = 0;

		/// <summary>
		/// Square the input.
		/// </summary>
		public double CalculateADoubleNumber(double a)
		{
			var result = Math.Pow(a, 2);
			return result;
		}

		/// <summary>
		/// Add the input to a property
		/// </summary>
		public void AddToANumber(int a)
		{
			NumberToGet += a;
		}

		/// <summary>
		/// Can through exception
		/// </summary>
		public void ExceptionThrower(bool shouldThrow)
		{
			if (shouldThrow)
				throw new ArgumentException("Fuu!", new Exception("Throwing exceptions all day!"));
		}
	}
}
