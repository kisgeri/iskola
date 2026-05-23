//7. feladat
Dictionary<string, int> statisztika = new Dictionary<string, int>();
foreach (var item in lista)
{
	if (statisztika.ContainsKey(item.Orszag))
	{
		statisztika[item.Orszag]++;
	}
	else
	{
		statisztika.Add(item.Orszag, 1);
	}
}

Console.WriteLine("7. feladat");
foreach (var item in statisztika)
{
	Console.WriteLine($"\t{item.Key} - {item.Value}");
}

//8. feladat
StreamWriter sw = new StreamWriter("magyarok.txt");
sw.WriteLine(elsosor);
foreach (var item in lista)
{
	if (item.Orszag == "HUN")
	{
		sw.WriteLine($"{item.Helyezes};{item.Eredmeny};{ item.Nev};{item.Orszag};{ item.Helyszin};{item.Datum}");
	}
}
sw.Flush();
sw.Close();