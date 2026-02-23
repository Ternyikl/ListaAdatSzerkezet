using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaAdatSzerkezet
{
	internal class Program
	{
		static List<int> lista = new List<int>();

		static void Feltolt(int elemekszama)
		{
			for (int i = 0; i < elemekszama; i++)
			{
				lista.Add(i);
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
		static void Main(string[] args)
		{
			Feltolt(15);
		}
	}
}
