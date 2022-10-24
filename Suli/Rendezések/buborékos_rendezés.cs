using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Suli
{
	public static partial class Rendezések
	{
		public static void buborékos_rendezés(List<int> lista)
		{
			for(int vége = lista.Count; vége > 0; vége--)
			{
				for(int i = 1; i < vége; i++)
				{
					if (lista[i] < lista[i-1])
					{
						Csere(lista, i, i-1);
					}
				}
			}
		}

		public static void buborékos_rendezés_optimizált(List<int> lista)
		{
			for (int vége = lista.Count; vége > 0; vége--)
			{
				int i = 1;
				for (; i < vége-1; i++)
				{
					if (lista[i] < lista[i - 1])
					{
						Csere(lista, i, i - 1);
					}
				}
				;
				if (lista[i] < lista[i-1])
				{
					Csere(lista, i, i-1);
					
				}
				else 
				{
					vége--;
				}
			}
		}
	}
}
