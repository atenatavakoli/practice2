using System.Diagnostics;

var timer = new Stopwatch();
timer.Start();


int n = 1000;
int m = 10000000;
bool check;

for (int i = n + 1; i < m; i++)
{
	check = true;
	for (int j = 2; (check && j < i); j++)
		if (i % j == 0)
			check = false;

	if (check)
		Console.Write("{0} ", i);
}



//B: Run stuff you want timed
timer.Stop();


Console.WriteLine();
Console.WriteLine("Execution time is: " + timer.ElapsedMilliseconds + "ms");