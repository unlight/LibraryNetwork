/*
 * Date: 24.05.2014
 * Time: 1:18
 */
using System.Collections.Generic;

namespace LibraryNetwork
{

	interface ICatalogRepository
	{
		IEnumerable<Item> GetItems();
		
		IEnumerable<Item> FindByName(string name);
		
		IEnumerable<Item> SortByYear(string direction = null);
		
		IEnumerable<Item> FindByAuthor(Person p, bool isSole = false);
	}
}
