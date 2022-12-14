namespace oop_puhelin;
class Program
{
    static void Main(string[] args)
    {
        Phone luuri = new Phone("Xiaomi");
        Console.WriteLine(luuri.Model);

        luuri.EndCall();

        luuri.Call("+358321");
        luuri.EndCall();

        luuri.Call("123123");
        luuri.Call("33321");
        luuri.EndCall();

    }
}
