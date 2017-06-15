using Testalonium.Interfaces;

namespace Testalonium
{
	public class Target2 : ITarget2
	{
		private readonly IFakeDatabase _database;

		public Target2(IFakeDatabase database)
		{
			_database = database;
		}

		/// <summary>
		/// Get data from database
		/// </summary>
		public int GetData()
		{
			var data = _database.ReadData();
			return data;
		}

		/// <summary>
		/// Set data in database
		/// </summary>
		/// <param name="value"></param>
		public void SetDate(int value)
		{
			_database.SetData(value);
		}
	}
}
