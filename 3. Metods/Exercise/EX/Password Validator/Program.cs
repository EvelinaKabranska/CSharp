using System;

namespace Password_Validator
{
    class Program
    {
        static bool corect = true;
        static void Main(string[] args)
        {
            string pass = Console.ReadLine();
            CheckCount(pass);
            CheckLettersDigits(pass);
            CheckTwoDigits(pass);
            if (corect == true)
            {
                Console.WriteLine("Password is valid");
            }

        }
        static void CheckCount(string pass)
        {
            if (pass.Length < 6 || pass.Length > 10)
            {
                Console.WriteLine("Password must be between 6 and 10 characters");

            }
            else
            {
                return;
            }
        }
        static void CheckLettersDigits(string pass)
        {

            for (int i = 0; i < pass.Length; i++)
            {
                if (pass[i] > 122 || pass[i] < 97 && pass[i] > 90 || pass[i] < 65 && pass[i] > 57 || pass[i] < 48)
                {
                    corect = false;
                }

            }
            if (corect == false)
            {
                Console.WriteLine("Password must consist only of letters and digits");
            }
            else
            {
                return;
            }
        }
        static void CheckTwoDigits(string pass)
        {
            corect = true;
            int count = 0;
            for (int i = 0; i < pass.Length; i++)
            {
                if (pass[i] >= 48 && pass[i] <= 57)
                {
                    count++;
                }

            }
            if (count >= 2)
            {
                return;
            }
            else
            {
                Console.WriteLine("Password must have at least 2 digits");
                corect = false;
            }
        }
    }
}
