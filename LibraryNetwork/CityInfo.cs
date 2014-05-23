using System;
using System.Text.RegularExpressions;

namespace LibraryNetwork
{
	internal class CityInfo : ICityInfo
	{
		private string _value;
		
		public string City {
			get { 
				return _value; 
			}
			set {
				if (value != null) {
					if (value.Length > Constants.CITY_MAX_LENGTH) {
						throw new Exception("City");
					}
					// This shouldn't consist of a mixed characters.
					if (!Regex.IsMatch(value, Constants.NICE_NAME_REGEX)) {
						throw new ArgumentException("City is not nice name.");
					}
				}
				_value = value;
			}
		}
	}
}