using System;
using System.IO;
	
namespace LibraryNetwork
{
	internal class Patent : Item
	{
	
		public Patent(string name)
			: base(name)
		{
			AuthorBehavior = new HasAuthors();
		}
		
		
		string country;
		
		public string Country {
			get { return country; }
			set { country = value; }
		}
		
	
		int? registrationNumber;
		
		public int? RegistrationNumber {
			get {
				return registrationNumber;
			}
			set {
				if (value <= 0) {
					throw new InvalidDataException("RegistrationNumber");
				}
				registrationNumber = value;
			}
		}
		
		
		DateTime? dateRequested;
		
		public DateTime? DateRequested {
			get { return dateRequested; }
			set { dateRequested = value; }
		}
		
		DateTime? datePublished;
		
		public DateTime? DatePublished {
			get { return datePublished; }
			set { datePublished = value; }
		}
		
		public new int? Year { 
			get {
				int? result = null;
				if (datePublished.HasValue) {
					result = datePublished.Value.Year;
				}
				return result;
			}
		}
	
	}
}