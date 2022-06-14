int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());

Console.WriteLine((b % 10) * a);
Console.WriteLine(((b % 100) / 10) * a);
Console.WriteLine(((b % 1000) / 100) * a);
Console.WriteLine(a * b);