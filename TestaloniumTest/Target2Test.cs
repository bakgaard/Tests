using NSubstitute;
using NUnit.Framework;
using System;
using Testalonium;
using Testalonium.Interfaces;

namespace TestaloniumTest
{
	[TestFixture]
	public class Target2Test
	{
		private ITarget2 _target2;
		private IFakeDatabase _fakeDatabase;

		#region SetupAndTeardown
		[SetUp]
		public void Setup()
		{
			_fakeDatabase = Substitute.For<IFakeDatabase>();
			_target2 = new Target2(_fakeDatabase);
		}

		[TearDown]
		public void TearDown()
		{
			_target2 = null;
			_fakeDatabase = null;
		}
		#endregion

		[Test]
		public void ReadData_UseRealObject_ThrowException()
		{
			var db = new FakeDatabase();
			_target2 = new Target2(db);

			Assert.Throws<NotImplementedException>(() => _target2.GetData());
		}

		[Test]
		public void ReadData_UseSpecificFakeObject_ReturnSpecifiedValue()
		{
			//Setup fake database
			_fakeDatabase.ReadData().Returns(4);

			var data = _target2.GetData();

			Assert.AreEqual(4, data);
		}

		[Test]
		public void ReadData_UseAnyFakeObject_ReturnAnyValue()
		{
			//Setup fake database
			var fakeValue = 42;
			_fakeDatabase.ReadData().Returns(fakeValue);

			var data = _target2.GetData();

			Assert.AreEqual(fakeValue, data);
		}

		[Test]
		public void SetData_CheckCall_CallWasMade()
		{
			//Setup fake database
			var fakeValue = 0;
			_target2.SetDate(fakeValue);

			_fakeDatabase.Received().SetData(fakeValue);
		}

		[Test]
		public void SetData_UseAnyFakeObject_ReturnAnyValue()
		{
			//Setup fake for "needed" call
			var fakeValue = Arg.Any<int>();
			_target2.SetDate(fakeValue);

			_fakeDatabase.ReadData().Returns(fakeValue);

			var data = _target2.GetData();
			Assert.AreEqual(fakeValue, data);
		}
	}
}