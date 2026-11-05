using RollerKolcsonzo;
List<RollerUtazas> utazasok = new List<RollerUtazas>();
string[] sorok = File.ReadAllLines("rollerek.txt");
foreach (string sor in sorok)
{
    utazasok.Add(new RollerUtazas(sor));
}
Console.WriteLine($"Utazások részletei:");
foreach (RollerUtazas aktualis in utazasok)
{
    Console.WriteLine(aktualis);
}
Console.WriteLine("");
Console.WriteLine("Statisztika:");
int ossz= utazasok.Sum(a => a.FizetendoDij());
var leghossz = utazasok.MaxBy(a => a.UtazasiIdoPerc);
double oszkm = utazasok.Sum(a => a.MegtettKm);
Console.WriteLine($"Kölcsönző teljes napi bevétele: {ossz} Ft");
Console.WriteLine($"Leghosszabb utazás: {leghossz.Felhasználonev} ({leghossz.UtazasiIdoPerc} perc)");
Console.WriteLine($"Összes megtett kilóméter kerekítve: {oszkm:f0} km");