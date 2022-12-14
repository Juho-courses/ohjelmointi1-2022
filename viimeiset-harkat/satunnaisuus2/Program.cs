Console.Write("luku 1: ");
int luku1 = int.Parse(Console.ReadLine());
Console.Write("luku 2: ");
int luku2 = int.Parse(Console.ReadLine());

if (luku1 > 0 && luku2 > 0)
{
    Random r = new Random();
    if (luku1 < luku2)
    {
        Console.WriteLine(r.Next(luku1, luku2));
    }
    else
    {
        Console.WriteLine(r.Next(luku2, luku1));
    }
}