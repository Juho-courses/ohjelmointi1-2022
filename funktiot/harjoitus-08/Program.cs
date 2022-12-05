int Kertolasku(int a, int b)
{
    // kertolasku on tapa kirjoittaa pitkät pluslaskut sievemmin
    // 4 * 5 == 5 + 5 + 5 + 5

    // lisätään summaan a:n arvo b-kertaa
    int summa = 0;
    for (int i = 0; i < b; i++)
    {
        summa += a;
    }
    return summa;
}

Console.WriteLine(Kertolasku(4, 5));