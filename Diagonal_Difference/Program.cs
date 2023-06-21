

List<int> a = new List<int>() { 1, 2, 3 };
List<int> b = new List<int>() { 3, 2, 1 };

foreach (var item in compareTriplets(a, b))
{
    Console.WriteLine(item);
}


List<int> compareTriplets(List<int> a, List<int> b)
{
    List<int> result = new List<int>() { 0, 0 };
    for (int i = 0; i < 3; i++)
    {
        if (a[i] > b[i])
        {
            result[0] += 1;
        }
        else if (a[i] < b[i])
        {
            result[1] += 1;
        }
    }
    return result;
}