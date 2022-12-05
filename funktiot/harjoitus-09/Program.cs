void TulostaKertotauluLuvulle(int luku)
{
    for (int i = 1; i <= 10; i++)
    {
        int tulo = i * luku;
        Console.WriteLine(i + " * " + luku + " = " + tulo);
    }
}

TulostaKertotauluLuvulle(1);
TulostaKertotauluLuvulle(2);
TulostaKertotauluLuvulle(3);