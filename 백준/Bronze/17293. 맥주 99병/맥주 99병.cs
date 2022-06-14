int input = int.Parse(Console.ReadLine());

for(int i = input; i >= 0; i--)
{
	if (i > 2)
	{
		Console.Write("{0} bottles of beer on the wall, {1} bottles of beer.\n", i, i);
		Console.Write("Take one down and pass it around, {0} bottles of beer on the wall.\n\n", i - 1);
	}
	else if (i == 2)
	{
		Console.Write("2 bottles of beer on the wall, 2 bottles of beer.\n");
		Console.Write("Take one down and pass it around, 1 bottle of beer on the wall.\n\n");
	}
	else if (i == 1)
	{
		Console.Write("1 bottle of beer on the wall, 1 bottle of beer.\n");
		Console.Write("Take one down and pass it around, no more bottles of beer on the wall.\n\n");
	}
}

Console.Write("No more bottles of beer on the wall, no more bottles of beer.\n");
if (input == 1)
{
	Console.Write("Go to the store and buy some more, 1 bottle of beer on the wall.\n");
}
else
{
	Console.Write("Go to the store and buy some more, {0} bottles of beer on the wall.\n", input);
}