/*
 * Date: 23.05.2014
 * Time: 23:35
 */
using System;

namespace LibraryNetwork
{
	/// <summary>
	/// Description of PublisherInfo.
	/// </summary>
	public class PublisherInfo : IPublisherInfo
	{
		
		private string _name;

		public string Name {
			get {
				return _name;
			}
			set {
				_name = value;
			}
		}

	}
}
