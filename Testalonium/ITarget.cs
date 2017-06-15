namespace Testalonium
{
	public interface ITarget
	{
		int NumberToGet { get; set; }
		void AddToANumber(int a);
		double CalculateADoubleNumber(double a);
		void ExceptionThrower(bool shouldThrow);
	}
}