/*
 * Date: 23.05.2014
 * Time: 23:46
 */
using System;

namespace LibraryNetwork
{
	/// <summary>
	/// Description of YearInfo.
	/// </summary>
	public class YearInfo : IYearBehavior
	{
		private int? year;
		
		public YearInfo()
		{
		}
		
		
		public int? Year {
			get {
				return year;
			}
			set {
				if (value != null && value.Value > DateTime.Now.Year) {
					throw new ArgumentException("YearInfo.Value.Now");
				}
				year = value;
			}
				
		}
	}
}
