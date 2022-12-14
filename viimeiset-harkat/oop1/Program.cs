namespace oop1;
class Program
{
    static void Main(string[] args)
    {
        Car auto = new Car("Volvo");
        Console.WriteLine(auto.Manufacturer);
        Console.WriteLine(auto.Miles);
        auto.Drive(123);
        Console.WriteLine(auto.Miles);

    }
}
