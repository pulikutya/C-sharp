using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Suli {
	static class Rendetett
	{
		public static List<int> Unió(List<int> rendezett1, List<int> rendezett2, bool TöbbElem = true)
		{
			List<int> r = new List<int>();
			int i = 0;
			int j = 0;
			while(i < rendezett1.Count && j < rendezett2.Count)
			{
				if(rendezett1[i] > rendezett2[j])
				{
					r.Add(rendezett2[j]);
					j++;
				}
				else if(rendezett1[i] < rendezett2[j])
				{
					r.Add(rendezett1[i]);
					i++;
				}
				else
				{
					r.Add(rendezett1[i]);
					r.Add(rendezett2[j]);
					i++; j++;
				}
			}

			while(i < rendezett1.Count)
			{
				r.Add(rendezett1[i]);
				i++;
			}

			while(j < rendezett2.Count)
			{
				r.Add(rendezett1[j]);
				j++;
			}


			return r;
		}
	}
}
