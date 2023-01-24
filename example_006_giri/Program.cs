int a = 1;
int b = 5;
int c = 3;
int d = 8;
int e = 2;

int max = a;
if (max < b) max = b;
if (max < c) max = c;
if (max < d) max = d;
if (max < e) max = e;

Console.Write("Самое большое число - ");
Console.WriteLine(max);