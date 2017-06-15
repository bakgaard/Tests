using System;

namespace Testalonium
{
	public class NoConnectionDatabaseException : Exception
	{
		public NoConnectionDatabaseException(string message) : base(message)
		{ }
	}
}
