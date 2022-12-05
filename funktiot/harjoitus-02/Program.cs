int[] LuoArray(int n)
{
    int[] ret = new int[n + 1];

    for (int i = 0; i < ret.Length; i++)
    {
        ret[i] = i;
    }

    return ret;
}

int[] taulukko = LuoArray(4);
foreach (int luku in taulukko)
{
    Console.Write(luku + " ");
}
Console.WriteLine();