/*
 * Date: 24.05.2014
 * Time: 0:13
 */
using System;

namespace LibraryNetwork
{
	/// <summary>
	/// Description of PageCountInfo.
	/// </summary>
	public class PageCountInfo : IPageCountBehavior
	{
		int? _value;
		
		
		public int? PageCount {
			get {
				return _value;
			}
			set {
				if (value != null && value < 0) {
					throw new ArgumentException("PageCount.Negative");
				}
				_value = value;
			}
		}
	}
}
