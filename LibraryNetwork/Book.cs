﻿using System;
using System.Text.RegularExpressions;

namespace LibraryNetwork
{
	public class Book : Item
	{
	
		public Book(string name)
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
			set {
				if (value != null && !Regex.IsMatch(value, Constants.ISBN_REGEX)) {
					throw new InvalidOperationException("ISBN");
				}
				isbn = value;
			}
		}
	}
}