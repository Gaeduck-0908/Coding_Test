string [] input = Console.ReadLine().Split(' ');

if(int.Parse(input[0]) > int.Parse(input[1]))
{
    Console.WriteLine(">");
}
else if (int.Parse(input[0]) < int.Parse(input[1]))
{
    Console.WriteLine("<");
}
else
{
    Console.WriteLine("==");
}