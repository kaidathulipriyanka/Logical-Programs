namespace Fibonacci
{
    internal class Fibonacci
    {
        static void Main(string[] args)
        {
            int first=0, second=1,sum=0,inc=0;
            Console.WriteLine("Enter number : ");
            int target=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(first+"\n"+second);
            while(inc!=(target-2)){  
                sum=first + second; 
                Console.WriteLine(sum);
                first =second;
                second=sum;
                inc++; 
            }
        }
    }
}

          