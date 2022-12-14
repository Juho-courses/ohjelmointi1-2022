namespace oop3;
class Program
{
    static void Main(string[] args)
    {
        Person tyyppi = new Person("Jake", 16);
        Console.WriteLine(tyyppi.Age);
        tyyppi.MakeOlder();
        Console.WriteLine(tyyppi.Age);

        tyyppi.SetAddress("katu", 112);
        tyyppi.Address.Print();
        tyyppi.Address.ChangeAddress("toinenkatu", 32);
        tyyppi.Address.Print();
    }
}
