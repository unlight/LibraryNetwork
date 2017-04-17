using System.Collections.Generic;

namespace LibraryNetwork
{
	internal class NoAuthors : IAuthorBehavior
	{
		public void Add(Person p)
		{
		}

		public bool Remove(Person p)
		{
			return false;
		}

		public List<Person> GetAuthors()
		{
			return null;
		}
	
	}
}