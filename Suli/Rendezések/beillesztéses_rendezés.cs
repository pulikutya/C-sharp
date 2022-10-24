using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Suli
{
	public static partial class Rendezések
	{
		public static void beillesztéses_rendezés(List<int> lista)
		{
			for (int i = 1; i < lista.Count; i++)
			{
				for (int j = i; j >= 1 && lista[j] < lista[j-1]; j--)
				{
					Csere(lista, j, j-1);
				}
			}
		}
	}
	
}
