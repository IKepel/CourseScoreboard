using CourseScoreboard;

var usd = new CurrencyRateBoard<string>("USD", 37.5, 38.1);
var eur = new CurrencyRateBoard<string>("EUR", 40, 40.7);
var pln = new CurrencyRateBoard<string>("PLN", 8.6, 9.05);

pln.ChangeRate(9, 10.5);
usd.ChangeRate(38, 39);
pln.ChangeRate(8.7, 9.15);
eur.ChangeRate(41, 41.7);
usd.ChangeRate(5, 5.4);
Console.WriteLine();

usd.PrintHistory();
pln.PrintHistory();
eur.PrintHistory();

Console.WriteLine("\nCurrent currency values:");
Console.WriteLine(usd);
Console.WriteLine(eur);
Console.WriteLine(pln);