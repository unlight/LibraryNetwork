/*
 * Date: 23.05.2014
 * Time: 23:32
 */
using System;
using System.Text.RegularExpressions;

namespace LibraryNetwork
{
	/// <summary>
	/// Description of Class1.
	/// </summary>
	public class Person
	{
		public Person()
		{
		}
		
		
		string firstName;
		public string FirstName { 
			get {
				return firstName;
			}
			set {
				if (value != null) {
					if (value.Length > Constants.PERSON_FIRSTNAME_MAX_LENGTH) {
						throw new ArgumentException("FirstName.Long");
					}
					if (!Regex.IsMatch(value, Constants.NICE_PERSON_NAME_REGEX)) {
						throw new ArgumentException("FirstName is not nice name.");
					}
				}
			}
		}

		string lastName;
		public string LastName { 
			get {
				return lastName;
			}
			set {
				if (value != null) {
					if (value.Length > Constants.PERSON_LASTNAME_MAX_LENGTH) {
						throw new ArgumentException("LastName.Long");
					}
					if (!Regex.IsMatch(value, Constants.NICE_PERSON_NAME_REGEX)) {
						throw new ArgumentException("LastName is not nice name.");
					}
				}
			}
		}
	}
}
