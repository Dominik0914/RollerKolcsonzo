using RollerKolcsonzo;
List<RollerUtazas> utazasok = new List<RollerUtazas>();
string[] sorok = File.ReadAllLines("rollerek.txt");
foreach (string sor in sorok)
{
    utazasok.Add(new RollerUtazas(sor));
}
