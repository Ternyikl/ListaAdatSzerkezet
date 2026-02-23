using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaAdatSzerkezet
{
	internal class Program
	{
		static Random rnd = new Random();
		#region bevezetes
		static List<int> lista = new List<int>();
		static void Feltolt(int elemekszama)
		{
			for (int i = 0; i < elemekszama; i++)
			{
				lista.Add(rnd.Next(-20, 21));
				Console.WriteLine($"Az index: {i} - capacitás: {lista.Capacity}");
			}
			Console.WriteLine($"Az elemek száma a listában: {lista.Count}");
			for (int i = 0; i < lista.Count; i++)
			{
				Console.Write(lista[i] + " ");
			}
			Console.WriteLine();
			Console.WriteLine($"A lista első elem: {lista[0]}");
			Console.WriteLine($"A lista utólsó elem: {lista[lista.Count - 1]}");
			Console.WriteLine($"A lista legnagyobb elem: {lista.Max()}");
			Console.WriteLine($"A lista legkisebb elem: {lista.Min()}");
			Console.WriteLine();
			
		}

		static void negativSzamok()
		{
			int negativok = 0;

			foreach (var item in lista)
			{
				if(item < 0)
				{
					negativok++;
					Console.Write(item + " ");
				}
			}

			Console.WriteLine($"A listában {negativok} darab negatív szám van!");
			Console.WriteLine($"A pozítiv számok száma: {lista.Count(x => x > 0)}");
		}
		static void atlag()
		{
			int ossz = lista.Sum();
			int db = lista.Count;
			double atlag = (double)ossz / db;
			Console.WriteLine($"A lista elemeinek átlaga: {Math.Round(atlag, 2)}");
			Console.WriteLine($"A lista elemeinek átlaga: {Math.Round(lista.Average(), 2)}");
		}
		#endregion

		#region Sütik
		static List<string> sutik = new List<string>() { "csokis muffin", "epertorta", "túrótorta", "isler", "citromtorta", "csokis puszedli", "epres muffin", "francia krémes" };

		static void sutikelhelyezese()
		{
			sutik.Add("csokitorta");
			foreach (var item in sutik)
			{
				Console.WriteLine(item);
			}
		}
		#endregion
		static void Main(string[] args)
		{
			//Feltolt(15);
			//negativSzamok();
			//atlag();

			sutikelhelyezese();
		}
	}
}
