namespace Prime_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number : ");
            int Num=Convert.ToInt32(Console.ReadLine());
            int inc = 0;
            if(Num>1) {
            for(int i = 1; i <=Num; i++)
                {
                   if(Num%i==0 ) {
                    inc++;
                    }
                }
            
            }
            if (inc == 2)
            {
                Console.WriteLine("It is prime number : ",Num);
            }
            else
            {
                Console.WriteLine("It is not prime number", Num);
            }
        }
    }
}