using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Suli
{
	public static partial class Rendezések
	{
		public static void minimumkiválasztásos_rendezés(List<int> lista)
		{
			for(int i = 0; i < lista.Count; i++)
			{
				int minindex = i;
				for(int j = i + 1; j < lista.Count; j++)
				{
					if (lista[minindex] > lista[j])
					{
						minindex = j;
					}
				}
				Csere(lista, minindex, i);
			}
		}
	}
}
