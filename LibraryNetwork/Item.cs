using System.Collections.Generic;
using System.Collections;
	
namespace LibraryNetwork
{
	internal abstract class Item
	{
	
		protected IAuthorBehavior AuthorBehavior;
		protected IYearBehavior YearBehavior;
		protected IPageCountBehavior PageCountBehavior = new PageCountInfo();
	
		internal Item(string name)
		{
			Name = name;
		}
	
		public string Name { get; set; }
	
		public List<Person> GetAuthors()
		{
			return AuthorBehavior.GetAuthors();
		}
		
		public int? Year { 
			get {
				return YearBehavior.Year;
			}
		}
		
		public int PageCount {
			get {
				return PageCountBehavior.PageCount;
			}
			set {
				PageCountBehavior.PageCount = value;
			}
		}
		
		string note;
		
		public string Note {
			get { return note; }
			set { note = value; }
		}
	
	}
}