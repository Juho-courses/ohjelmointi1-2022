int FilterNumbers(int k, int[] the_list)
{
    int count = 0;
    foreach (int num in the_list)
    {
        if (num >= k)
        {
            count++;
        }
    }
    return count;
}

int[] nums = { 1, 2, 3, 4, 5 };
// WriteLinen argumenttina annetaan funktio, jonka paluuarvo tulostetaan
Console.WriteLine(FilterNumbers(6, nums));