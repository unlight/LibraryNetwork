using System.Collections.Generic;

namespace LibraryNetwork
{
	public interface IAuthorBehavior
	{
	
		List<Person> GetAuthors();
		
		void Add(Person p);
		
		bool Remove(Person p);
	}
}