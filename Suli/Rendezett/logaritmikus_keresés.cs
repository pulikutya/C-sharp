using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Suli
{
	public static partial class Rendezett
	{
		public static int logaritmikus_keresés(List<int> lista, int Elem) //ha nincs benne az elem akkor azt adja vissza hogy hova kéne tenni az elemet
		{
			if(lista.Count == 0) { return -1; }
			int eleje = 0;
			int vége = lista.Count-1;
			int közepe;

			do
			{
				közepe = (eleje + vége) / 2;
				if (lista[közepe] > Elem) //a szegmens bal oldali felében keresünk tovább
				{
					vége = közepe-1;
				}
				else if (lista[közepe] < Elem) //a szegmens jobb oldali felében keresünk tovább
				{
					eleje = közepe + 1;
				}
				else //ha egyenlő akkor meg találtuk
				{
					return közepe;
				}
			}
			while (vége >= eleje);

			if (lista[közepe] == Elem)//megtaláltuk
			{
				return közepe;
			}
			else //nem találtuk meg szóval a helyét küldjük vissza
			{
				return eleje;
			}
		}

		
	}
}
