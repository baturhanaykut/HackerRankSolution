void plusMinus(List<int> arr)
{
	decimal a = 0;
	decimal b = 0;
	decimal c = 0;
	for (int i = 0; i < arr.Count; i++)
	{
	
		if (arr[i]>0)
		{
			a++;
		}
		else if (arr[i]==0)
		{
			b++;
		}
		else
		{
			c++;
		}
	}
	a = a / arr.Count;
	b = b / arr.Count;
	c = c / arr.Count;


	Console.WriteLine(String.Format("{0:0.000000}",a));

    Console.WriteLine(String.Format("{0:0.000000}",b));
	Console.WriteLine(String.Format("{0:0.000000}",c));
}


plusMinus(new List<int>() { 1,1,0,-1,-1 });