int a = 45;
int b = 2;
int c = 145;
int max =0;
if (a >= b && a >= c) max = a;
if (b >= a && b >= c) max = b;
if (c >= a && c >= b) max = c;
Console.WriteLine(max);