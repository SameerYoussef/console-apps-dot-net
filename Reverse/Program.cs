string hex = "24";
int eger = int.Parse(hex, System.Globalization.NumberStyles.HexNumber);
Console.WriteLine($"Hex value: {hex} as Int is: {eger} then back to Hex as {eger.ToString("X")}");

var before = new int[] { 1, 2, 3 };
Console.WriteLine(String.Join(" - ", before));

var reverse = new int[before.Length];

for (var i = 0; i < before.Length; i++)
{
    reverse[i] = before[before.Length - 1 - i];
}

for (var i = 0; i < before.Length / 2; i++)
{
    int temp = before[i];
    before[i] = before[before.Length - 1 - i];
    before[before.Length - 1 - i] = temp;
}

Console.WriteLine(String.Join(" - ", reverse));
Console.WriteLine(String.Join(" - ", before));

Two[] outer()
{
    return one() ?? throw new Exception("uh oh");
}

Console.WriteLine($"ifal is {outer()}");

Two[] one()
{
    Console.Write("n for null one()");
    var input = Console.ReadLine();
    if (input == "n") {
        return null;
    }
    return new Two[] {};
}

class Two
{
    string[] two()
    {
        Console.Write("n for null two()");
        var input = Console.ReadLine();
        if (input == "n") {
            return null;
        }
        return new string[] {"good"};
    }
}