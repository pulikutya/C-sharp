using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Suli
{
	public static partial class Rendezések
	{
		public static void Csere(List<int> lista, int i1, int i2)
		{
			int temp = lista[i1];
			lista[i1] = lista[i2];
			lista[i2] = temp;
		}
	}
}
