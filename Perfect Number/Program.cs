namespace Perfect_Number
{
    internal class Perfect_Number
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number : ");
            int sum = 0;
            int target = Convert.ToInt32(Console.ReadLine());
            if (target > 0)
            {
                for (int i = 1; i < target; i++)
                {
                    if (target % i == 0)
                    {
                        Console.WriteLine(i);
                        sum = sum + i;
                    }
                }
                if (sum == target)
                {
                    Console.WriteLine();
                    Console.WriteLine("it is perfect number : "+sum);
                }
                else
                {
                    Console.WriteLine("it is not perfect number : " + sum);
                }
            }
            else { Console.WriteLine("Please Enter only Positive number"); }
        }
    }
}