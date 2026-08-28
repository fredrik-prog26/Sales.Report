List<string> productNames = [];
List<decimal> saleAmounts = [];

Console.WriteLine("Välkommen till försäljningsrapporten");
Console.WriteLine();

while (true)
{
    Console.WriteLine("Ange produktnamn");
    string namn = Console.ReadLine();
    Console.WriteLine("Ange försäljningsbeloppet");
    string salesamount = Console.ReadLine();

    if (decimal.TryParse(salesamount, out decimal result))
    {
        productNames.Add(namn);
        saleAmounts.Add(result);
    }
    else
    {
        Console.WriteLine("incorrect amount");
    }
}    