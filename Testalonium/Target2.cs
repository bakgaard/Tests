namespace Testalonium
{
	public class Target2 : ITarget2
	{
		private IFakeDatabase _database;

		public Target2(IFakeDatabase database)
		{
			_database = database;
		}

		public int GetData()
		{
			var data = _database.ReadData();
			return data;
		}

		public void SetDate(int value)
		{
			_database.SetData(value);
		}
	}
}
