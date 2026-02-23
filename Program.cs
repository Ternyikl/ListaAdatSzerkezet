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
			}
			Console.WriteLine($"Az elemek száma a listában: {lista.Count}");
			for (int i = 0; i < lista.Count; i++)
			{
				Console.WriteLine(lista[i] + " ");
			}
		}
		static void Main(string[] args)
		{
			Feltolt(15);
		}
	}
}
