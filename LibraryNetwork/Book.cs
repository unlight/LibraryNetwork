using System;

/*
Название
Автор(ы) 
Место издания (город)
Название издательства
Год издания
Количество страниц
Примечание
Международный стандартный номер книги (ISBN)
*/

namespace LibraryNetwork
{
	internal class Book : Item
	{
	
		internal Book(string name)
			: base(name)
		{
			AuthorBehavior = new HasAuthors();
			YearBehavior = new YearInfo();
		}
		
		ICityInfo CityInfo = new CityInfo();
		
		public string City {
			get {
				return CityInfo.City;
			}
			set {
				CityInfo.City = value;
			}
		}
		
		IPublisherInfo PublisherInfo = new PublisherInfo();
		
		public string PublisherName {
			get {
				return PublisherInfo.Name;
			}
			set {
				PublisherInfo.Name = value;
			}
		}
		
		string isbn;
		
		public string ISBN {
			get { return isbn; }
			set { isbn = value; }
		}
	}
}