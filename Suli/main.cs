using System.ComponentModel;

using Suli;
Random random = new Random();

void ListaKiír(List<int> lista)
{
	Console.Write("{ ");
	foreach(int i in lista)
	{
		Console.Write(i);
		Console.Write(", ");
	}
	Console.Write(" }");
}

List<int> tesztLista = new List<int>();
int c = random.Next(5, 1000);
for(int i = 0; i < c; i++)
{
	tesztLista.Add(random.Next(-69420, 69420));
}
;

Rendezett.RendezettLista rl = new Rendezett.RendezettLista();

rl.Hozzáad(69);
rl.Hozzáad(420);
rl.Hozzáad(-1);
rl.Hozzáad(-9999);
rl.Töröl(-1);
rl.Hozzáad(435324535);

ListaKiír(rl.Tartalom);