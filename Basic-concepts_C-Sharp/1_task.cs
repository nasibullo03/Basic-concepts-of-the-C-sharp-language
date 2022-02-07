using System;

namespace Basic_concepts_C_Sharp
{
    class Program
    {
        static void Main(string[] args)
        {

            
            int n, a, result;



            Console.Write("Введите число a:");
            a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите число n:");
            n = Convert.ToInt32(Console.ReadLine());
            result = a;
            
            for (int step = 0; step <n; step++)
            {
                result *= a;
            }

            Console.WriteLine(result);
            

        }
    }
}
