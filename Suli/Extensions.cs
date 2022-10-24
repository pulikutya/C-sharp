using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Suli
{
	public static class Extensions
	{
		public static string IntIEToString(this IEnumerable<int> IE)
		{
			string r = "{ ";
			foreach (var i in IE)
			{
				r += i.ToString() + ", ";
			}
			r += " }";
			return r;
		}
	}
}
