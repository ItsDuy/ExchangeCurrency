namespace Exhangecurrency;

class Program
{
    static void Main(string[] args)
    {
        double Rate=23000;
        double USD,VND;
        Console.WriteLine("Enter the amount of USD you want to exhange into VND");
        double.TryParse(Console.ReadLine(), out USD);
        VND=Rate*USD;
        Console.WriteLine($"You received {VND} dong");
    }
}
