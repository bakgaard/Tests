using NUnit.Framework;
using System;
using Testalonium;
using Testalonium.Interfaces;

namespace TestaloniumTest
{
	[TestFixture]
	public class TargetTest
	{
		private ITarget _target = new Target();

		#region SetupAndTeardown
		//[SetUp]
		//public void Setup()
		//{
		//	_target = new Target();
		//}

		//[TearDown]
		//public void TearDown()
		//{
		//	_target = null;
		//}
		#endregion

		//Normal tests
		[Test]
		public void CalculateADoubleNumber_ValidNumber_ValidOutput()
		{
			var result = _target.CalculateADoubleNumber(2.0);
			Assert.AreEqual(4.0, result);
		}

		[Test]
		public void CalculateANumber_ValidInput_FailingTest()
		{
			_target.AddToANumber(2);
			_target.AddToANumber(4);
			Assert.AreEqual(6, _target.NumberToGet);
		}

		[Test]
		public void CalculateANumber_ValidInput_ValidOutput()
		{
			_target.AddToANumber(2);
			_target.AddToANumber(4);
			Assert.AreEqual(6, _target.NumberToGet);
		}

		[Test]
		public void ExceptionThrower_ShouldTrigger_WillTrigger()
		{
			Assert.Throws<ArgumentException>(() => _target.ExceptionThrower(true));
		}

		//Multiple Tests
		[TestCase(2.0, ExpectedResult = 4)]
		[TestCase(3.0, ExpectedResult = 9)]
		[TestCase(-4.0, ExpectedResult = 16)]
		public double CalculateADoubleNumber_ValidNumber_ValidOutput(double input)
		{
			return _target.CalculateADoubleNumber(input);
		}
	}
}