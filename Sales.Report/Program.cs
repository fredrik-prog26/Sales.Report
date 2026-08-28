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
