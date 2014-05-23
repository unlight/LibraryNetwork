using System.Collections.Generic;

namespace LibraryNetwork
{
	interface IAuthorBehavior
	{
	
		List<Person> GetAuthors();
		
		void Add(Person p);
		
		void Remove(Person p);
	}
}