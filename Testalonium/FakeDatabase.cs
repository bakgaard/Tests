using System;
using Testalonium.Interfaces;

namespace Testalonium
{
	public class FakeDatabase : IFakeDatabase
	{
		/// <summary>
		/// Return data from a database. Maybe succesfully?
		/// </summary>
		public int ReadData()
		{
			throw new NotImplementedException("No connection to database");
		}

		/// <summary>
		/// Set data into a database. Maybe Sucessfully?
		/// </summary>
		public void SetData(int value)
		{
			throw new NotImplementedException("No connection to database");
		}
	}
}