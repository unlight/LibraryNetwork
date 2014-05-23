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
				year = value;
			}
				
		}
	}
}
