void TulostaTaulukko(int[] taulukko)
{
    foreach (int luku in taulukko)
    {
        Console.WriteLine(luku);
    }
}

int[] taulukko = { 1, 2, 3, 4, 5 };
TulostaTaulukko(taulukko);