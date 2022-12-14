namespace oop_hissi;
class Program
{
    static void Main(string[] args)
    {
        Elevator ele = new Elevator(5);
        Console.WriteLine("liikkuu: " + ele.IsMoving);
        ele.PrintLocation();
        ele.Move(5);
        ele.Move(3);
        ele.Move(5);
        ele.Move(1);
        ele.Move(6);
        Console.WriteLine($"kerros: {ele.CurrentFloor}");
    }
}
