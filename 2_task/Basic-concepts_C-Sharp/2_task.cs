using System;

namespace Basic_concepts_C_Sharp
{
    class Program
    {
        static void Main(string[] args)
        {

            String n,x;
            x = "";

            Console.Write("Введите число:");
            n = Console.ReadLine();

            for (int step = 0; step < n.Length; step++)
            {
                if (step == 1)
                {
                    continue;
                }
                x += n[step];
            }
            x += n[1];

            Console.WriteLine(x);
            

        }
    }
}
