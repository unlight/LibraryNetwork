/*
 * Date: 24.05.2014
 * Time: 13:49
 */
using System;
using LibraryNetwork;

namespace UnitTest
{
	/// <summary>
	/// Description of ItemFactory.
	/// </summary>
	public class UnitFactory
	{
	
		
		public static Book CreateBook() {
			var item = new Book(Guid.NewGuid().ToString());
			return item;
		}
		
		public static Person CreatePerson() {
			var item = new Person();
			item.FirstName = Guid.NewGuid().ToString();
			item.LastName = Guid.NewGuid().ToString();
			
			return item;
		}
	}
}
