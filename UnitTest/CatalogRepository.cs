/*
 * Date: 24.05.2014
 * Time: 13:01
 */
using System;
using System.Collections.ObjectModel;
using System.Linq;
using NUnit.Framework;
using LibraryNetwork;
using NUnit.Framework.Constraints;

namespace UnitTest
{
	[TestFixture]
	public class CatalogRepository
	{
		private ICatalogRepository catalogRepository = new MemoryCatalog();
		private Item[] items = new Item[4];
			
		[SetUp]
		public void Init()
		{
			items[0] = UnitFactory.CreateBook();
			items[1] = UnitFactory.CreateBook();
			items[2] = UnitFactory.CreateNewsPaper();
			items[3] = UnitFactory.CreatePatent();
			for (var i = 0; i < items.Length; i++) {
				catalogRepository.Add(items[i]);
			}
		}
		
		[TearDown]
		public void Dispose()
		{
			for (var i = 0; i < items.Length; i++) {
				catalogRepository.Remove(items[i]);
			}
		}
		
//⦁	Отображение списка всех книг в каталоге
//Описание	Добавить в каталог известное количество записей. Вызвать метод для получения всех существующих записей.
//Результат	Тест считается успешным, если добавленные записи в каталог, совпадают с записями, которые вернет вызванный метод.

		[Test]
		public void GetItems() {
			var checkItems = catalogRepository.GetItems().ToList();
			for (var i = 0; i < checkItems.Count; i++) {
				Assert.Contains(checkItems[i], this.items);
			}
		}

	}
}
