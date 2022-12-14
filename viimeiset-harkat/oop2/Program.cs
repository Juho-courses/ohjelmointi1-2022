namespace oop2;
class Program
{
    static void Main(string[] args)
    {
        Address osoite = new Address("satakunnankatu", 23);
        osoite.Print();
        osoite.ChangeAddress("karjalankatu", 14);
        osoite.Print();
    }
}
