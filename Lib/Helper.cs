namespace Contacts.Lib;

public class Helper
{
    public static void Dump(params object[] items)
    {
        foreach (var t in items)
        {
            System.Console.WriteLine(t);
        }
    }
}