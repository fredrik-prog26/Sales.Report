List<string> productNames = [];
List<decimal> saleAmounts = [];

Console.WriteLine("Välkommen till försäljningsrapporten");
Console.WriteLine();

while (true)
{
    Console.WriteLine("Ange produktnamn eller skriv klar");
    string name = Console.ReadLine();
    if (name == "klar")
        break;
    Console.WriteLine("Ange försäljningsbeloppet");
    string salesamount = Console.ReadLine();

    if (decimal.TryParse(salesamount, out decimal result))
    {
        Console.WriteLine("Försäljningen har registrerats");
        productNames.Add(name);
        saleAmounts.Add(result);
    }
    else
    {
        Console.WriteLine("Ogiltig summa");
        
    }

}

Console.WriteLine("Dagens försäljningar");
for (int i = 0; i < productNames.Count; i++)
{
    Console.WriteLine($"{productNames[i]}: {saleAmounts[i]} kr");
}

Console.WriteLine("Sammanfattning");
Console.WriteLine($"Antal försäljningar: {productNames.Count}");

Console.WriteLine($"Total försäljning: {saleAmounts.Sum()} kr");

Console.WriteLine($"Genomsnittlig försäljning: {saleAmounts.Average()} kr");
Console.WriteLine($"Största försäljningen: {saleAmounts.Max()} kr");



var bigSales = saleAmounts.Where(s => s > 1000).Count();
Console.WriteLine($"sales over 1000 kr: {bigSales}");

var totalSale = saleAmounts.Sum();
switch (totalSale)
{
    case < 5000:
        Console.WriteLine("Resultat: Svag försäljningsdag");
        break;

    case >= 5000 and < 10000:
        Console.WriteLine("Dagens försäljning är medel");
        break;

    case >= 10000:
        Console.WriteLine("Dagens försäljning är hög");
        break;

        default:
        break;
}