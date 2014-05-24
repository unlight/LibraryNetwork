using System;
using System.Collections.Generic;
using System.Collections;
using System.Text.RegularExpressions;
	
namespace LibraryNetwork
{
	public abstract class Item
	{
	
		protected IAuthorBehavior AuthorBehavior;
		protected IYearBehavior YearBehavior;
		protected IPageCountBehavior PageCountBehavior = new PageCountInfo();
	
		internal Item(string name)
		{
			Name = name;
		}
	
		string name;
		public string Name {
			get {
				return name;
			}
			set {
				if (value.Length > Constants.NAME_MAX_LENGTH) {
					throw new InvalidOperationException("Name");
				}
				name = value;
			}
		}
	
		public List<Person> GetAuthors()
		{
			return AuthorBehavior.GetAuthors();
		}
		
		public int? Year { 
			get {
				return YearBehavior.Year;
			}
		}
		
		public int? PageCount {
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
			set { 
				if (value != null && !Regex.IsMatch(value, Constants.NOTE_REGEX)) {
					throw new ArgumentException("Note.Regex");
				}
				note = value; 
			}
		}
	
		
		public virtual void AddAuthor(Person p) {
			AuthorBehavior.Add(p);
		}
		
		public virtual bool RemoveAuthor(Person p) {
			return AuthorBehavior.Remove(p);
		}
		
		public bool IsHasAuthors() {
			var authors = AuthorBehavior.GetAuthors();
			return (authors != null && authors.Count > 0);
		}
	}
}