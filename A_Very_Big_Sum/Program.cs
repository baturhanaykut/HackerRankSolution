long aVeryBigSum(List<long> ar)
{
	long sum =0;
	foreach (var item in ar)
	{
        sum += item;
	}
    return sum;
}

List<long> sayilar = new List<long>() {1,2,3,4,5 };

Console.WriteLine(aVeryBigSum(sayilar));