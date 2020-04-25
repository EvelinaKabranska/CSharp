using System;
using System.IO;
using System.Text;

namespace Line_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var reader = new StreamReader("input.txt"))
            {
                string line = string.Empty;
                int couter = 1;

                    using (var writer = new StreamWriter(@"../../../output.txt"))
                    {
                    while ((line = reader.ReadLine()) != null)
                    {
                        writer.WriteLine($"{couter}. {line}");
                        couter++; 
                    }
                }

            }
        }
    }
}
