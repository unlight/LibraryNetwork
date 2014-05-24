/*
 * Date: 24.05.2014
 * Time: 1:18
 */
using System.Collections.Generic;

namespace LibraryNetwork
{

	public interface ICatalogRepository
	{
		IEnumerable<Item> GetItems();
		
		void Add(Item item);

		bool Remove(Item item);
		
		IEnumerable<Item> FindByName(string name);
		
		IEnumerable<Item> SortByYear(string direction = null);
		
		IEnumerable<Item> FindByAuthor(Person p, bool isSole = false);
	}
}
