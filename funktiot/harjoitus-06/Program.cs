void LaskeSumma(int[] luvut)
{
    int summa = 0;
    foreach (int luku in luvut)
    {
        summa += luku;
    }

    Console.WriteLine(summa);
}

void LaskeSumma2(int[] luvut)
{
    // Numeraalisia arvoja sisältävillä kokoelmilla voi arvojen summan
    // saada käyttämällä Sum-funktiota.
    int summa = luvut.Sum();
    Console.WriteLine(summa);
}

int[] nums = { 1, 2, 3 };
LaskeSumma(nums);

LaskeSumma2(nums);