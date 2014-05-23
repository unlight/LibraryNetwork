using System;
using System.Collections.Generic;
using System.Linq;
	
namespace LibraryNetwork
{
	
	internal class HasAuthors : List<Person>, IAuthorBehavior
	{

		public List<Person> GetAuthors()
		{
			return this;
		}

		void IAuthorBehavior.Remove(Person p)
		{
			this.Remove(p);
		}
	}
}