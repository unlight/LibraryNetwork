/*
 * Date: 24.05.2014
 * Time: 13:04
 */
using System;
using System.Text;
using System.ComponentModel;
using NUnit.Framework;
using LibraryNetwork;

namespace UnitTest
{
	[TestFixture]
	internal class UnitBook
	{
		ICatalogRepository catalog = new MemoryCatalog();
		string LongStrting = new String('*', Constants.NAME_MAX_LENGTH + 1);

		[Test]
		public void NamePos()
		{
			new Book("Animal Farm");
		}
		
		[Test]
		[ExpectedException(typeof(InvalidOperationException))]
		public void NameNeg()
		{
			new Book(LongStrting);
		}
		
//		[Test]
//		public void AuthorsHasOne() {
//			var item = UnitFactory.CreateBook();
//			var person = UnitFactory.CreatePerson();
//			item.AddAuthor(person);
//			Assert.IsTrue(item.IsHasAuthors());
//		}
//		
//		[Test]
//		public void AuthorsEmpty() {
//			var item = UnitFactory.CreateBook();
//			Assert.IsFalse(item.IsHasAuthors());
//		}
		
		[SetUp]
		public void Init()
		{
		}
		
		[TearDown]
		public void Dispose()
		{
		}
	}
}
