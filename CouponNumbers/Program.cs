
using System;

public class CouponNumbers
{
    public static int getNumber(int n)
    {
        int[] randNum = new int[n];

        int count = 0;
        bool hasRepeatNum = true;

        while (hasRepeatNum)
        {
            count++;
            int randomNumber = generateRandomNumber(n);

            int i;
            for (i = 0; i < n; i++)
            {
                if (randNum[i] == 0)
                {
                    randNum[i] = randomNumber;
                    break;
                }
                else if (randomNumber == randNum[i])
                {
                    break;
                }
            }
            if (i == n)
            {
                hasRepeatNum = false;
            }
        }
        return count;
    }

    public static int generateRandomNumber(int maxVal)
    {
        Random r = new Random();
        return r.Next(1, maxVal + 1);
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Input number of distinct coupons:");
        int n = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Total random numbers needed to generate distinct coupon numbers: " + CouponNumbers.getNumber(n));
    }
}