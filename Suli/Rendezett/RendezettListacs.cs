using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Suli
{
	public static partial class Rendezett
	{
		public class RendezettLista
		{
			
			public List<int> Tartalom = new List<int>();
			public RendezettLista(List<int>? Tartalom = null, bool reF = true)
			{
				if (Tartalom != null)
				{
					if(reF)
					{
						this.Tartalom = Tartalom;
					}
					else
					{
						foreach(int i in Tartalom) //lemásolja a listát
						{
							Tartalom.Add(i);
						}
					}
					
					Rendezések.minimumkiválasztásos_rendezés(this.Tartalom);
				}
			}


			public int Count => Tartalom.Count;
			private void LogaritmikusanKeres(int Elem) => logaritmikus_keresés(Tartalom, Elem);
			public void Hozzáad(int Elem)
			{
				if(Tartalom.Count == 0)
				{
					Tartalom.Add(Elem);
				}
				else
				{
					Tartalom.Insert(logaritmikus_keresés(Tartalom, Elem), Elem);
				}
			}

			
			
			public bool Töröl(int Elem) => Tartalom.Remove(Elem);
			public void TörölIndex(int index) => Tartalom.RemoveAt(index);


			public int this[int index] => Tartalom[index];
			
		}
	}
	
}
