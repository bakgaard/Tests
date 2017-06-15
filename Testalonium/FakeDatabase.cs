using System;

namespace Testalonium
{
	public class FakeDatabase : IFakeDatabase
	{
		public int ReadData()
		{
			throw new NotImplementedException("No connection to database");
		}

		public void SetData(int value)
		{
			throw new NotImplementedException("No connection to database");
		}
	}
}
