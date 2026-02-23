using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.IO;

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
		static List<string> sutik = new List<string>() { "csokis muffin", "epertorta", "túrótorta", "isler", "citromtorta", "csokis puszedli", "epres muffin", "francia krémes", "duplacsokis brownie" };
		static List<string> muffinok = new List<string>();
		static List<string> acm = new List<string>();
		static List<string> megforditot = new List<string>();

		static void Sutikelhelyezese()
		{
			sutik.Add("csokitorta");
			foreach (var item in sutik)
			{
				Console.WriteLine(item);
			}
			Console.WriteLine();
		}
		static void Csokissutik()
		{
			int db = 0;
			foreach (var item in sutik)
			{
				if(item.Contains("csoki"))
				{
					Console.Write(item + " ");
					db++;
				}
			}
			Console.WriteLine();
			Console.WriteLine($"Összesen {db} darab csokis süti van a lsitában!");
			Console.WriteLine();
		}
		static void Leghosszabb()
		{
			string leghosszabb = sutik[0];
			foreach (var item in sutik)
			{
				if(leghosszabb.Length < item.Length)
				{
					leghosszabb = item;	
				}
			}
			Console.WriteLine($"A leghosszabb nevű süti: {leghosszabb}");
			Console.WriteLine();
		}
		static void Muffin()
		{
			foreach (var item in sutik)
			{
				if(item.Contains("muffin"))
				{
					muffinok.Add(item);
				}
			}


			foreach (var item in muffinok)
			{
				Console.WriteLine(item);
			}
			Console.WriteLine();
		}
		static void ACM()
		{
			string seged = "acm";
			foreach (var item in sutik)
			{
				if (seged.Contains(item[0]))
				{
					acm.Add(item);
				}
			}

			foreach (var item in acm)
			{
				Console.WriteLine(item);
			}
			Console.WriteLine();
		}

		static void Magasahangrendu()
		{
			string seged = "aáoóuú";
			foreach (var item in sutik)
			{
				//if (!item.Contains("a") && !item.Contains("á") && !item.Contains("o") && !item.Contains("ó") && !item.Contains("u") && !item.Contains("ú"))
				//{
				//	Console.WriteLine(item);
				//}

				bool MagasE = true;
				foreach (var betu in item)
				{
					if(seged.Contains(betu))
					{
						MagasE = false;
					}
				}

				if (MagasE)
				{
					Console.WriteLine(item);
				}
			}

			Console.WriteLine();
		}

		static void Spin()
		{
			foreach (var item in sutik)
			{
				//string seged = "";
				//for (int i = item.Length - 1; i > -1; i--)
				//{
				//	seged += item[i];
				//}
				//megforditot.Add(seged);
				megforditot.Add(new string(item.Reverse().ToArray()));
			}

			foreach (var item in megforditot)
			{
				Console.WriteLine(item);
			}
			Console.WriteLine();
		}
		#endregion

		#region
		static List<string> huto = new List<string>();
		static bool Feltoltes(bool feltoltot)
		{
			string be = " ";

			do
			{
				Console.Write("Mit teszünk be a hűtőbe? ");
				be = Console.ReadLine();

				if(be != "")
				{
					huto.Add(be);
				}
			} while (be != "");

			feltoltot = true;

			return feltoltot;
		}
		static void Listazas()
		{
			foreach (var item in huto)
			{
				Console.WriteLine(item);
			}
		}
		static void Kivesz()
		{
			Console.Write("Adja meg mit szeretne kivenni a hűtőböl (kiléphez adjon meg üreset): ");
			string kivesz = Console.ReadLine();

			if(huto.Contains(kivesz))
			{
				huto.Remove(kivesz);
				Console.WriteLine($"Jóétvágyat a: {kivesz}");
			}
			else
			{
				Console.WriteLine("Ezt már megetted, nincs benne a hűtőben!");
			}
		}
		static void Betesz()
		{
			Console.Write("Mit teszünk be a hűtőbe? ");
			string be = Console.ReadLine();

			if (be != "")
			{
				huto.Add(be);
				Console.WriteLine($"{be} bekerült a hűtöbe!");
			}
			else
			{
				Console.WriteLine("Nem adott meg információt!");
			}
		}
		static void Kiurit()
		{
			huto.Clear();
			Console.WriteLine("Hűtő kiüritve jellenleg nincs benne semmi!");
		}
		static void Kiirfajba()
		{
			StreamWriter sr = new StreamWriter("huto.txt");

			foreach (var item in huto)
			{
				string s = $"{item}\n";
				sr.Write(s);
			}
			Console.WriteLine("A hűtő tartalma ki lett írva fájlba!");
			sr.Close();
		}
		static void Beolvasfajlbol()
		{
			StreamReader sr = new StreamReader("huto.txt");
			while( sr.EndOfStream )
			{
				huto.Add(sr.ReadLine().ToString());
			}
			sr.Close();	
		}
		static void Huto()
		{
			char be = ' ';
			bool feltoltot = false;
			do
			{
				if(!feltoltot)
				{
					feltoltot = Feltoltes(feltoltot);
				}
				Console.Write("Adjon meg utasítást:\n\tListáza ki a hűtő tartalmát: (1)\n\tKivesz egy ételt a hűtőböl: (2)\n\tBetesz valamit a hűtőbe: (3)\n\tKitakarítja a hűtő tartalmát: (4)\n\tKiírja a hűtő tartalmát fájlba: (5)\n\tBeolvasuk a fájl tartalmát faájból: (6)\n\tKilépés: (7)");
				be = Console.ReadLine()[0];

				switch(be)
				{
					case '1':
						Listazas();
						break;

					case '2':
						Kivesz();
						break;

					case '3':
						Betesz();
						break;

					case '4':
						Kiurit();
						break;

					case '5':
						Kiirfajba();
						break;

					case '6':
						Beolvasfajlbol();
						break;

					case '7':
						Console.WriteLine("Kilépés...");
						break;

					default:
						Console.WriteLine("A folyamat csak az utasítások melleti számokkal müködik!");
						break;
				}

			} while (be != '6');
		}
		#endregion
		static void Main(string[] args)
		{
			#region bevezetes
			//Feltolt(15);
			//negativSzamok();
			//atlag();
			#endregion

			#region Sütik
			Sutikelhelyezese();
			Csokissutik();
			if(sutik.Contains("epertorta"))
			{
				Console.WriteLine("Van epertorta");
			}
			else
			{
				Console.WriteLine("Nincs epertorta");
			}
			Leghosszabb();
			sutik.Sort();
			foreach (var item in sutik)
			{
				Console.WriteLine(item);
			}
			Console.WriteLine();
			Muffin();
			ACM();
			Magasahangrendu();
			Spin();
			#endregion

			#region
			Huto();
			#endregion

			Console.ReadKey();
		}
	}
}
