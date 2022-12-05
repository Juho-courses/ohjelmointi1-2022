int GetMax(int[] arr)
{
    // Loopataan kaikki läpi ja katsotaan mikä on isoin.
    // Alkuarvoksi vertailuun otetaan taulukon ensimmäinen jäsen.
    int max = arr[0];
    foreach (int num in arr)
    {
        if (num > max)
        {
            max = num;
        }
    }
    return max;
}

int GetMax2(int[] arr)
{
    // Joiltakin kokoelmilta voi kysellä niiden suurinta arvoa
    // Max-funktion avulla
    return arr.Max();
}

int[] nums = { 1, 3, 4, 5 };
Console.WriteLine("suurin arvo: " + GetMax(nums));

int[] nums2 = { 16, 32, 4, 5 };
Console.WriteLine("suurin arvo: " + GetMax(nums2));

Console.WriteLine("suurin arvo: " + GetMax2(nums));

Console.WriteLine("suurin arvo: " + GetMax2(nums2));