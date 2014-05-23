using System.Collections.Generic;

namespace LibraryNetwork
{
	internal class NoAuthors : IAuthorBehavior
	{
		public void Add(Person p)
		{
		}

		public void Remove(Person p)
		{
		}

		public List<Person> GetAuthors()
		{
			return null;
		}
	
	}
}