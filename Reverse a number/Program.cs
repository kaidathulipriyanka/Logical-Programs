using System;

namespace Reverse_a_number
{
    internal class ProgramReverse_a_number
    {
        static void Main(string[] args)
        {
             Console.WriteLine("Enter number :");
            int num=Convert.ToInt32(Console.ReadLine());
            int div = 0;
            while (num > 0)
            {
                div = num % 10;
                Console.Write(div);
                num =num / 10;
            }
        }
    }
}