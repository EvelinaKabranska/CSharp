using System;

namespace TopNumber
{
    class Program
    {
        
            static void Main(string[] args)
            {
                int num = int.Parse(Console.ReadLine());
                IsTopNumber(num);
            }

            private static void IsTopNumber(int num)
            {
                for (int i = 1; i <= num; i++)
                {
                    int sum = 0;
                    bool oddDig = false;
                    int n = i;
                    while (true)
                    {
                        if (n == 0) break;
                        int right = n % 10;
                        sum += right;
                        if (!(right % 2 == 0)) oddDig = true;
                        n /= 10;
                    }
                    if (sum % 8 == 0 && oddDig == true)
                    {
                        Console.WriteLine(i);
                    }

                }
            }
        
    }
}
