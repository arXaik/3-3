//Петросян Араик 3.3 
    var n = 1;
var x = 0.3;
var s = Math.Cos(x);
var epsilon = 0.0001;
while (true)
{
    n = n + 2;
    var s1 = s + Math.Sin(n * x) / n;
    if (Math.Abs(s - s1) < epsilon) break;
    s = s1;
    Console.WriteLine(s);
}