using System;
namespace LibraryNetwork
{
	internal class NewsPaper : Item
	{
	

		internal NewsPaper(string name)
			: base(name)
		{
			AuthorBehavior = new NoAuthors();
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


		int? issueNumber;
		
		public int? IssueNumber {
			get { return issueNumber; }
			set { issueNumber = value; }
		}
		
		
		DateTime? issueDate;
		
		public DateTime? IssueDate {
			get { return issueDate; }
			set { issueDate = value; }
		}
		
		
		string issn;
		
		public string ISSN {
			get { return issn; }
			set {
				if (value != null && !Regex.IsMatch(value, Constants.ISSN_REGEX)) {
					throw new InvalidOperationException("ISSN");
				}
				issn = value;    	
			}
		}
				
	}
}