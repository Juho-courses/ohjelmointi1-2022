void TulostaKertotauluLuvulle(int luku)
{
    for (int i = 1; i <= 10; i++)
    {
        int tulo = i * luku;
        Console.WriteLine(i + " * " + luku + " = " + tulo);
    }
}

void TulostaTaulutAsti(int n)
{
    for (int i = 1; i <= n; i++)
    {
        TulostaKertotauluLuvulle(i);
    }
}

TulostaTaulutAsti(8);