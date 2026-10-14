using MoziJegyeladasFajlbol;

List<Film>filmek=new List<Film>();

foreach (string beolvasott in File.ReadAllLines("filmek.txt.txt").Skip(1))
{
    string[] vagas = beolvasott.Split(";");
    Film aktualis=new Film();
    aktualis.Cim = vagas[0];
    aktualis.EladottJegyek=int.Parse(vagas[1]);
    aktualis.JegyAr=int.Parse(vagas[2]);
    filmek.Add(aktualis);


}
Console.WriteLine("========================================");
Console.WriteLine("Vetített filmek és bevételek:");
int osszesen = 0;
foreach (Film aktualis in filmek)
{
    Console.WriteLine($"\t- {aktualis.Cim}: {aktualis.EladottJegyek} db jegy -> Bevétel: {aktualis.JegyAr*aktualis.EladottJegyek} Ft");
    osszesen += aktualis.EladottJegyek;
}

//int osszesen2= filmek.Sum(a=>a.EladottJegyek);
Console.WriteLine($"Összes eladott jegy: {osszesen} db");

Console.WriteLine($"Összes napi jegybevétel: {filmek.Sum(a=>a.EladottJegyek*a.JegyAr)} Ft");
Console.WriteLine($"Átlagos eladott jegyszám/film: {filmek.Average(a=>a.EladottJegyek):F0} db");