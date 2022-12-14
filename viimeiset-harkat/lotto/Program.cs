// tehtävä 4
int[] LuoLottorivi()
{
    // tämä rajaa lukumäärän
    int[] rivi = new int[7];

    int maara = 0;
    Random r = new Random();
    while (maara < 7)
    {
        int numero = r.Next(1, 41);

        // jos sisältää jo arvotun luvun,
        // otetaan uudestaan
        if (rivi.Contains(numero))
        {
            continue;
        }

        // ollaan varmoja siitä, että luvut ovat uniikkeja
        rivi[maara] = numero;
        maara++;

    }

    return rivi;
}

// ei kuulu tehtäviin, helpottaa vaan kehitystä
void TulostaRivi(int[] rivi)
{
    foreach (int n in rivi)
    {
        Console.Write(n + " ");
    }
    Console.WriteLine();
}

// tehtävä 5
bool RiviOk(int[] rivi)
{
    // pituuden tarkistus
    if (rivi.Length != 7)
    {
        return false;
    }

    // rangen tarkistus, vaihtoehto 1
    foreach (int n in rivi)
    {
        if (n < 1 || n > 40)
        {
            return false;
        }
    }
    // rangen tarkistus, vaihtoehto 2
    // if (!rivi.All(luku => luku > 0 && luku < 41))
    // {
    //     return false;
    // }

    // uniikkitarkistus, vaihtoehto 1
    // for (int i = 0; i < rivi.Length; i++)
    // {
    //     for (int j = i + 1; j < rivi.Length; j++)
    //     {
    //         if (rivi[i] == rivi[j])
    //         {
    //             return false;
    //         }
    //     }
    // }
    // uniikkitarkistus, vaihtoehto 2
    Array.Sort(rivi);
    for (int i = 0; i < rivi.Length - 1; i++)
    {
        if (rivi[i] == rivi[i + 1])
        {
            return false;
        }
    }

    // päästiin tänne, rivi ok
    return true;
}

// tehtävä 6
void KysyJaLuo()
{
    Console.Write("montako lottoriviä arvotaan: ");
    int maara = int.Parse(Console.ReadLine());

    int rivi_maara = 0;
    while (rivi_maara < maara)
    {
        int[] rivi = LuoLottorivi();
        if (RiviOk(rivi) == true)
        {
            TulostaRivi(rivi);
            rivi_maara++;
        }
    }
}

// tehtävä 7
void KayttajanRivi()
{
    int[] rivi = new int[7];
    // vaihtoehto 1
    // for (int i = 0; i < rivi.Length; i++)
    // {
    //     Console.Write("lottonumero: ");
    //     int n = int.Parse(Console.ReadLine());
    //     rivi[i] = n;
    // }

    // vaihtoehto 2
    Console.Write("lottorivi, pilkuilla eroteltuna: ");
    string[] rivi_str = Console.ReadLine().Split(",");
    for (int i = 0; i < rivi_str.Length; i++)
    {
        rivi[i] = int.Parse(rivi_str[i]);
    }

    if (RiviOk(rivi) == true)
    {
        Console.WriteLine("rivi ok");
    }
    else
    {
        Console.WriteLine("rivi viallinen");
    }

}

KayttajanRivi(); // tehtävä 7

// KysyJaLuo(); // tehtävä 6

// // testejä
// TulostaRivi(LuoLottorivi());
// // oikea rivi
// Console.WriteLine("pitäisi olla true: " + TarkistaRivi(new int[] { 1, 2, 3, 4, 5, 6, 7 }));
// // oikea rivi
// Console.WriteLine("pitäisi olla true: " + TarkistaRivi(new int[] { 32, 12, 1, 10, 8, 4, 3 }));
// // liian lyhyt
// Console.WriteLine("pitäisi olla false: " + TarkistaRivi(new int[] { 2, 3, 4, 5, 6, 7 }));
// // liian pitkä
// Console.WriteLine("pitäisi olla false: " + TarkistaRivi(new int[] { 2, 3, 4, 5, 6, 7, 8, 9 }));
// // liian pieni numero
// Console.WriteLine("pitäisi olla false: " + TarkistaRivi(new int[] { 0, 2, 3, 4, 5, 6, 7 }));
// // liian iso numero
// Console.WriteLine("pitäisi olla false: " + TarkistaRivi(new int[] { 1, 2, 3, 4, 5, 6, 41 }));
// // ei uniikkeja
// Console.WriteLine("pitäisi olla false: " + TarkistaRivi(new int[] { 1, 32, 3, 4, 5, 6, 32 }));

