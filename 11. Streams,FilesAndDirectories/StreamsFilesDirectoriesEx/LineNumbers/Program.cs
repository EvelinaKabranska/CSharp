using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace LineNumbers
{
    class Program
    {
        private static int[] CerCounts(string line)
        {
            int count = 0;
            int count2 = 0;
            foreach (var item in line)
            {
                if(char.IsLetter(item))
                {
                    count2++;
                }
                
                if(item=='-'||item==','||item=='!'||item=='?'||item=='.' ||item == '\'')
                {
                    count++;
                }
                
            }
              int[] som = { count, count2 };
            return som;
           
        }
       
        static void Main(string[] args)
        {
            using var sent = new StreamReader("text.txt");
            using var writer = new StreamWriter("../../../output.txt");
            string cur = string.Empty;
            int count = 1;
            while ((cur=sent.ReadLine())!=null)
            {
                
                int[] a = CerCounts(cur);

                writer.WriteLine($"Line {count}:{cur}({a[1]})({a[0]})");
                count++;
            }
        }
    }
}