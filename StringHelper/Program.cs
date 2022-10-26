Console.WriteLine("one".EqualsAny(StringComparer.OrdinalIgnoreCase, new string[] {"ONE", "two"}));
Console.WriteLine("one".EqualsAny(new string[] {"one", "two"}));
Console.WriteLine("one".EqualsAny(StringComparer.OrdinalIgnoreCase, (new string[] {"one", "two"}).OrderBy(v => v)));
Console.WriteLine("one".EqualsAny((new string[] {"one", "two"}).OrderBy(v => v)));

Console.WriteLine("one".EqualsAny(StringComparer.OrdinalIgnoreCase, new string[] {"xONE", "two"}));
Console.WriteLine("one".EqualsAny(new string[] {"xone", "two"}));
Console.WriteLine("one".EqualsAny(StringComparer.OrdinalIgnoreCase, (new string[] {"xone", "two"}).OrderBy(v => v)));
Console.WriteLine("one".EqualsAny((new string[] {"xone", "two"}).OrderBy(v => v)));

public static class StringExtensionsHelper
{
    public static bool EqualsAny(this string target, StringComparer comparer, params string[] values)
    {
        return target.EqualsAny(comparer, (IEnumerable<string>)values);
    }

    public static bool EqualsAny(this string target, params string[] values)
    {
        return target.EqualsAny((IEnumerable<string>)values);
    }

    public static bool EqualsAny(this string target, StringComparer comparer, IEnumerable<string> values)
    {
        return values.Contains(target, comparer);
    }

    public static bool EqualsAny(this string target, IEnumerable<string> values)
    {
        return values.Contains(target, StringComparer.OrdinalIgnoreCase);
    }
}
