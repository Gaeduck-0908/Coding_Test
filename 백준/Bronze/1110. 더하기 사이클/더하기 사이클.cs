using System;

namespace ABCD
{
    class Program
    {
        static void Main(string[] args)
        {
            string g = Console.ReadLine();
            int count = 0;
            int sum;
            int first;
            int second;

            if (int.Parse(g) < 10) 
            {
                g = g + 0;
            }
            string original = g;

            while (true)
            {
                count++;

                first = int.Parse(g) / 10;
                second = int.Parse(g) % 10;
                sum = first + second;

                g = second.ToString() + (sum % 10).ToString();

                if (int.Parse(g) == int.Parse(original)) break;
            }
            Console.WriteLine(count);
        }
    }
}