/*
 * Date: 24.05.2014
 * Time: 0:27
 */
using System;
using System.Collections.Generic;
using System.Linq;

namespace LibraryNetwork
{
	internal class MemoryCatalog : List<Item>, ICatalogRepository
	{
		public MemoryCatalog()
		{
			
		}
		
		public IEnumerable<Item> GetItems()
		{
			return this;
		}
		
		public IEnumerable<Item> FindByName(string name)
		{
			return this.FindAll(i => i.Name == name);
		}
		
		public IEnumerable<Item> SortByYear(string direction = null)
		{
//			Func<Item, int?> func = (x) => x.Year;
//			Func<Item, int?> d = delegate (Item item) {
//				return item.Year;
//			};
			if (direction == null || direction != "desc") {
				this.OrderBy(x => x.Year);
			} else {
				this.OrderByDescending(x => x.Year);
			}
			
			return this;
			
		}
		
		public IEnumerable<Item> FindByAuthor(Person p, bool isSole = false)
		{
			return this.FindAll(item => {
				var authors = item.GetAuthors();
				return (authors != null && authors.Contains(p) && (isSole == false || (isSole && authors.Count == 1)));
			});
		}
	}
}
